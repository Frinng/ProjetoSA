// Nome do arquivo: GerenciadorEmprestimos.cs
using ClosedXML.Excel;
using System;
using System.Data; // Necessário para DataTable
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoSA {
    public static class GerenciadorEmprestimos {
        // Caminho para a planilha de LOG (onde os empréstimos são gravados)
        private static string CaminhoPlanilhaLog = Path.Combine(
            Application.StartupPath,
            "PLanilhaSimuladoEstoque.xlsx"
        );

        // Caminho para a planilha de INVENTÁRIO (onde as ferramentas estão)
        private static string CaminhoPlanilhaEstoque = Path.Combine(
            Application.StartupPath,
            "PLanilhaSimuladoEstoque.xlsx"
        );

        // Aba da planilha de inventário que contém as ferramentas (Aba 2)
        private const int AbaDeFerramentas = 2;

        // --- FUNÇÃO LER O LOG (CORRIGIDA) ---
        public static DataTable LerPlanilhaLog()
        {
            DataTable tabelaLog = new DataTable();
            CriarPlanilhaLogSeNaoExistir(); // Garante que o arquivo exista

            using (var wb = new XLWorkbook(CaminhoPlanilhaLog))
            {
                var ws = wb.Worksheet(3);

                // Verifica se a planilha está vazia (sem cabeçalho)
                if (!ws.RowsUsed().Any())
                {
                    // Tenta ler o cabeçalho do arquivo existente, se não, retorna tabela vazia
                    if (File.Exists(CaminhoPlanilhaLog)) {
                         using(var wbCheck = new XLWorkbook(CaminhoPlanilhaLog)) {
                            var wsCheck = wbCheck.Worksheet(1);
                            if(wsCheck.RowsUsed().Any()) {
                                foreach (var cell in wsCheck.Row(1).CellsUsed()) {
                                    tabelaLog.Columns.Add(cell.GetValue<string>());
                                }
                            }
                         }
                    }
                    return tabelaLog;
                }

                // Adiciona colunas baseado no cabeçalho
                var cabecalho = ws.Row(1);
                foreach (var cell in cabecalho.CellsUsed())
                {
                    tabelaLog.Columns.Add(cell.GetValue<string>());
                }

                // Verifica se só existe o cabeçalho
                if (ws.RowsUsed().Count() <= 1)
                {
                    return tabelaLog; // Retorna a tabela só com as colunas
                }

                // --- CORREÇÃO AQUI ---
                // Adiciona as linhas de dados
                foreach (var row in ws.RowsUsed().Skip(1)) // Pula o cabeçalho
                {
                    // Cria um array de objetos para a nova linha
                    var rowData = new object[tabelaLog.Columns.Count];
                    
                    // Preenche o array manualmente, célula por célula
                    for (int i = 0; i < tabelaLog.Columns.Count; i++)
                    {
                        // O índice da célula é i + 1 (porque ClosedXML é 1-based)
                        // Usamos GetValue<string>() para garantir que tudo seja lido como texto
                        rowData[i] = row.Cell(i + 1).GetValue<string>(); 
                    }
                    
                    // Adicione o array à tabela
                    tabelaLog.Rows.Add(rowData);
                }
                // --- FIM DA CORREÇÃO ---
            }
            return tabelaLog;
        }

        // Função para criar a planilha de LOG se não existir
        private static void CriarPlanilhaLogSeNaoExistir()
        {
            if (!File.Exists(CaminhoPlanilhaLog))
            {
                using (var wb = new XLWorkbook()) {
                    var ws = wb.Worksheets.Add("Emprestimos");
                    ws.Cell("A1").Value = "Item"; // Item do Log (1, 2, 3...)
                    ws.Cell("B1").Value = "Descrição da Ferramenta";
                    ws.Cell("C1").Value = "Cidade";
                    ws.Cell("D1").Value = "Marca/Modelo";
                    ws.Cell("E1").Value = "CPF";
                    ws.Cell("F1").Value = "Endereço";
                    ws.Cell("G1").Value = "Nome Da Pessoa";
                    ws.Cell("H1").Value = "ItemDoInventario"; // Item da Planilha (ex: 2 para Martelo)
                    ws.Row(1).Style.Font.Bold = true;
                    wb.SaveAs(CaminhoPlanilhaLog);
                }
            }
        }
        
        // Encontra uma ferramenta no inventário (Aba 2) pelo NÚMERO DO ITEM (Coluna A)
        private static (IXLRow, string) EncontrarFerramentaNoEstoque(XLWorkbook wb, int itemNumero)
        {
            var wsEstoque = wb.Worksheet(AbaDeFerramentas);
            foreach (var linha in wsEstoque.RowsUsed().Skip(1))
            {
                if (linha.Cell(1).TryGetValue(out int itemNaPlanilha) && itemNaPlanilha == itemNumero)
                {
                    return (linha, null);
                }
            }
            return (null, "Erro: Ferramenta com este Item não encontrada no inventário.");
        }
        
        // --- FUNÇÃO REALIZAR EMPRÉSTIMO (Sem mudanças) ---
        public static string RealizarEmprestimo(string nomePessoa, string cpf, string endereco, string cidade, string itemNumeroStr)
        {
            if (!int.TryParse(itemNumeroStr, out int itemNumero) || itemNumero <= 0)
            {
                 return "Erro: O 'Item da Ferramenta' deve ser um número válido.";
            }
            if (string.IsNullOrWhiteSpace(nomePessoa) || string.IsNullOrWhiteSpace(cpf))
            {
                return "Erro: Nome e CPF são obrigatórios.";
            }

            try
            {
                string descricao, marcaModelo;
                using (var wbEstoque = new XLWorkbook(CaminhoPlanilhaEstoque))
                {
                    var (linhaFerramenta, erro) = EncontrarFerramentaNoEstoque(wbEstoque, itemNumero); 
                    if (linhaFerramenta == null) return erro;

                    linhaFerramenta.Cell(3).TryGetValue(out int quantidade);
                    if (quantidade <= 0)
                    {
                        return "Erro: Ferramenta indisponível (Quantidade 0).";
                    }

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
                    int itemNumLog = 1;
                    if (proximaLinha > 1) {
                         // Corrigido para ler a última linha real
                         if (wsLog.LastRowUsed() != null)
                         {
                            wsLog.LastRowUsed().Cell(1).TryGetValue(out itemNumLog);
                            itemNumLog++;
                         }
                    }

                    wsLog.Cell(proximaLinha, 1).Value = itemNumLog; // Item do Log
                    wsLog.Cell(proximaLinha, 2).Value = descricao;
                    wsLog.Cell(proximaLinha, 3).Value = cidade;
                    wsLog.Cell(proximaLinha, 4).Value = marcaModelo;
                    wsLog.Cell(proximaLinha, 5).Value = cpf;
                    wsLog.Cell(proximaLinha, 6).Value = endereco;
                    wsLog.Cell(proximaLinha, 7).Value = nomePessoa;
                    wsLog.Cell(proximaLinha, 8).Value = itemNumero; // Salva o 'Item do Inventário'
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

        // --- FUNÇÃO REALIZAR DEVOLUÇÃO (ATUALIZADA) ---
        public static string RealizarDevolucao(string itemLogNumeroStr, string nomePessoa, string cpf)
        {
            // Validação dos campos de entrada
            if (!int.TryParse(itemLogNumeroStr, out int itemLogNumero) || itemLogNumero <= 0)
            {
                return "Erro: O 'Item do Empréstimo' deve ser um número válido.";
            }
            if (string.IsNullOrWhiteSpace(nomePessoa) || string.IsNullOrWhiteSpace(cpf))
            {
                return "Erro: Nome e CPF são obrigatórios para validar a devolução.";
            }

            if (!File.Exists(CaminhoPlanilhaLog))
            {
                return "Erro: Planilha de empréstimos não existe.";
            }

            try
            {
                int itemInventarioParaDevolver; 

                // --- ETAPA 1: Remover do Log (PlanilhaEmprestimos.xlsx) ---
                using (var wbLog = new XLWorkbook(CaminhoPlanilhaLog))
                {
                    var wsLog = wbLog.Worksheet(1);
                    IXLRow linhaParaDeletar = null;

                    // Procura o Item do Log na Coluna A
                    foreach (var linha in wsLog.RowsUsed().Skip(1))
                    {
                        if (linha.Cell(1).TryGetValue(out int itemAtual) && itemAtual == itemLogNumero)
                        {
                            linhaParaDeletar = linha;
                            break;
                        }
                    }

                    if (linhaParaDeletar == null)
                    {
                        return "Erro: Item de empréstimo não encontrado.";
                    }

                    // --- VALIDAÇÃO DE CPF E NOME ---
                    string cpfNaPlanilha = linhaParaDeletar.Cell(5).GetValue<string>(); // Coluna E
                    string nomeNaPlanilha = linhaParaDeletar.Cell(7).GetValue<string>(); // Coluna G

                    if (!cpfNaPlanilha.Equals(cpf, StringComparison.OrdinalIgnoreCase) || 
                        !nomeNaPlanilha.Equals(nomePessoa, StringComparison.OrdinalIgnoreCase))
                    {
                        return "Erro: Nome ou CPF não conferem com o registro de empréstimo.";
                    }
                    // --- FIM DA VALIDAÇÃO ---

                    if (!linhaParaDeletar.Cell(8).TryGetValue(out itemInventarioParaDevolver))
                    {
                         return $"Item {itemLogNumero} validado, mas o 'Item de Inventário' associado (Coluna H) não foi lido. A devolução ao estoque falhou.";
                    }
                    
                    linhaParaDeletar.Delete();
                    wbLog.Save();
                }

                // --- ETAPA 2: Adicionar de volta ao Inventário (PLanilhaSimuladoEstoque.xlsx) ---
                using (var wbEstoque = new XLWorkbook(CaminhoPlanilhaEstoque))
                {
                    var (linhaFerramenta, erro) = EncontrarFerramentaNoEstoque(wbEstoque, itemInventarioParaDevolver);
                    if (linhaFerramenta == null)
                    {
                        return $"Item {itemLogNumero} removido do log, mas a ferramenta de inventário (Item {itemInventarioParaDevolver}) não foi encontrada. A devolução ao estoque falhou.";
                    }

                    linhaFerramenta.Cell(3).TryGetValue(out int quantidade);
                    linhaFerramenta.Cell(3).Value = quantidade + 1;
                    wbEstoque.Save();
                }

                return $"Item de empréstimo {itemLogNumero} devolvido com sucesso! Estoque (Item {itemInventarioParaDevolver}) atualizado.";
            }
            catch (Exception ex)
            {
                return $"Erro grave na devolução: {ex.Message}";
            }
        }
    }
}