namespace ProjetoSA;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;

public partial class Formprinciapl {
    
    public void MenuFornecedor() {
		MENUFORNECEDOR = new Panel();
		MENUFORNECEDOR.Name = "Temporario";
		MENUFORNECEDOR.Size = this.ClientSize;
		MENUFORNECEDOR.Location = new Point(0, 0);
		MENUFORNECEDOR.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		MENUFORNECEDOR.BackgroundImageLayout = ImageLayout.Stretch;
		MENUFORNECEDOR.Visible = false;


		Label labelMenuADM = new Label();
		labelMenuADM.Text = "Menu Fornecedor";
		labelMenuADM.Location = new Point(430, 100);
		labelMenuADM.Font = new Font("Arial", 28, FontStyle.Bold);
		labelMenuADM.AutoSize = true;
		labelMenuADM.BackColor = Color.Transparent;
		labelMenuADM.ForeColor = Color.FromArgb(255, 189, 89);
		MENUFORNECEDOR.Controls.Add(labelMenuADM);


		Button BotaoEntrega = new Button();
		BotaoEntrega .Text = "Ver Entregas";
		BotaoEntrega .Size = new Size(230, 40);
		BotaoEntrega .Location = new Point(480, 180);
		BotaoEntrega .Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoEntrega .ForeColor = Color.FromArgb(255, 189, 89);
		BotaoEntrega .FlatStyle = FlatStyle.Flat;
		BotaoEntrega .FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoEntrega .BackColor = Color.White;
		BotaoEntrega .FlatAppearance.BorderSize = 1;
		BotaoEntrega .Click += (sender, e) => {

			MENUFORNECEDOR.Visible = false;
			Menuentrega.Visible = true;

		};
		MENUFORNECEDOR.Controls.Add(BotaoEntrega);


		Button Botaohisto = new Button();
		Botaohisto.Text = "Histórico";
		Botaohisto.Size = new Size(230, 40);
		Botaohisto.Location = new Point(480, 230);
		Botaohisto.Font = new Font("Arial", 20, FontStyle.Bold);
		Botaohisto.ForeColor = Color.FromArgb(255, 189, 89);
		Botaohisto.FlatStyle = FlatStyle.Flat;
		Botaohisto.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		Botaohisto.BackColor = Color.White;
		Botaohisto.FlatAppearance.BorderSize = 1;
		Botaohisto.Click += (sender, e) => {
			MENUFORNECEDOR.Visible = false;
			Menuhisto.Visible = true;
		};
		MENUFORNECEDOR.Controls.Add(Botaohisto);

		Button BotaoContrato = new Button();
		BotaoContrato.Text = "Contrato";
		BotaoContrato.Size = new Size(230, 40);
		BotaoContrato.Location = new Point(480, 280);
		BotaoContrato.Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoContrato.ForeColor = Color.FromArgb(255, 189, 89);
		BotaoContrato.FlatStyle = FlatStyle.Flat;
		BotaoContrato.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoContrato.BackColor = Color.White;
		BotaoContrato.FlatAppearance.BorderSize = 1;
		BotaoContrato.Click += (sender, e) => {
			MENUFORNECEDOR.Visible = false;
			Menucontrato.Visible = true;
		};
		MENUFORNECEDOR.Controls.Add(BotaoContrato);

		Button botaoVoltar = new Button();
		botaoVoltar.Text = "Voltar";
		botaoVoltar.Location = new Point(20, 20);
		botaoVoltar.Font = new Font("Arial", 12, FontStyle.Bold);
		botaoVoltar.AutoSize = true;
		botaoVoltar.FlatStyle = FlatStyle.Flat;
		botaoVoltar.FlatAppearance.BorderSize = 0;
		botaoVoltar.BackColor = Color.White;
		botaoVoltar.ForeColor = Color.FromArgb(255, 189, 89);
		botaoVoltar.Click += (sender, e) => {
			MENUFORNECEDOR.Visible = false;
			PainelLogin.Visible = true;
		};
		MENUFORNECEDOR.Controls.Add(botaoVoltar);
	}
    
	public void MenuEntrega() {
		Menuentrega = new Panel();
		Menuentrega.Name = "Temporario";
		Menuentrega.Size = this.ClientSize;
		Menuentrega.Location = new Point(0, 0);
		Menuentrega.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		Menuentrega.BackgroundImageLayout = ImageLayout.Stretch;
		Menuentrega.Visible = false;
		
		
		
		
		
		
		Button botaoVoltar = new Button();
		botaoVoltar.Text = "Voltar";
		botaoVoltar.Location = new Point(20, 20);
		botaoVoltar.Font = new Font("Arial", 12, FontStyle.Bold);
		botaoVoltar.AutoSize = true;
		botaoVoltar.FlatStyle = FlatStyle.Flat;
		botaoVoltar.FlatAppearance.BorderSize = 0;
		botaoVoltar.BackColor = Color.White;
		botaoVoltar.ForeColor = Color.FromArgb(255, 189, 89);
		botaoVoltar.Click += (sender, e) => {
			Menuentrega.Visible = false;
			MENUFORNECEDOR.Visible = true;
		};
		Menuentrega.Controls.Add(botaoVoltar);
	}
	
	public void Menuhistorico() {
    		Menuhisto = new Panel();
    		Menuhisto.Name = "Temporario";
    		Menuhisto.Size = this.ClientSize;
    		Menuhisto.Location = new Point(0, 0);
    		Menuhisto.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
    		Menuhisto.BackgroundImageLayout = ImageLayout.Stretch;
    		Menuhisto.Visible = false;
    		
    		
    		
    		
    		Button botaoVoltar = new Button();
    		botaoVoltar.Text = "Voltar";
    		botaoVoltar.Location = new Point(20, 20);
    		botaoVoltar.Font = new Font("Arial", 12, FontStyle.Bold);
    		botaoVoltar.AutoSize = true;
    		botaoVoltar.FlatStyle = FlatStyle.Flat;
    		botaoVoltar.FlatAppearance.BorderSize = 0;
    		botaoVoltar.BackColor = Color.White;
    		botaoVoltar.ForeColor = Color.FromArgb(255, 189, 89);
    		botaoVoltar.Click += (sender, e) => {
    			Menuhisto.Visible = false;
    			MENUFORNECEDOR.Visible = true;
    		};
    		Menuhisto.Controls.Add(botaoVoltar);
    	}
    
    public void MenuContrato() {
		Menucontrato = new Panel();
		Menucontrato.Name = "Temporario";
		Menucontrato.Size = this.ClientSize;
		Menucontrato.Location = new Point(0, 0);
		Menucontrato.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		Menucontrato.BackgroundImageLayout = ImageLayout.Stretch;
		Menucontrato.Visible = false;
		
		Label labelContratos = new Label();
		labelContratos .Text = "Contratos";
		labelContratos .Location = new Point(500, 100);
		labelContratos .Font = new Font("Arial", 28, FontStyle.Bold);
		labelContratos .AutoSize = true;
		labelContratos .BackColor = Color.Transparent;
		labelContratos .ForeColor = Color.FromArgb(255, 189, 89);
		Menucontrato.Controls.Add(labelContratos);

		Button BotaoVercontratos = new Button();
		BotaoVercontratos .Text = "Ver Contratos";
		BotaoVercontratos .Size = new Size(230, 40);
		BotaoVercontratos .Location = new Point(480, 180);
		BotaoVercontratos .Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoVercontratos .ForeColor = Color.FromArgb(255, 189, 89);
		BotaoVercontratos .FlatStyle = FlatStyle.Flat;
		BotaoVercontratos .FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoVercontratos .BackColor = Color.White;
		BotaoVercontratos .FlatAppearance.BorderSize = 1;
		BotaoVercontratos .Click += (sender, e) => {
			Menucontrato.Visible = false;
			Menuvercontratos.Visible = true;

		};
		Menucontrato.Controls.Add( BotaoVercontratos);

		
			

		Button BotaoNovosContratos = new Button();
		BotaoNovosContratos.Text = "Novos Contratos";
		BotaoNovosContratos.Size = new Size(230, 40);
		BotaoNovosContratos.Location = new Point(480, 230);
		BotaoNovosContratos.Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoNovosContratos.ForeColor = Color.FromArgb(255, 189, 89);
		BotaoNovosContratos.FlatStyle = FlatStyle.Flat;
		BotaoNovosContratos.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoNovosContratos.BackColor = Color.White;
		BotaoNovosContratos.FlatAppearance.BorderSize = 1;
		BotaoNovosContratos.Click += (sender, e) => {
			Menucontrato.Visible = false;
			Menunovoscontratos.Visible = true;
		};
		Menucontrato.Controls.Add(BotaoNovosContratos);
		
		
		Button botaoVoltar = new Button();
		botaoVoltar.Text = "Voltar";
		botaoVoltar.Location = new Point(20, 20);
		botaoVoltar.Font = new Font("Arial", 12, FontStyle.Bold);
		botaoVoltar.AutoSize = true;
		botaoVoltar.FlatStyle = FlatStyle.Flat;
		botaoVoltar.FlatAppearance.BorderSize = 0;
		botaoVoltar.BackColor = Color.White;
		botaoVoltar.ForeColor = Color.FromArgb(255, 189, 89);
		botaoVoltar.Click += (sender, e) => {
			Menucontrato.Visible = false;
			MENUFORNECEDOR.Visible = true;
		};
		Menucontrato.Controls.Add(botaoVoltar);
	}
	
    public async void MenuVerContratos() {
    		Menuvercontratos = new Panel();
    		Menuvercontratos.Name = "Temporario";
    		Menuvercontratos.Size = this.ClientSize;
    		Menuvercontratos.Location = new Point(0, 0);
    		Menuvercontratos.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
    		Menuvercontratos.BackgroundImageLayout = ImageLayout.Stretch;
    		Menuvercontratos.Visible = false;
    		
    		Label labelAPE = new Label();
    		labelAPE.Text = "Contratos";
    		labelAPE.Location = new Point(80, 100);
    		labelAPE.Font = new Font("Arial", 28, FontStyle.Bold);
    		labelAPE.AutoSize = true;
    		labelAPE.BackColor = Color.Transparent;
    		labelAPE.ForeColor = Color.FromArgb(255, 189, 89);
    		Menuvercontratos.Controls.Add(labelAPE);
    		
    		FlowLayoutPanel flowVerContratos = new FlowLayoutPanel();
    		flowVerContratos.Location = new Point(50, 150);
    		flowVerContratos.Size = new Size(1100, 400);
    		flowVerContratos.BackColor = Color.Transparent;
    		flowVerContratos.AutoScroll = true;
    		flowVerContratos.FlowDirection = FlowDirection.LeftToRight;
    		flowVerContratos.WrapContents = true;
    		flowVerContratos.Padding = new Padding(20, 20, 20, 50);
    		Menuvercontratos.Controls.Add(flowVerContratos);
    		try {
    			HttpClient client = new HttpClient();
    	        // Lembre-se de criar esse PHP para retornar os dados da sua tabela 'contrato'
    	        string url = "http://localhost/projeto_sa/listar_contratos.php"; 
    	        string response = await client.GetStringAsync(url);
    	        
    	        // Aqui usamos a classe que representa sua tabela SQL 'contrato'
    	        var listaContratos = JsonConvert.DeserializeObject<List<Animal.ContratoDTO>>(response);
    
    	        if (listaContratos != null) {
    	            foreach (var contrato in listaContratos) {
    	                // Criando o Card (Painel)
    	                Panel card = new Panel();
    	                card.Size = new Size(300, 220);
    	                card.BackColor = Color.White; // Card branco com borda amarela fica elegante
    	                card.BorderStyle = BorderStyle.FixedSingle;
    	                card.Margin = new Padding(15);
    
    	                // Cabeçalho do Card (ID do Contrato)
    	                Label lblId = new Label();
    	                lblId.Text = "Contrato #" + contrato.id_contrato;
    	                lblId.Font = new Font("Arial", 14, FontStyle.Bold);
    	                lblId.ForeColor = Color.FromArgb(255, 189, 89);
    	                lblId.Size = new Size(300, 40);
    	                lblId.TextAlign = ContentAlignment.MiddleCenter;
    	                lblId.Location = new Point(0, 10);
    
    	                // Detalhes do Contrato
    	                Label lblCorpo = new Label();
    	                // Formatando Moeda e Data
    	                lblCorpo.Text = $"Valor: R$ {contrato.valor_total:N2}\n" +
    	                               $"Vence em: {contrato.data_vencimento:dd/MM/yyyy}\n" +
    	                               $"Status: {contrato.status_contrato}";
    	                lblCorpo.Font = new Font("Arial", 11, FontStyle.Regular);
    	                lblCorpo.Size = new Size(300, 80);
    	                lblCorpo.Location = new Point(0, 60);
    	                lblCorpo.TextAlign = ContentAlignment.MiddleCenter;
    
    	                // Botão "Ver Termos" dentro do Card
    	                Button btnVerTermos = new Button();
    	                btnVerTermos.Text = "VER CLAÚSULAS";
    	                btnVerTermos.Size = new Size(150, 30);
    	                btnVerTermos.Location = new Point(75, 130);
    	                btnVerTermos.FlatStyle = FlatStyle.Flat;
    	                btnVerTermos.BackColor = Color.FromArgb(255, 189, 89);
    	                btnVerTermos.ForeColor = Color.White;
    	                btnVerTermos.Click += (s, e) => {
    	                    MessageBox.Show("Termos do Contrato:\n\n" + contrato.termos_clausulas);
    	                };
    	                
    	                Button btnPdf = new Button();
    	                btnPdf.Text = "EXPORTAR PDF";
    	                btnPdf.Size = new Size(150, 20);
    	                btnPdf.Location = new Point(75, 165); // Abaixo do botão de ver termos
    	                btnPdf.FlatStyle = FlatStyle.Flat;
    	                btnPdf.BackColor = Color.FromArgb(255, 189, 89);
    	                btnPdf.ForeColor = Color.White;
    
    	                btnPdf.Click += (s, e) => {
    		                GeraPDF.GerarPdfContratoFormatoJuridico(contrato);
    	                };
    
    	                card.Controls.Add(btnPdf);
    	                card.Controls.Add(lblId);
    	                card.Controls.Add(lblCorpo);
    	                card.Controls.Add(btnVerTermos);
    
    	                flowVerContratos.Controls.Add(card);
    	            }
    	        }
    		}
    		catch (Exception ex) {
    			MessageBox.Show("Erro ao carregar contrato: " + ex.Message);
    		}
    		
    		Button botaoVoltar = new Button();
    		botaoVoltar.Text = "Voltar";
    		botaoVoltar.Location = new Point(20, 20);
    		botaoVoltar.Font = new Font("Arial", 12, FontStyle.Bold);
    		botaoVoltar.AutoSize = true;
    		botaoVoltar.FlatStyle = FlatStyle.Flat;
    		botaoVoltar.FlatAppearance.BorderSize = 0;
    		botaoVoltar.BackColor = Color.White;
    		botaoVoltar.ForeColor = Color.FromArgb(255, 189, 89);
    		botaoVoltar.Click += (sender, e) => {
    			Menuvercontratos.Visible = false;
    			Menucontrato.Visible = true;
    		};
    		Menuvercontratos.Controls.Add(botaoVoltar);
    	}
    
	public void MenuNovosContratos() {
    		Menunovoscontratos = new Panel();
    		Menunovoscontratos.Name = "Temporario";
    		Menunovoscontratos.Size = this.ClientSize;
    		Menunovoscontratos.Location = new Point(0, 0);
    		Menunovoscontratos.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
    		Menunovoscontratos.BackgroundImageLayout = ImageLayout.Stretch;
    		Menunovoscontratos.Visible = false;
    		
    		
    		
    		Button botaoVoltar = new Button();
    		botaoVoltar.Text = "Voltar";
    		botaoVoltar.Location = new Point(20, 20);
    		botaoVoltar.Font = new Font("Arial", 12, FontStyle.Bold);
    		botaoVoltar.AutoSize = true;
    		botaoVoltar.FlatStyle = FlatStyle.Flat;
    		botaoVoltar.FlatAppearance.BorderSize = 0;
    		botaoVoltar.BackColor = Color.White;
    		botaoVoltar.ForeColor = Color.FromArgb(255, 189, 89);
    		botaoVoltar.Click += (sender, e) => {
    			Menunovoscontratos.Visible = false;
    			Menucontrato.Visible = true;
    		};
    		Menunovoscontratos.Controls.Add(botaoVoltar);
    	}
    
    
}