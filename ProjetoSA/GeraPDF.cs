namespace ProjetoSA;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System; // Necessário para Exception e Environment
using System.Windows.Forms; // Necessário para MessageBox

public class GeraPDF {
    
    // Transformei em static para você conseguir chamar sem dar 'new'
    public static void GerarPdfContrato(Animal.ContratoDTO contrato) {
        string caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"Contrato_{contrato.id_contrato}.pdf");
        
        try
        {
            // Usando o nome completo para evitar conflitos com System.Drawing
            iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            var fonteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
            doc.Add(new Paragraph("INSTRUMENTO PARTICULAR DE CONTRATO", fonteTitulo));
            doc.Add(new Paragraph($"ID do Contrato: {contrato.id_contrato}"));
            doc.Add(new Paragraph("\n"));

            var fonteCorpo = FontFactory.GetFont(FontFactory.HELVETICA, 12);
            doc.Add(new Paragraph($"Valor Total: R$ {contrato.valor_total:N2}", fonteCorpo));
            doc.Add(new Paragraph($"Data de Vencimento: {contrato.data_vencimento:dd/MM/yyyy}", fonteCorpo));
            doc.Add(new Paragraph($"Status Atual: {contrato.status_contrato}", fonteCorpo));
            doc.Add(new Paragraph("\n----------------------------------------------------\n"));
            doc.Add(new Paragraph("CLÁUSULAS E TERMOS:", fonteTitulo));
            doc.Add(new Paragraph(contrato.termos_clausulas, fonteCorpo));

            doc.Close();

            MessageBox.Show("PDF Gerado em Documentos!", "Sucesso");
        
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(caminho) { UseShellExecute = true });
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao gerar PDF: " + ex.Message);
        }
    }
    
}