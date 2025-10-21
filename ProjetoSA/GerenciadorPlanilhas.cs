// Arquivo: GerenciadorPlanilhas.cs
using ClosedXML.Excel;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoSA {
    public static class GerenciadorPlanilhas {
        // ------------------- Caminhos -------------------
        public static string CaminhoDoEstoque = Path.Combine(Application.StartupPath, "PLanilhaSimuladoEstoque.xlsx");
        private static string CaminhoPlanilhaLog = Path.Combine(Application.StartupPath, "PLanilhaEmpresgravados.xlsx");
        private static string CaminhoPlanilhaLogin = Path.Combine(Application.StartupPath, "BancoDeDados.xlsx");

        // ------------------- LOGIN -------------------
        public static string FazerLogin(string usuario, string senha) {
            try {
                using (var wb = new XLWorkbook(CaminhoPlanilhaLogin)) {
                    var ws = wb.Worksheet(1);
                    int ultimaLinha = ws.LastRowUsed().RowNumber();

                    for (int i = 2; i <= ultimaLinha; i++) {
                        string nomePlanilha = ws.Cell(i, 1).GetString();
                        string senhaPlanilha = ws.Cell(i, 2).GetString();

                        if (nomePlanilha == usuario && senhaPlanilha == senha)
                        {
                            if (usuario.Equals("ADMIN", StringComparison.OrdinalIgnoreCase) && senha.Length < 5)
                                return "ADMIN";
                            else
                                return "SUCESSO";
                        }
                    }
                }

                return "FALHA";
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao acessar planilha: " + ex.Message,
                    "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "ERRO";
            }
        }

        // ------------------- LEITURA DO ESTOQUE -------------------
        public static DataTable LerEstoque() {
            DataTable tabela = new DataTable();
            tabela.Columns.Add("Item");
            tabela.Columns.Add("Descrição");
            tabela.Columns.Add("Quantidade");
            tabela.Columns.Add("Marca/Modelo");
            tabela.Columns.Add("Estado");
            tabela.Columns.Add("Localização");
            tabela.Columns.Add("Código");

            if (!File.Exists(CaminhoDoEstoque))
                return tabela;

            using (var wb = new XLWorkbook(CaminhoDoEstoque)) {
                var ws = wb.Worksheet(1);
                foreach (var linha in ws.RowsUsed().Skip(1))
                {
                    int item = linha.Cell(1).GetValue<int>();
                    string descri = linha.Cell(2).GetValue<string>();
                    int quantidade = linha.Cell(3).TryGetValue(out int q) ? q : 0;
                    string marca = linha.Cell(4).GetValue<string>();
                    string estado = linha.Cell(5).GetValue<string>();
                    string local = linha.Cell(6).GetValue<string>();
                    string codigo = linha.Cell(7).GetValue<string>();

                    tabela.Rows.Add(item, descri, quantidade, marca, estado, local, codigo);
                }
            }

            return tabela;
        }

        // ------------------- MOSTRAR PLANILHA DISPONÍVEL -------------------
        public static DataTable LerEstoqueDisponivel() {
            DataTable tabela = new DataTable();
            tabela.Columns.Add("Item");
            tabela.Columns.Add("Descrição");
            tabela.Columns.Add("Quantidade");
            tabela.Columns.Add("Marca/Modelo");
            tabela.Columns.Add("Localização");

            if (!File.Exists(CaminhoDoEstoque))
                return tabela;

            using (var wb = new XLWorkbook(CaminhoDoEstoque))
            {
                var ws = wb.Worksheet(1);
                foreach (var linha in ws.RowsUsed().Skip(1))
                {
                    int item = linha.Cell(1).GetValue<int>();
                    string descri = linha.Cell(2).GetValue<string>();
                    int quantidade = linha.Cell(3).TryGetValue(out int q) ? q : 0;
                    string marca = linha.Cell(4).GetValue<string>();
                    string local = linha.Cell(6).GetValue<string>();

                    if (quantidade > 0)
                        tabela.Rows.Add(item, descri, quantidade, marca, local);
                }
            }

            return tabela;
        }

        // ------------------- GERENCIADOR DE EMPRÉSTIMOS -------------------
        public static void CriarPlanilhaLogSeNaoExistir() {
            if (!File.Exists(CaminhoPlanilhaLog))
            {
                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("Emprestimos");
                    ws.Cell("A1").Value = "Item";
                    ws.Cell("B1").Value = "Descrição da Ferramenta";
                    ws.Cell("C1").Value = "Cidade";
                    ws.Cell("D1").Value = "Marca/Modelo";
                    ws.Cell("E1").Value = "CPF";
                    ws.Cell("F1").Value = "Endereço";
                    ws.Cell("G1").Value = "Nome Da Pessoa";
                    ws.Cell("H1").Value = "ItemDoInventario";
                    ws.Row(1).Style.Font.Bold = true;
                    wb.SaveAs(CaminhoPlanilhaLog);
                }
            }
        }

        private static (IXLRow, string) EncontrarFerramentaNoEstoque(XLWorkbook wb, int itemNumero) {
            var wsEstoque = wb.Worksheet(1);
            foreach (var linha in wsEstoque.RowsUsed().Skip(1)) {
                if (linha.Cell(1).TryGetValue(out int itemNaPlanilha) && itemNaPlanilha == itemNumero)
                    return (linha, null);
            }
            return (null, "Erro: Ferramenta com este Item não encontrada no inventário.");
        }

        public static string RealizarEmprestimo(string nomePessoa, string cpf, string endereco, string cidade, string itemNumeroStr) {
            if (!int.TryParse(itemNumeroStr, out int itemNumero) || itemNumero <= 0)
                return "Erro: Item inválido.";
            if (string.IsNullOrWhiteSpace(nomePessoa) || string.IsNullOrWhiteSpace(cpf))
                return "Erro: Nome e CPF obrigatórios.";

            try
            {
                string descricao, marcaModelo;

                using (var wbEstoque = new XLWorkbook(CaminhoDoEstoque))
                {
                    var (linhaFerramenta, erro) = EncontrarFerramentaNoEstoque(wbEstoque, itemNumero);
                    if (linhaFerramenta == null) return erro;

                    linhaFerramenta.Cell(3).TryGetValue(out int quantidade);
                    if (quantidade <= 0) return "Erro: Ferramenta indisponível.";

                    linhaFerramenta.Cell(3).Value = quantidade - 1;
                    descricao = linhaFerramenta.Cell(2).GetValue<string>();
                    marcaModelo = linhaFerramenta.Cell(4).GetValue<string>();
                    wbEstoque.Save();
                }

                CriarPlanilhaLogSeNaoExistir();
                using (var wbLog = new XLWorkbook(CaminhoPlanilhaLog))
                {
                    var wsLog = wbLog.Worksheet(1);
                    int proximaLinha = (wsLog.LastRowUsed()?.RowNumber() ?? 0) + 1;
                    int itemNumLog = proximaLinha > 1 ? wsLog.LastRowUsed().Cell(1).GetValue<int>() + 1 : 1;

                    wsLog.Cell(proximaLinha, 1).Value = itemNumLog;
                    wsLog.Cell(proximaLinha, 2).Value = descricao;
                    wsLog.Cell(proximaLinha, 3).Value = cidade;
                    wsLog.Cell(proximaLinha, 4).Value = marcaModelo;
                    wsLog.Cell(proximaLinha, 5).Value = cpf;
                    wsLog.Cell(proximaLinha, 6).Value = endereco;
                    wsLog.Cell(proximaLinha, 7).Value = nomePessoa;
                    wsLog.Cell(proximaLinha, 8).Value = itemNumero;
                    wsLog.Columns().AdjustToContents();
                    wbLog.Save();
                }

                return $"Empréstimo de '{descricao}' registrado com sucesso!";
            }
            catch (Exception ex)
            {
                return $"Erro grave: {ex.Message}";
            }
        }

        public static string RealizarDevolucao(string itemLogNumeroStr, string nomePessoa, string cpf) {
            if (!int.TryParse(itemLogNumeroStr, out int itemLogNumero) || itemLogNumero <= 0)
                return "Erro: Item do Empréstimo inválido.";
            if (string.IsNullOrWhiteSpace(nomePessoa) || string.IsNullOrWhiteSpace(cpf))
                return "Erro: Nome e CPF obrigatórios.";

            if (!File.Exists(CaminhoPlanilhaLog))
                return "Erro: Planilha de empréstimos não existe.";

            try {
                int itemInventarioParaDevolver;

                using (var wbLog = new XLWorkbook(CaminhoPlanilhaLog))
                {
                    var wsLog = wbLog.Worksheet(1);
                    IXLRow linhaParaDeletar = null;

                    foreach (var linha in wsLog.RowsUsed().Skip(1))
                    {
                        if (linha.Cell(1).TryGetValue(out int itemAtual) && itemAtual == itemLogNumero)
                        {
                            linhaParaDeletar = linha;
                            break;
                        }
                    }

                    if (linhaParaDeletar == null) return "Erro: Item de empréstimo não encontrado.";

                    string cpfNaPlanilha = linhaParaDeletar.Cell(5).GetValue<string>();
                    string nomeNaPlanilha = linhaParaDeletar.Cell(7).GetValue<string>();

                    if (!cpfNaPlanilha.Equals(cpf, StringComparison.OrdinalIgnoreCase) ||
                        !nomeNaPlanilha.Equals(nomePessoa, StringComparison.OrdinalIgnoreCase))
                        return "Erro: Nome ou CPF não conferem com o registro.";

                    if (!linhaParaDeletar.Cell(8).TryGetValue(out itemInventarioParaDevolver))
                        return "Erro ao ler Item do Inventário.";

                    linhaParaDeletar.Delete();
                    wbLog.Save();
                }

                using (var wbEstoque = new XLWorkbook(CaminhoDoEstoque))
                {
                    var (linhaFerramenta, erro) = EncontrarFerramentaNoEstoque(wbEstoque, itemInventarioParaDevolver);
                    if (linhaFerramenta == null)
                        return $"Item devolvido, mas ferramenta de inventário ({itemInventarioParaDevolver}) não encontrada.";

                    linhaFerramenta.Cell(3).TryGetValue(out int quantidade);
                    linhaFerramenta.Cell(3).Value = quantidade + 1;
                    wbEstoque.Save();
                }

                return $"Item de empréstimo {itemLogNumero} devolvido com sucesso!";
            }
            catch (Exception ex)
            {
                return $"Erro grave na devolução: {ex.Message}";
            }
        }
    }
}
