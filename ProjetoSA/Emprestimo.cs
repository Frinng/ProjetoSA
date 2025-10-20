using ClosedXML.Excel;
using System.Data;
using System.Windows.Forms;

namespace ProjetoSA
{
    public static class Emprestimo {
        public static string CaminhoDoEstoque = Path.Combine(
            Application.StartupPath, // Pega a pasta onde o .exe está
            "PLanilhaSimuladoEstoque.xlsx" // Procura o arquivo na MESMA pasta
        );

        public static DataTable LerPlanilhas() {
            DataTable tabela = new DataTable();

            // Adicionando as novas colunas
            tabela.Columns.Add("Item");
            tabela.Columns.Add("Descrição da Ferramenta");
            tabela.Columns.Add("Quantidade");
            tabela.Columns.Add("Marca/Modelo");
            tabela.Columns.Add("Estado");
            tabela.Columns.Add("Localização");
            tabela.Columns.Add("Código da Ferramenta");

            using (var LivroDeTrabalho = new XLWorkbook(CaminhoDoEstoque)) {
                var Planilha = LivroDeTrabalho.Worksheet(2); // Pega a segunda aba (Ferramentas)

                // Pula o cabeçalho (Skip(1)) e lê apenas as linhas usadas
                foreach (var linha in Planilha.RowsUsed().Skip(1)) {
                    
                    // --- CORREÇÃO DE LEITURA ---
                    // Tenta ler o Item. Se falhar, 'item' será 0.
                    int item;
                    linha.Cell(1).TryGetValue(out item);

                    string descri = linha.Cell(2).GetValue<string>();

                    // Tenta ler a Quantidade. Se falhar (célula vazia), 'quantidade' será 0.
                    int quantidade;
                    if (!linha.Cell(3).TryGetValue(out quantidade)) {
                        quantidade = 0;
                    }
                    
                    string marca = linha.Cell(4).GetValue<string>();
                    string estado = linha.Cell(5).GetValue<string>();
                    string local = linha.Cell(6).GetValue<string>();
                    string codigo = linha.Cell(7).GetValue<string>();
                    // --- FIM DA CORREÇÃO ---


                    // --- FILTRO DE DISPONÍVEIS ---
                    // Só adiciona a linha na tabela se a quantidade for maior que 0
                    if (quantidade > 0) {
                        tabela.Rows.Add(item, descri, quantidade, marca, estado, local, codigo);
                    }
                    // --- FIM DO FILTRO ---
                }
            }

            return tabela;
        }
    }
}