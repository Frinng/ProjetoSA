using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json; // Certifique-se de ter o pacote Json.NET instalado

public class ConsultoriaService
{
    public async Task<bool> AtualizarDadosConsultoria(dynamic labels)
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {
                // URL do seu PHP
                string response = await client.GetStringAsync("http://localhost/projeto_sa/consultoria.php");
                var dados = JsonConvert.DeserializeObject<dynamic>(response);

                // labels aqui seriam as labels do seu form passadas por referência
                labels.Abate.Text = $"Animais prontos para abate: {dados.prontos_abate}";
                labels.Doentes.Text = $"Vacas em Quarentena: {dados.vacas_doentes}";
                labels.Preco.Text = $"Preço da Arroba: R$ {dados.preco_arroba}";
                labels.Taxas.Text = $"Custos: Vacina R$ {dados.taxa_vacina} | Abate R$ {dados.taxa_abate}";
                labels.Margem.Text = $"Margem de Lucro: {dados.margem_lucro}%";
                
                return true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
            return false;
        }
    }
}