namespace ProjetoSA;
using ClosedXML.Excel;
using System.Windows.Forms;

public class ValidadorLogin {

    private static string CaminhoPlanilhaLogin = Path.Combine(
        Application.StartupPath,
        "BancoDeDados.xlsx"
    );

    public static string FazerLogin(string usuario, string senha) {
        try {
            using (var wb = new XLWorkbook(CaminhoPlanilhaLogin)) {
                var ws = wb.Worksheet(1);
                int ultimaLinha = ws.LastRowUsed().RowNumber();

                for (int i = 2; i <= ultimaLinha; i++) {
                    string nomePlanilha = ws.Cell(i, 1).GetString();
                    string senhaPlanilha = ws.Cell(i, 2).GetString();

                    if (nomePlanilha == usuario && senhaPlanilha == senha) {
                        if (usuario.Equals("ADMIN", StringComparison.OrdinalIgnoreCase))
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
}