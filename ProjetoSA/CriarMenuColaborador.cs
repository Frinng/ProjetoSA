namespace ProjetoSA;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;

public partial class Formprinciapl {
    
    public void CriarMenuColaborador() {
        
        Menucolaborador = new Panel();
		Menucolaborador.Name = "MenuUsuario";
		Menucolaborador.Size = this.ClientSize;
		Menucolaborador.Location = new Point(0, 0);
		Menucolaborador.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		Menucolaborador.BackgroundImageLayout = ImageLayout.Stretch;
		Menucolaborador.Visible = false;


		Label labelMenuADM = new Label();
		labelMenuADM.Text = "Menu Colaborador";
		labelMenuADM.Location = new Point(420, 100);
		labelMenuADM.Font = new Font("Arial", 28, FontStyle.Bold);
		labelMenuADM.AutoSize = true;
		labelMenuADM.BackColor = Color.Transparent;
		labelMenuADM.ForeColor = Color.FromArgb(255, 189, 89);
		Menucolaborador.Controls.Add(labelMenuADM);


		Button BotaoVerlotes = new Button();
		BotaoVerlotes.Text = "Ver Lotes";
		BotaoVerlotes.Size = new Size(230, 40);
		BotaoVerlotes.Location = new Point(480, 180);
		BotaoVerlotes.Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoVerlotes.ForeColor = Color.FromArgb(255, 189, 89);
		BotaoVerlotes.FlatStyle = FlatStyle.Flat;
		BotaoVerlotes.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoVerlotes.BackColor = Color.White;
		BotaoVerlotes.FlatAppearance.BorderSize = 1;
		BotaoVerlotes.Click += (sender, e) => {
			Menucolaborador.Visible = false;
			Menuverlotes.Visible = true;

		};
		Menucolaborador.Controls.Add(BotaoVerlotes);


		Button BotaoConsultoria = new Button();
		BotaoConsultoria.Text = "Consultoria";
		BotaoConsultoria.Size = new Size(230, 40);
		BotaoConsultoria.Location = new Point(480, 230);
		BotaoConsultoria.Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoConsultoria.ForeColor = Color.FromArgb(255, 189, 89);
		BotaoConsultoria.FlatStyle = FlatStyle.Flat;
		BotaoConsultoria.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoConsultoria.BackColor = Color.White;
		BotaoConsultoria.FlatAppearance.BorderSize = 1;
		BotaoConsultoria.Click += (sender, e) => {
			Menucolaborador.Visible = false;
			Menuconsultoria.Visible = true;
		};
		Menucolaborador.Controls.Add(BotaoConsultoria);

		Button BotaoDA = new Button();
		BotaoDA.Text = "Desc Animais";
		BotaoDA.Size = new Size(230, 40);
		BotaoDA.Location = new Point(480, 280);
		BotaoDA.Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoDA.ForeColor = Color.FromArgb(255, 189, 89);
		BotaoDA.FlatStyle = FlatStyle.Flat;
		BotaoDA.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoDA.BackColor = Color.White;
		BotaoDA.FlatAppearance.BorderSize = 1;
		BotaoDA.Click += (sender, e) => {
			Menucolaborador.Visible = false;
			MenucDA.Visible = true;
		};
		Menucolaborador.Controls.Add(BotaoDA);

		Button BotaoFinancimento = new Button();
		BotaoFinancimento.Text = "Financeiro";
		BotaoFinancimento.Size = new Size(230, 40);
		BotaoFinancimento.Location = new Point(480, 330);
		BotaoFinancimento.Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoFinancimento.ForeColor = Color.FromArgb(255, 189, 89);
		BotaoFinancimento.FlatStyle = FlatStyle.Flat;
		BotaoFinancimento.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoFinancimento.BackColor = Color.White;
		BotaoFinancimento.FlatAppearance.BorderSize = 1;
		BotaoFinancimento.Click += (sender, e) => {
			Menucolaborador.Visible = false;
			Menufinanciamentos.Visible = true;
		};
		Menucolaborador.Controls.Add(BotaoFinancimento);

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
			Menucolaborador.Visible = false;
			PainelLogin.Visible = true;
		};
		Menucolaborador.Controls.Add(botaoVoltar);
        
    }
    
    public void MenuVerlotes() {
		Menuverlotes = new Panel();
		Menuverlotes.Name = "Temporario";
		Menuverlotes.Size = this.ClientSize;
		Menuverlotes.Location = new Point(0, 0);
		Menuverlotes.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		Menuverlotes.BackgroundImageLayout = ImageLayout.Stretch;
		Menuverlotes.Visible = false;

		
		Label labelMenulotes = new Label();
		labelMenulotes.Text = "Lotes";
		labelMenulotes.Location = new Point(540, 100);
		labelMenulotes.Font = new Font("Arial", 28, FontStyle.Bold);
		labelMenulotes.AutoSize = true;
		labelMenulotes.BackColor = Color.Transparent;
		labelMenulotes.ForeColor = Color.FromArgb(255, 189, 89);
		Menuverlotes.Controls.Add(labelMenulotes);

		Button BotaoLotesMedico = new Button();
		BotaoLotesMedico .Text = "Quarentena";
		BotaoLotesMedico .Size = new Size(230, 40);
		BotaoLotesMedico .Location = new Point(480, 180);
		BotaoLotesMedico .Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoLotesMedico .ForeColor = Color.FromArgb(255, 189, 89);
		BotaoLotesMedico .FlatStyle = FlatStyle.Flat;
		BotaoLotesMedico .FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoLotesMedico .BackColor = Color.White;
		BotaoLotesMedico .FlatAppearance.BorderSize = 1;
		BotaoLotesMedico .Click += (sender, e) => {
			Menuverlotes.Visible = false;
			MenuLotequarentena.Visible = true;

		};
		Menuverlotes.Controls.Add(BotaoLotesMedico );


		Button BotaoLotesEngorda = new Button();
		BotaoLotesEngorda.Text = "Engorda";
		BotaoLotesEngorda.Size = new Size(230, 40);
		BotaoLotesEngorda.Location = new Point(480, 230);
		BotaoLotesEngorda.Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoLotesEngorda.ForeColor = Color.FromArgb(255, 189, 89);
		BotaoLotesEngorda.FlatStyle = FlatStyle.Flat;
		BotaoLotesEngorda.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoLotesEngorda.BackColor = Color.White;
		BotaoLotesEngorda.FlatAppearance.BorderSize = 1;
		BotaoLotesEngorda.Click += (sender, e) => {
			Menuverlotes.Visible = false;
			MenuLoteengorda.Visible = true;
		};
		Menuverlotes.Controls.Add(BotaoLotesEngorda);

		Button BotaoLoteMaternidade = new Button();
		BotaoLoteMaternidade.Text = "Maternidade";
		BotaoLoteMaternidade.Size = new Size(230, 40);
		BotaoLoteMaternidade.Location = new Point(480, 280);
		BotaoLoteMaternidade.Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoLoteMaternidade.ForeColor = Color.FromArgb(255, 189, 89);
		BotaoLoteMaternidade.FlatStyle = FlatStyle.Flat;
		BotaoLoteMaternidade.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoLoteMaternidade.BackColor = Color.White;
		BotaoLoteMaternidade.FlatAppearance.BorderSize = 1;
		BotaoLoteMaternidade.Click += (sender, e) => {
			Menuverlotes.Visible = false;
			MenuLoteMaternida.Visible = true;
		};
		Menuverlotes.Controls.Add(BotaoLoteMaternidade);
		
		
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
			Menuverlotes.Visible = false;
			Menucolaborador.Visible = true;
		};
		Menuverlotes.Controls.Add(botaoVoltar);
	}
	
	public void MenuConsultoria() {
		Menuconsultoria = new Panel();
		Menuconsultoria.Name = "Temporario";
		Menuconsultoria.Size = this.ClientSize;
		Menuconsultoria.Location = new Point(0, 0);
		Menuconsultoria.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		Menuconsultoria.BackgroundImageLayout = ImageLayout.Stretch;
		Menuconsultoria.Visible = false;
		
		Label labelMenuADM = new Label();
		labelMenuADM.Text = "Consultoria";
		labelMenuADM.Location = new Point(470, 100);
		labelMenuADM.Font = new Font("Arial", 28, FontStyle.Bold);
		labelMenuADM.AutoSize = true;
		labelMenuADM.BackColor = Color.Transparent;
		labelMenuADM.ForeColor = Color.FromArgb(255, 189, 89);
		Menuconsultoria.Controls.Add(labelMenuADM);
		
		// 1. Quantidade para Abate
		Label lblAbate = new Label();
		lblAbate.Name = "lblAbate"; // Nomeado para facilitar acesso via código
		lblAbate.Text = "Animais prontos para abate: ...";
		lblAbate.Location = new Point(400, 180);
		lblAbate.Font = new Font("Arial", 14, FontStyle.Bold);
		lblAbate.ForeColor = Color.FromArgb(255, 189, 89);
		lblAbate.BackColor = Color.Transparent;
		lblAbate.AutoSize = true;
		Menuconsultoria.Controls.Add(lblAbate);

		// 2. Vacas Doentes
		Label lblDoentes = new Label();
		lblDoentes.Name = "lblDoentes";
		lblDoentes.Text = "Vacas em Quarentena (Doentes): ...";
		lblDoentes.Location = new Point(400, 220);
		lblDoentes.Font = new Font("Arial", 14, FontStyle.Bold);
		lblDoentes.ForeColor = Color.FromArgb(255, 189, 89);
		lblDoentes.BackColor = Color.Transparent;
		lblDoentes.AutoSize = true;
		Menuconsultoria.Controls.Add(lblDoentes);

		// 3. Preço da Arroba
		Label lblPrecoArroba = new Label();
		lblPrecoArroba.Name = "lblPrecoArroba";
		lblPrecoArroba.Text = "Preço da Arroba: ...";
		lblPrecoArroba.Location = new Point(400, 260);
		lblPrecoArroba.Font = new Font("Arial", 14, FontStyle.Bold);
		lblPrecoArroba.ForeColor = Color.FromArgb(255, 189, 89);
		lblPrecoArroba.BackColor = Color.Transparent;
		lblPrecoArroba.AutoSize = true;
		Menuconsultoria.Controls.Add(lblPrecoArroba);

		// 4. Taxas e Vacinas
		Label lblTaxas = new Label();
		lblTaxas.Name = "lblTaxas";
		lblTaxas.Text = "Custos: Carregando taxas...";
		lblTaxas.Location = new Point(400, 300);
		lblTaxas.Font = new Font("Arial", 14, FontStyle.Bold);
		lblTaxas.ForeColor = Color.FromArgb(255, 189, 89);
		lblTaxas.BackColor = Color.Transparent;
		lblTaxas.AutoSize = true;
		Menuconsultoria.Controls.Add(lblTaxas);

		// 5. Margem de Lucro
		Label lblMargem = new Label();
		lblMargem.Name = "lblMargem";
		lblMargem.Text = "Margem de Lucro Prevista: ...";
		lblMargem.Location = new Point(400, 340);
		lblMargem.Font = new Font("Arial", 14, FontStyle.Bold);
		lblMargem.ForeColor = Color.FromArgb(255, 189, 89);
		lblMargem.BackColor = Color.Transparent;
		lblMargem.AutoSize = true;
		Menuconsultoria.Controls.Add(lblMargem);
		
		// Dentro do seu Form
		ConsultoriaService servico = new ConsultoriaService();
		
		Menuconsultoria.VisibleChanged += async (s, e) => {
			if (Menuconsultoria.Visible) {
				await servico.AtualizarDadosConsultoria(new { 
					Abate = lblAbate, 
					Doentes = lblDoentes, 
					Preco = lblPrecoArroba, 
					Taxas = lblTaxas, 
					Margem = lblMargem 
				});
			}
		};
		
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
			Menuconsultoria.Visible = false;
			Menucolaborador.Visible = true;
		};
		Menuconsultoria.Controls.Add(botaoVoltar);
	}
	
	public async void MenuDA() {
		MenucDA = new Panel();
		MenucDA.Name = "Temporario";
		MenucDA.Size = this.ClientSize;
		MenucDA.Location = new Point(0, 0);
		MenucDA.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		MenucDA.BackgroundImageLayout = ImageLayout.Stretch;
		MenucDA.Visible = false;

		Label labelDA = new Label();
		labelDA.Text = "Descrição Animais";
		labelDA.Location = new Point(80, 100);
		labelDA.Font = new Font("Arial", 28, FontStyle.Bold);
		labelDA.AutoSize = true;
		labelDA.BackColor = Color.Transparent;
		labelDA.ForeColor = Color.FromArgb(255, 189, 89);
		MenucDA.Controls.Add(labelDA);
		
		FlowLayoutPanel flowDA = new FlowLayoutPanel();
		flowDA .Location = new Point(50, 150);
		flowDA .Size = new Size(1100, 400);
		flowDA .BackColor = Color.Transparent;
		flowDA .AutoScroll = true;
		flowDA .FlowDirection = FlowDirection.LeftToRight;
		flowDA .WrapContents = true;
		flowDA .Padding = new Padding(20, 20, 20, 50);
		MenucDA.Controls.Add(flowDA);
		try {
	        HttpClient client = new HttpClient();
		    string url = "http://localhost/projeto_sa/mostrar_todos_animais.php"; 
		    string response = await client.GetStringAsync(url);
		    var listaAnimais = JsonConvert.DeserializeObject<List<Animal.AnimalGeral>>(response);

		    if (listaAnimais != null) {
		        foreach (var animal in listaAnimais) {
		            Panel card = new Panel();
		            card.Size = new Size(260, 220); // Aumentado para caber os novos campos
		            card.BackColor = Color.FromArgb(255, 189, 89);
		            card.Margin = new Padding(15);
		            
		            // Label da Tag (Brinco)
		            Label lblTag = new Label {
		                Text = "TAG: " + (animal.tag ?? "S/N"),
		                Font = new Font("Segoe UI", 14, FontStyle.Bold),
		                ForeColor = Color.White,
		                Size = new Size(260, 30),
		                Location = new Point(0, 10),
		                TextAlign = ContentAlignment.MiddleCenter
		            };

		            // Informações Principais
		            Label lblInfo = new Label {
		                Text = $"Sexo: {animal.sexo}\nPeso: {animal.peso:N2} kg",
		                Font = new Font("Segoe UI", 10, FontStyle.Regular),
		                ForeColor = Color.White,
		                Size = new Size(260, 50),
		                Location = new Point(0, 50),
		                TextAlign = ContentAlignment.MiddleCenter
		            };

		            // Status (Engorda, Matriz, etc) - Criando uma string resumida
		            string statusTxt = "";
		            if (animal.eh_matriz == "SIM") statusTxt += "• MATRIZ ";
		            if (animal.em_engorda == "SIM") statusTxt += "• ENGORDA ";
		            if (animal.na_maternidade == "SIM") statusTxt += "• MATERNIDADE ";
		            if (animal.em_quarentena == "SIM") statusTxt += "• QUARENTENA ";

		            Label lblStatus = new Label {
		                Text = statusTxt != "" ? statusTxt : "• SEM STATUS",
		                Font = new Font("Segoe UI", 9, FontStyle.Italic),
		                ForeColor = animal.em_quarentena == "SIM" ? Color.White : Color.White,
		                Size = new Size(240, 80),
		                Location = new Point(10, 110),
		                TextAlign = ContentAlignment.TopCenter
		            };

		            card.Controls.Add(lblTag);
		            card.Controls.Add(lblInfo);
		            card.Controls.Add(lblStatus);
		            flowDA.Controls.Add(card);
		        }
		    }
	    }
	    catch (Exception ex) {
	        // Exibe erro se o servidor estiver desligado ou a URL errada
	        Label lblErro = new Label { 
	            Text = "Erro ao carregar dados: " + ex.Message, 
	            ForeColor = Color.Red, 
	            AutoSize = true, 
	            Location = new Point(20, 20) 
	        };
	        flowDA.Controls.Add(lblErro);
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
			MenucDA.Visible = false;
			Menucolaborador.Visible = true;
		};
		MenucDA.Controls.Add(botaoVoltar);
	
	}
	
	public async void MenuFinanciamentoa() {
		Menufinanciamentos = new Panel();
		Menufinanciamentos.Name = "Temporario";
		Menufinanciamentos.Size = this.ClientSize;
		Menufinanciamentos.Location = new Point(0, 0);
		Menufinanciamentos.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		Menufinanciamentos.BackgroundImageLayout = ImageLayout.Stretch;
		Menufinanciamentos.Visible = false;

		Label labelANM = new Label();
		labelANM.Text = "Financeiro";
		labelANM.Location = new Point(80, 100);
		labelANM.Font = new Font("Arial", 28, FontStyle.Bold);
		labelANM.AutoSize = true;
		labelANM.BackColor = Color.Transparent;
		labelANM.ForeColor = Color.FromArgb(255, 189, 89);
		Menufinanciamentos.Controls.Add(labelANM);

		FlowLayoutPanel flowFinanca = new FlowLayoutPanel();
		flowFinanca.Location = new Point(50, 150);
		flowFinanca.Size = new Size(1100, 400);
		flowFinanca.BackColor = Color.Transparent;
		flowFinanca.AutoScroll = true;
		flowFinanca.FlowDirection = FlowDirection.LeftToRight;
		flowFinanca.WrapContents = true;
		flowFinanca.Padding = new Padding(20, 20, 20, 50);
		Menufinanciamentos.Controls.Add(flowFinanca);
		try {
	        HttpClient client = new HttpClient();
		    string url = "http://localhost/projeto_sa/mostrar_produtos.php"; 
		    string response = await client.GetStringAsync(url);
		    var listaProdutos = JsonConvert.DeserializeObject<List<Animal.Produto>>(response);

		    if (listaProdutos != null) {
		        foreach (var prod in listaProdutos) {
			        Panel card = new Panel();
			        card.Size = new Size(220, 280); 
			        card.BackColor = Color.FromArgb(255, 189, 89);
			        card.Margin = new Padding(15);


			        PictureBox pbImagem = new PictureBox();
			        pbImagem.Size = new Size(200, 120);
			        pbImagem.Location = new Point(10, 10);
			        pbImagem.SizeMode = PictureBoxSizeMode.Zoom;
			        pbImagem.BackColor = Color.White;
			        pbImagem.ImageLocation = $@"..\..\..\Recursos\{prod.id_produto}.jpg";


			        Label lblNome = new Label();
			        lblNome.Text = prod.nome_produto.ToUpper();
			        lblNome.Font = new Font("Segoe UI", 12, FontStyle.Bold);
			        lblNome.ForeColor = Color.White;
			        lblNome.TextAlign = ContentAlignment.MiddleCenter;
			        lblNome.Size = new Size(200, 40);
			        lblNome.Location = new Point(10, 140);


			        Label lblInfo = new Label();
			        lblInfo.Text = $"Estoque: {prod.Qnt_Produto}\nVal: {prod.dt_validade:dd/MM/yyyy}";
			        lblInfo.Font = new Font("Segoe UI", 10, FontStyle.Regular);
			        lblInfo.ForeColor = Color.White;
			        lblInfo.TextAlign = ContentAlignment.MiddleCenter;
			        lblInfo.Size = new Size(200, 50);
			        lblInfo.Location = new Point(10, 185);


			        Button btnVer = new Button();
			        btnVer.Text = "DETALHES";
			        btnVer.Size = new Size(180, 30);
			        btnVer.Location = new Point(20, 240);
			        btnVer.FlatStyle = FlatStyle.Flat;
			        btnVer.ForeColor = Color.White;
			        btnVer.BackColor = Color.FromArgb(255, 189, 89);
			        
			        card.Controls.Add(pbImagem);
			        card.Controls.Add(lblNome);
			        card.Controls.Add(lblInfo);
			        card.Controls.Add(btnVer);


			        flowFinanca.Controls.Add(card);
		        }
		    }
	    }
	    catch (Exception ex) {
	        // Exibe erro se o servidor estiver desligado ou a URL errada
	        Label lblErro = new Label { 
	            Text = "Erro ao carregar dados: " + ex.Message, 
	            ForeColor = Color.Red, 
	            AutoSize = true, 
	            Location = new Point(20, 20) 
	        };
	        flowFinanca.Controls.Add(lblErro);
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
			Menufinanciamentos.Visible = false;
			Menucolaborador.Visible = true;
		};
		Menufinanciamentos.Controls.Add(botaoVoltar);
	}
	
	public async void MenuLoteMaternidad() {
		MenuLoteMaternida = new Panel();
		MenuLoteMaternida.Name = "Temporario";
		MenuLoteMaternida.Size = this.ClientSize;
		MenuLoteMaternida.Location = new Point(0, 0);
		MenuLoteMaternida.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao2.png");
		MenuLoteMaternida.BackgroundImageLayout = ImageLayout.Stretch;
		MenuLoteMaternida.Visible = false;
		
		Label labelANM = new Label();
		labelANM.Text = "Animais Na Maternidade";
		labelANM.Location = new Point(80, 100);
		labelANM.Font = new Font("Arial", 28, FontStyle.Bold);
		labelANM.AutoSize = true;
		labelANM.BackColor = Color.Transparent;
		labelANM.ForeColor = Color.FromArgb(255, 189, 89);
		MenuLoteMaternida.Controls.Add(labelANM);
		
		FlowLayoutPanel flowProdutos = new FlowLayoutPanel();
		flowProdutos.Location = new Point(50, 150);
		flowProdutos.Size = new Size(1100, 400);
		flowProdutos.BackColor = Color.Transparent;
		flowProdutos.AutoScroll = true;
		flowProdutos.FlowDirection = FlowDirection.LeftToRight;
		flowProdutos.WrapContents = true;
		flowProdutos.Padding = new Padding(20, 20, 20, 50);
		MenuLoteMaternida.Controls.Add(flowProdutos);

		try {
	        HttpClient client = new HttpClient();
	        string url = "http://localhost/projeto_sa/mostrar_maternidade.php"; 
	        string response = await client.GetStringAsync(url);
	        var listaAnimais = JsonConvert.DeserializeObject<List<Animal.AnimalMaternidade>>(response);

	        
	        if (listaAnimais != null) {
	            foreach (var animal in listaAnimais) {
		            Panel card = new Panel();
		            card.Size = new Size(250, 180);
		            card.BackColor = Color.FromArgb(255, 189, 89);
		            card.Margin = new Padding(15);
		            
		            Label lblTitulo = new Label();
		            lblTitulo.Text = animal.brinco_identificador ?? "S/ Identif.";
		            lblTitulo.Font = new Font("Arial", 16, FontStyle.Bold); 
		            lblTitulo.ForeColor = Color.White;
		            lblTitulo.AutoSize = false; 
		            lblTitulo.Size = new Size(250, 40); 
		            lblTitulo.Location = new Point(0, 50); 
		            lblTitulo.TextAlign = ContentAlignment.MiddleCenter; 
		            
		            Label lblDetalhe = new Label();
		            lblDetalhe.Text = "Raça: " + animal.raca + "\n" +
		                              "Idade: " + animal.idade_meses + " meses\n" +
		                              "Peso: " + animal.peso_kg.ToString("N2") + " kg";
		            lblDetalhe.Font = new Font("Arial", 11, FontStyle.Regular);
		            lblDetalhe.ForeColor = Color.White;
		            lblDetalhe.AutoSize = false;
		            lblDetalhe.Size = new Size(250, 80); 
		            lblDetalhe.Location = new Point(0, 90); 
		            lblDetalhe.TextAlign = ContentAlignment.TopCenter;

		            card.Controls.Add(lblTitulo);
		            card.Controls.Add(lblDetalhe);

		            flowProdutos.Controls.Add(card);
	            }
	        }
	    }
	    catch (Exception ex) {
	        // Exibe erro se o servidor estiver desligado ou a URL errada
	        Label lblErro = new Label { 
	            Text = "Erro ao carregar dados: " + ex.Message, 
	            ForeColor = Color.Red, 
	            AutoSize = true, 
	            Location = new Point(20, 20) 
	        };
	        flowProdutos.Controls.Add(lblErro);
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
			MenuLoteMaternida.Visible = false;
			Menuverlotes.Visible = true;
		};
		MenuLoteMaternida.Controls.Add(botaoVoltar);
	}
	
	public async void MenuLoteEngorda() {
		MenuLoteengorda = new Panel();
		MenuLoteengorda.Name = "Temporario";
		MenuLoteengorda.Size = this.ClientSize;
		MenuLoteengorda.Location = new Point(0, 0);
		MenuLoteengorda.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		MenuLoteengorda.BackgroundImageLayout = ImageLayout.Stretch;
		MenuLoteengorda.Visible = false;
		
		Label labelAPE = new Label();
		labelAPE.Text = "Animais Para Engorda";
		labelAPE.Location = new Point(80, 100);
		labelAPE.Font = new Font("Arial", 28, FontStyle.Bold);
		labelAPE.AutoSize = true;
		labelAPE.BackColor = Color.Transparent;
		labelAPE.ForeColor = Color.FromArgb(255, 189, 89);
		MenuLoteengorda.Controls.Add(labelAPE);
		
		FlowLayoutPanel flowAPE = new FlowLayoutPanel();
		flowAPE.Location = new Point(50, 150);
		flowAPE.Size = new Size(1100, 400);
		flowAPE.BackColor = Color.Transparent;
		flowAPE.AutoScroll = true;
		flowAPE.FlowDirection = FlowDirection.LeftToRight;
		flowAPE.WrapContents = true;
		flowAPE.Padding = new Padding(20, 20, 20, 50);
		MenuLoteengorda.Controls.Add(flowAPE);
		try {
		    HttpClient client = new HttpClient();
		    // URL para o novo arquivo PHP
		    string url = "http://localhost/projeto_sa/mostrar_engorda.php"; 
		    string response = await client.GetStringAsync(url);
		    var listaAnimais = JsonConvert.DeserializeObject<List<Animal.AnimalEngorda>>(response);

		    if (listaAnimais != null) {
		        foreach (var animal in listaAnimais) {
		            Panel card = new Panel();
		            card.Size = new Size(250, 180);
		            card.BackColor = Color.FromArgb(255, 189, 89);
		            card.Margin = new Padding(15);
		            
		            Label lblTitulo = new Label();
		            lblTitulo.Text = animal.brinco_identificador ?? "S/ Identif.";
		            lblTitulo.Font = new Font("Arial", 16, FontStyle.Bold); 
		            lblTitulo.ForeColor = Color.White;
		            lblTitulo.AutoSize = false; 
		            lblTitulo.Size = new Size(250, 40); 
		            lblTitulo.Location = new Point(0, 40); // Subi um pouco para caber mais info
		            lblTitulo.TextAlign = ContentAlignment.MiddleCenter; 
		            
		            Label lblDetalhe = new Label();
		            // Adaptado para mostrar Sexo em vez de Raça, conforme sua View
		            lblDetalhe.Text = "Sexo: " + animal.sexo_animal + "\n" +
		                              "Idade: " + animal.idade_meses + " meses\n" +
		                              "Peso: " + animal.peso_kg.ToString("N2") + " kg";
		            lblDetalhe.Font = new Font("Arial", 11, FontStyle.Regular);
		            lblDetalhe.ForeColor = Color.White;
		            lblDetalhe.AutoSize = false;
		            lblDetalhe.Size = new Size(250, 80); 
		            lblDetalhe.Location = new Point(0, 85); 
		            lblDetalhe.TextAlign = ContentAlignment.TopCenter;

		            card.Controls.Add(lblTitulo);
		            card.Controls.Add(lblDetalhe);

		            flowAPE.Controls.Add(card);
		        }
		    }
		}
		catch (Exception ex) {
		    MessageBox.Show("Erro ao carregar Engorda: " + ex.Message);
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
			MenuLoteengorda.Visible = false;
			Menuverlotes.Visible = true;
		};
		MenuLoteengorda.Controls.Add(botaoVoltar);
	}
	
	public async void MenuLoteQuarentena() {
		MenuLotequarentena = new Panel();
		MenuLotequarentena.Name = "Temporario";
		MenuLotequarentena.Size = this.ClientSize;
		MenuLotequarentena.Location = new Point(0, 0);
		MenuLotequarentena.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		MenuLotequarentena.BackgroundImageLayout = ImageLayout.Stretch;
		MenuLotequarentena.Visible = false;
		
		Label labelAPE = new Label();
		labelAPE.Text = "Animais Em Quarentena";
		labelAPE.Location = new Point(80, 100);
		labelAPE.Font = new Font("Arial", 28, FontStyle.Bold);
		labelAPE.AutoSize = true;
		labelAPE.BackColor = Color.Transparent;
		labelAPE.ForeColor = Color.FromArgb(255, 189, 89);
		MenuLotequarentena.Controls.Add(labelAPE);
		
		FlowLayoutPanel flowAMQ = new FlowLayoutPanel();
		flowAMQ.Location = new Point(50, 150);
		flowAMQ.Size = new Size(1100, 400);
		flowAMQ.BackColor = Color.Transparent;
		flowAMQ.AutoScroll = true;
		flowAMQ.FlowDirection = FlowDirection.LeftToRight;
		flowAMQ.WrapContents = true;
		flowAMQ.Padding = new Padding(20, 20, 20, 50);
		MenuLotequarentena.Controls.Add(flowAMQ);
		try {
			HttpClient client = new HttpClient();
			string url = "http://localhost/projeto_sa/mostrar_quarentena.php"; 
			string response = await client.GetStringAsync(url);
			var listaAnimais = JsonConvert.DeserializeObject < List < Animal.AnimalQuarentena>>(response);

			if (listaAnimais != null) {
				foreach (var animal in listaAnimais) {
					Panel card = new Panel();
					card.Size = new Size(250, 180);
					card.BackColor = Color.FromArgb(255, 189, 89);
					card.Margin = new Padding(15);
            
					Label lblTitulo = new Label();
					lblTitulo.Text = animal.brinco_identificador ?? "S/ Identif.";
					lblTitulo.Font = new Font("Arial", 16, FontStyle.Bold); 
					lblTitulo.ForeColor = Color.White;
					lblTitulo.AutoSize = false; 
					lblTitulo.Size = new Size(250, 40); 
					lblTitulo.Location = new Point(0, 40); 
					lblTitulo.TextAlign = ContentAlignment.MiddleCenter; 
            
					Label lblDetalhe = new Label();
					// Exibindo o Status da Quarentena
					lblDetalhe.Text = "Sexo: " + animal.sexo_animal + "\n" +
					                  "Idade: " + animal.idade_meses + " meses\n" +
					                  "Status: " + animal.status;
					lblDetalhe.Font = new Font("Arial", 11, FontStyle.Regular);
					lblDetalhe.ForeColor = Color.White;
					lblDetalhe.AutoSize = false;
					lblDetalhe.Size = new Size(250, 80); 
					lblDetalhe.Location = new Point(0, 85); 
					lblDetalhe.TextAlign = ContentAlignment.TopCenter;

					card.Controls.Add(lblTitulo);
					card.Controls.Add(lblDetalhe);

					flowAMQ.Controls.Add(card);
				}
			}
		}
		catch (Exception ex) {
			MessageBox.Show("Erro ao carregar Quarentena: " + ex.Message);
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
			MenuLotequarentena.Visible = false;
			Menuverlotes.Visible = true;
		};
		MenuLotequarentena.Controls.Add(botaoVoltar);
	}
	
	
}
