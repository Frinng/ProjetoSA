namespace ProjetoSA;

public partial class Formprinciapl {
    
    public void MenuCliente() {
		menucliente = new Panel();
		menucliente.Name = "Temporario";
		menucliente.Size = this.ClientSize;
		menucliente.Location = new Point(0, 0);
		menucliente.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		menucliente.BackgroundImageLayout = ImageLayout.Stretch;
		menucliente.Visible = false;


		Label labelMenuCliente = new Label();
		labelMenuCliente.Text = "Menu Cliente";
		labelMenuCliente.Location = new Point(470, 100);
		labelMenuCliente.Font = new Font("Arial", 28, FontStyle.Bold);
		labelMenuCliente.AutoSize = true;
		labelMenuCliente.BackColor = Color.Transparent;
		labelMenuCliente.ForeColor = Color.FromArgb(255, 189, 89);
		menucliente.Controls.Add(labelMenuCliente);


		Button BotaoCaracteristicas = new Button();
		BotaoCaracteristicas.Text = "Caracteristicas";
		BotaoCaracteristicas.Size = new Size(230, 40);
		BotaoCaracteristicas.Location = new Point(480, 180);
		BotaoCaracteristicas.Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoCaracteristicas.ForeColor = Color.FromArgb(255, 189, 89);
		BotaoCaracteristicas.FlatStyle = FlatStyle.Flat;
		BotaoCaracteristicas.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoCaracteristicas.BackColor = Color.White;
		BotaoCaracteristicas.FlatAppearance.BorderSize = 1;
		BotaoCaracteristicas.Click += (sender, e) => {

			menucliente.Visible = false;
			Menucaract.Visible = true;

		};
		menucliente.Controls.Add(BotaoCaracteristicas);


		Button BotaoInfoLotes = new Button();
		BotaoInfoLotes.Text = "Info Lotes";
		BotaoInfoLotes.Size = new Size(230, 40);
		BotaoInfoLotes.Location = new Point(480, 230);
		BotaoInfoLotes.Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoInfoLotes.ForeColor = Color.FromArgb(255, 189, 89);
		BotaoInfoLotes.FlatStyle = FlatStyle.Flat;
		BotaoInfoLotes.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoInfoLotes.BackColor = Color.White;
		BotaoInfoLotes.FlatAppearance.BorderSize = 1;
		BotaoInfoLotes.Click += (sender, e) => {
			menucliente.Visible = false;
			Menuinfolotes.Visible = true;
		};
		menucliente.Controls.Add(BotaoInfoLotes);

		Button BotaoCarrinho = new Button();
		BotaoCarrinho.Text = "Carrinho";
		BotaoCarrinho.Size = new Size(230, 40);
		BotaoCarrinho.Location = new Point(480, 280);
		BotaoCarrinho.Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoCarrinho.ForeColor = Color.FromArgb(255, 189, 89);
		BotaoCarrinho.FlatStyle = FlatStyle.Flat;
		BotaoCarrinho.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoCarrinho.BackColor = Color.White;
		BotaoCarrinho.FlatAppearance.BorderSize = 1;
		BotaoCarrinho.Click += (sender, e) => {
			menucliente.Visible = false;
			Menucarrinho.Visible = true;
		};
		menucliente.Controls.Add(BotaoCarrinho);

		Button BotaoRastreio = new Button();
		BotaoRastreio.Text = "Rastreio";
		BotaoRastreio.Size = new Size(230, 40);
		BotaoRastreio.Location = new Point(480, 330);
		BotaoRastreio.Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoRastreio.ForeColor = Color.FromArgb(255, 189, 89);
		BotaoRastreio.FlatStyle = FlatStyle.Flat;
		BotaoRastreio.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoRastreio.BackColor = Color.White;
		BotaoRastreio.FlatAppearance.BorderSize = 1;
		BotaoRastreio.Click += (sender, e) => {
			menucliente.Visible = false;
			Menurastreio.Visible = true;
		};
		menucliente.Controls.Add(BotaoRastreio);

		//Botao para voltar
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
			menucliente.Visible = false;
			MENUFORNECEDOR.Visible = true;
		};
		menucliente.Controls.Add(botaoVoltar);
	}
    
    public void MenuCaracteristicas() {
		Menucaract = new Panel();
		Menucaract.Name = "Temporario";
		Menucaract.Size = this.ClientSize;
		Menucaract.Location = new Point(0, 0);
		Menucaract.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		Menucaract.BackgroundImageLayout = ImageLayout.Stretch;
		Menucaract.Visible = false;
		
		
		
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
			Menucaract.Visible = false;
			menucliente.Visible = true;
		};
		Menucaract.Controls.Add(botaoVoltar);
		
	}

    public void MenuInfoLotes() {
		Menuinfolotes = new Panel();
		Menuinfolotes.Name = "Temporario";
		Menuinfolotes.Size = this.ClientSize;
		Menuinfolotes.Location = new Point(0, 0);
		Menuinfolotes.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		Menuinfolotes.BackgroundImageLayout = ImageLayout.Stretch;
		Menuinfolotes.Visible = false;
		
		
		
		
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
			Menuinfolotes.Visible = false;
			menucliente.Visible = true;
		};
		Menuinfolotes.Controls.Add(botaoVoltar);
	}
	
    public void MenuCarrinho() {
		Menucarrinho = new Panel();
		Menucarrinho.Name = "Temporario";
		Menucarrinho.Size = this.ClientSize;
		Menucarrinho.Location = new Point(0, 0);
		Menucarrinho.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		Menucarrinho.BackgroundImageLayout = ImageLayout.Stretch;
		Menucarrinho.Visible = false;
		
		
		
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
			Menucarrinho.Visible = false;
			menucliente.Visible = true;
		};
		Menucarrinho.Controls.Add(botaoVoltar);
	}

    public void MenuRastreio() {
		Menurastreio = new Panel();
		Menurastreio.Name = "Temporario";
		Menurastreio.Size = this.ClientSize;
		Menurastreio.Location = new Point(0, 0);
		Menurastreio.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		Menurastreio.BackgroundImageLayout = ImageLayout.Stretch;
		Menurastreio.Visible = false;
		
		
		
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
			Menurastreio.Visible = false;
			menucliente.Visible = true;
		};
		Menurastreio.Controls.Add(botaoVoltar);
		
	}
    
    
    
    
}