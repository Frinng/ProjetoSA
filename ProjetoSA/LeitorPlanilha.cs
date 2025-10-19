namespace ProjetoSA;
using ClosedXML.Excel;
using System.Windows.Forms;

public class LeitorPlanilha {

    private static string CaminhoPlanilhaLogin = Path.Combine(
        Application.StartupPath, // Pega a pasta onde o .exe está
        "BancoDeDados.xlsx"      // Procura o arquivo na MESMA pasta
    );

    public static string AdicionarUsuario(string nome, string senha) {
        try {
            using (var LivroDeTrabalho = new XLWorkbook(CaminhoPlanilhaLogin)) {
                
                var PlanilhaLogin = LivroDeTrabalho.Worksheet(1);
                var ultimaCelulaUsada = PlanilhaLogin.LastRowUsed();
                int ultimaLinha = 1;
                
                if (ultimaCelulaUsada != null)
                    ultimaLinha = ultimaCelulaUsada.RowNumber() + 1;
                    
                // Verifica se o usuário já existe (começando da linha 2, assumindo cabeçalho)
                // (O 'i < ultimaLinha' está correto se a planilha já tiver usuários)
                int linhaInicial = (ultimaCelulaUsada == null && PlanilhaLogin.Cell(1,1).IsEmpty()) ? 1 : 2;
                    
                for (int i = linhaInicial; i < ultimaLinha; i++) {
                    if (PlanilhaLogin.Cell(i, 1).GetString().Equals(nome, StringComparison.OrdinalIgnoreCase)) {
                        return "USUARIO_EXISTE"; // Retorna o status
                    }
                }

                // Se não existe, adiciona na próxima linha
                PlanilhaLogin.Cell(ultimaLinha, 1).Value = nome;
                PlanilhaLogin.Cell(ultimaLinha, 2).Value = senha;

                LivroDeTrabalho.Save();
                return "SUCESSO"; // Retorna o status
                
            }
        }
        catch (Exception ex) {
            
            MessageBox.Show("Erro grave ao acessar a planilha: " + ex.Message + 
                            "\nVerifique o caminho: " + CaminhoPlanilhaLogin, 
                "Erro de Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return "ERRO_ARQUIVO";
            
        }
    }
}