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
            var Planilha = LivroDeTrabalho.Worksheet(1);

            foreach (var linha in Planilha.RowsUsed().Skip(1)) {
                int item = linha.Cell(1).GetValue<int>();
                string descri = linha.Cell(2).GetValue<string>();
                int quantidade = linha.Cell(3).GetValue<int>();
                string marca = linha.Cell(4).GetValue<string>();
                string local = linha.Cell(5).GetValue<string>();

                tabela.Rows.Add(item, descri, quantidade, marca, local);
            }
        }

        return tabela;
    }
}