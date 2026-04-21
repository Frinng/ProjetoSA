namespace ProjetoSA;

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
	
}