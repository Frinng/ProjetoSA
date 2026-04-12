namespace ProjetoSA;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System; 
using System.Windows.Forms;

public class GeraPDF {
    
    public static void GerarPdfContratoFormatoJuridico(Animal.ContratoDTO contrato) {
        
        string nomeArquivo = $"Contrato_Formal_{contrato.id_contrato}.pdf";
        string caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), nomeArquivo);
        
        try
        {
            Document doc = new Document(PageSize.A4, 50, 50, 50, 50); 
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            BaseFont bfHelv = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            
            // CORREÇÃO AQUI: Usando float (14f) e as constantes do iTextSharp (Font.BOLD)
            Font fonteTitulo = new Font(bfHelv, 14f, Font.BOLD);
            Font fonteSubtitulo = new Font(bfHelv, 12f, Font.BOLD);
            Font fonteTexto = new Font(bfHelv, 11f, Font.NORMAL);
            Font fonteNegritoInline = new Font(bfHelv, 11f, Font.BOLD);

            Paragraph pTitulo = new Paragraph("CONTRATO DE PRESTAÇÃO DE SERVIÇOS EM GERAL", fonteTitulo);
            pTitulo.Alignment = Element.ALIGN_CENTER;
            pTitulo.SpacingAfter = 30f; 
            doc.Add(pTitulo);

            Paragraph pSecao1 = new Paragraph("IDENTIFICAÇÃO DAS PARTES CONTRATANTES", fonteSubtitulo);
            pSecao1.SpacingAfter = 15f;
            doc.Add(pSecao1);

            Phrase phContratante = new Phrase();
            phContratante.Add(new Chunk("CONTRATANTE: ", fonteNegritoInline));
            // Verifique se contrato.contratante existe no seu DTO
            phContratante.Add(new Chunk($"{contrato.contratante ?? "FAZENDA ALVORADA"}, ", fonteTexto)); 
            phContratante.Add(new Chunk("Inscrita no CNPJ sob nº XX.XXX.XXX/XXXX-XX, com sede na Zona Rural, s/n, Contagem/MG.", fonteTexto));
            
            Paragraph pContratante = new Paragraph(phContratante);
            pContratante.Alignment = Element.ALIGN_JUSTIFIED;
            pContratante.SpacingAfter = 10f;
            doc.Add(pContratante);

            Phrase phContratada = new Phrase();
            phContratada.Add(new Chunk("CONTRATADA: ", fonteNegritoInline));
            // CORREÇÃO AQUI: ToUpper() só funciona se 'contratado' não for nulo
            string nomeContratado = (contrato.contratado ?? "NÃO INFORMADO").ToUpper();
            phContratada.Add(new Chunk($"{nomeContratado}, ", fonteTexto)); 
            phContratada.Add(new Chunk("Pessoa jurídica de direito privado, inscrita no CNPJ sob nº XX.XXX.XXX/XXXX-XX, residente e domiciliada na Rua XXXXXXXXXXXX, Cep XXXXXXXX, Cidade XXXXXXX/XX.", fonteTexto));
            
            Paragraph pContratada = new Paragraph(phContratada);
            pContratada.Alignment = Element.ALIGN_JUSTIFIED;
            pContratada.SpacingAfter = 20f;
            doc.Add(pContratada);

            Paragraph pTransicao = new Paragraph("As partes acima identificadas têm, entre si, justo e acertado o presente Contrato de Prestação de Serviços, que se regerá pelas cláusulas seguintes e pelas condições descritas no presente.", fonteTexto);
            pTransicao.Alignment = Element.ALIGN_JUSTIFIED;
            pTransicao.SpacingAfter = 15f;
            doc.Add(pTransicao);

            doc.Add(new Paragraph("DO OBJETO", fonteSubtitulo));
            
            Phrase phClausula1 = new Phrase();
            phClausula1.Add(new Chunk("Cláusula 1ª. ", fonteNegritoInline));
            phClausula1.Add(new Chunk("É objeto do presente contrato a prestação de serviços, envolvendo as seguintes especificações descritas e acordadas entre as partes:", fonteTexto));
            
            Paragraph pClausula1 = new Paragraph(phClausula1);
            pClausula1.Alignment = Element.ALIGN_JUSTIFIED;
            pClausula1.IndentationLeft = 20f; 
            pClausula1.SpacingBefore = 10f;
            pClausula1.SpacingAfter = 10f;
            doc.Add(pClausula1);

            Paragraph pObjetoDetalhe = new Paragraph(contrato.termos_clausulas ?? "Sem descrição.", fonteTexto);
            pObjetoDetalhe.Alignment = Element.ALIGN_JUSTIFIED;
            pObjetoDetalhe.IndentationLeft = 40f; 
            pObjetoDetalhe.SpacingAfter = 20f;
            doc.Add(pObjetoDetalhe);

            doc.Add(new Paragraph("DO PAGAMENTO", fonteSubtitulo));

            Phrase phClausula2 = new Phrase();
            phClausula2.Add(new Chunk("Cláusula 2ª. ", fonteNegritoInline));
            string valorFormatado = contrato.valor_total.ToString("N2");
            string dataVencimento = contrato.data_vencimento.ToString("dd/MM/yyyy");
            
            phClausula2.Add(new Chunk($"O presente serviço será remunerado pela quantia global de ", fonteTexto));
            phClausula2.Add(new Chunk($"R$ {valorFormatado}, ", fonteNegritoInline)); 
            phClausula2.Add(new Chunk($"referente aos serviços efetivamente prestados, devendo o pagamento ser realizado impreterivelmente até a data de {dataVencimento}, através de transferência bancária ou boleto.", fonteTexto));
            
            Paragraph pClausula2 = new Paragraph(phClausula2);
            pClausula2.Alignment = Element.ALIGN_JUSTIFIED;
            pClausula2.IndentationLeft = 20f;
            pClausula2.SpacingBefore = 10f;
            pClausula2.SpacingAfter = 30f;
            doc.Add(pClausula2);

            string dataHoje = DateTime.Now.ToString("D"); 
            Paragraph pDataFinal = new Paragraph($"Contagem, {dataHoje}.", fonteTexto);
            pDataFinal.Alignment = Element.ALIGN_RIGHT;
            pDataFinal.SpacingAfter = 40f;
            doc.Add(pDataFinal);

            Paragraph pLinhasAssinatura = new Paragraph();
            pLinhasAssinatura.Alignment = Element.ALIGN_CENTER;
            pLinhasAssinatura.Add(new Chunk("_________________________________________      _________________________________________\n", fonteTexto));
            pLinhasAssinatura.Add(new Chunk("                 CONTRATANTE                                      CONTRATADA", fonteNegritoInline));
            doc.Add(pLinhasAssinatura);

            doc.Close();

            MessageBox.Show("PDF Profissional Gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(caminho) { UseShellExecute = true });
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao gerar PDF Formal: " + ex.Message);
        }
    }
}