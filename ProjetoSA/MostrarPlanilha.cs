using ClosedXML.Excel;
using System.Data;
namespace ProjetoSA;

public static class MostrarPlanilha {
    public static string CaminhoDoEstoque = Path.Combine(
        Application.StartupPath, // Pega a pasta onde o .exe está
        "PLanilhaSimuladoEstoque.xlsx"      // Procura o arquivo na MESMA pasta
    );
    
    public static DataTable LerPlanilhas() {

        DataTable tabela = new DataTable();
        
        tabela.Columns.Add("Item");
        tabela.Columns.Add("Descrição");
        tabela.Columns.Add("Quantidade");
        tabela.Columns.Add("Marca/Modelo");
        tabela.Columns.Add("Localização");

        using (var LivroDeTrabalho = new XLWorkbook(CaminhoDoEstoque)) {
            
            // CORREÇÃO 1: Voltei para a Planilha 1, que é a de Estoque.
            var Planilha = LivroDeTrabalho.Worksheet(1); 

            foreach (var linha in Planilha.RowsUsed().Skip(1)) {
                
                // CORREÇÃO 2: Leitura segura para evitar erros
                int item;
                linha.Cell(1).TryGetValue(out item); // Se falhar, item = 0

                string descri = linha.Cell(2).GetValue<string>();

                int quantidade;
                if (!linha.Cell(3).TryGetValue(out quantidade)) // Tenta ler a quantidade
                {
                    quantidade = 0; // Define 0 se a célula estiver vazia
                }

                string marca = linha.Cell(4).GetValue<string>();
                string local = linha.Cell(5).GetValue<string>();

                
                // ADAPTADO: Filtra para mostrar apenas disponíveis (Quantidade > 0)
                if (quantidade > 0)
                {
                    tabela.Rows.Add(item, descri, quantidade, marca, local);
                }
            }
        }

        return tabela;
    }
}