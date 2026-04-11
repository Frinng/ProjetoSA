

namespace ProjetoSA;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;

public partial class Formprinciapl : Form {

	public Panel PainelRegistro;
	public Panel PainelLogin;
	public Panel MENUFORNECEDOR;
	public Panel Menucolaborador;
	public Panel MEmprestimoPrinc;
	public Panel VerFerramentasDisponiveis;
	public Panel PainelPegarEmprestimo;
	public Panel PainelDevolver;
	public Panel MenuFerramenta;
	public Panel menucliente;
	public Panel removeritem;
	public Panel adicionaritem;
	public Panel Menuverlotes;
	public Panel Menuconsultoria;
	public Panel MenucDA;
	public Panel Menufinanciamentos;
		
	
	private DataGridView tabelaEmprestimos;
	
	private void LimparCamposRegistro()
	{
		// Percorre todos os controles dentro do PainelRegistro
		foreach (Control c in PainelRegistro.Controls)
		{
			if (c is TextBox textBox)
			{
				textBox.Clear();
			}
		}
	}
	
	public Formprinciapl()
	{
		InitializeComponent();
		this.DoubleBuffered = true;

		this.Text = "S.A Desenvolvimento de Sistemas";
		this.Width = 900;
		this.Height = 600;

		this.Size = new System.Drawing.Size(1200, 675);
		this.FormBorderStyle = FormBorderStyle.FixedSingle;
		this.MaximizeBox = false;
		this.StartPosition = FormStartPosition.CenterScreen;

		this.BackColor = Color.White;

		MenuColaborador();
		CriarPainelLogin();
		CriarPainelRegistro();
		MenuFornecedor();
		MenuFinanciamentoa();
		MenuCliente();
		MenuVerlotes();
		MenuConsultoria();
		MenuDA();
		

		this.Controls.Add(Menucolaborador);
		this.Controls.Add(removeritem);
		this.Controls.Add(adicionaritem);
		this.Controls.Add(MenuFerramenta);
		this.Controls.Add(PainelPegarEmprestimo);
		this.Controls.Add(PainelDevolver);
		this.Controls.Add(VerFerramentasDisponiveis);
		this.Controls.Add(PainelLogin);
		this.Controls.Add(PainelRegistro);
		this.Controls.Add(MENUFORNECEDOR);
		this.Controls.Add(menucliente);
		this.Controls.Add(MEmprestimoPrinc);
		PainelLogin.BringToFront();
	}

	public void CriarPainelLogin() {

		bool escondersenha = true;

	    PainelLogin = new Panel();
	    PainelLogin.Name = "PainelLogin";
	    PainelLogin.Size = this.ClientSize;
	    PainelLogin.Location = new Point(0, 0);
	    PainelLogin.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\ImagemLogin.png");
	    PainelLogin.BackgroundImageLayout = ImageLayout.Stretch;
	    PainelLogin.Visible = true;

	    Label TextoOlaAmigo = new Label();
	    TextoOlaAmigo.Text = "Olá, Amigo!";
	    TextoOlaAmigo.Location = new Point(810, 200);
	    TextoOlaAmigo.AutoSize = true;
	    TextoOlaAmigo.Font = new Font("Arial", 20, FontStyle.Bold);
	    TextoOlaAmigo.ForeColor = Color.White;
	    TextoOlaAmigo.BackColor = Color.Transparent;
	    PainelLogin.Controls.Add(TextoOlaAmigo);

	    Label InsiraDetalhes = new Label();
	    InsiraDetalhes.Text = "Insira alguns Detalhes e comece sua jornada";
	    InsiraDetalhes.Location = new Point(735, 230);
	    InsiraDetalhes.AutoSize = true;
	    InsiraDetalhes.Font = new Font("Arial", 10, FontStyle.Bold);
	    InsiraDetalhes.ForeColor = Color.White;
	    InsiraDetalhes.BackColor = Color.Transparent;
	    PainelLogin.Controls.Add(InsiraDetalhes);

	    Label Conosco = new Label();
	    Conosco.Text = "conosco.";
	    Conosco.Location = new Point(855, 245);
	    Conosco.AutoSize = true;
	    Conosco.Font = new Font("Arial", 10, FontStyle.Bold);
	    Conosco.ForeColor = Color.White;
	    Conosco.BackColor = Color.Transparent;
	    PainelLogin.Controls.Add(Conosco);

	    Button BotaoRegistrar = new Button();
	    BotaoRegistrar.Text = "REGISTRAR";
	    BotaoRegistrar.AutoSize = true;
	    BotaoRegistrar.Location = new Point(795, 270);
	    BotaoRegistrar.Font = new Font("Arial", 20, FontStyle.Bold);
	    BotaoRegistrar.ForeColor = Color.White;
	    BotaoRegistrar.BackColor = Color.FromArgb(255, 189, 89);
	    BotaoRegistrar.FlatStyle = FlatStyle.Flat;
	    BotaoRegistrar.FlatAppearance.BorderColor = Color.White;
	    BotaoRegistrar.FlatAppearance.BorderSize = 1;
	    BotaoRegistrar.Click += (sender, e) => { 
		    LimparCamposRegistro();
	        PainelLogin.Visible = false;
	        PainelRegistro.Visible = true;
	    };
	    PainelLogin.Controls.Add(BotaoRegistrar);

	    Label Entrar_NoSistema = new Label();
	    Entrar_NoSistema.Text = "ENTRAR NO SISTEMA";
	    Entrar_NoSistema.Location = new Point(130, 200);
	    Entrar_NoSistema.AutoSize = true;
	    Entrar_NoSistema.Font = new Font("Arial", 20, FontStyle.Bold);
	    Entrar_NoSistema.ForeColor = Color.FromArgb(255, 189, 89);
	    Entrar_NoSistema.BackColor = Color.Transparent;
	    PainelLogin.Controls.Add(Entrar_NoSistema);

	    TextBox CampoUsuario = new TextBox();
	    CampoUsuario.Name = "campousuario";
	    CampoUsuario.Location = new Point(160, 240);
	    CampoUsuario.Size = new Size(250, 30);
	    CampoUsuario.Font = new Font("Arial", 20);
	    CampoUsuario.PlaceholderText = "Usuário";
	    CampoUsuario.TextAlign = HorizontalAlignment.Center;
	    PainelLogin.Controls.Add(CampoUsuario);

	    TextBox CampoSenha = new TextBox();
	    CampoSenha.Name = "camposenha";
	    CampoSenha.Location = new Point(160, 285);
	    CampoSenha.Size = new Size(250, 30);
	    CampoSenha.Font = new Font("Arial", 20);
	    CampoSenha.PlaceholderText = "Senha";
	    CampoSenha.TextAlign = HorizontalAlignment.Center;
	    PainelLogin.Controls.Add(CampoSenha);

	    Button botaoescondersenha = new Button();
	    Image imagemOriginal = Image.FromFile(@"..\..\..\Recursos\Ocultar.png");
	    botaoescondersenha.Image = new Bitmap(imagemOriginal, new Size(20, 20));
	    botaoescondersenha.ImageAlign = ContentAlignment.MiddleCenter;
	    botaoescondersenha.Location = new Point(420, 290);
	    botaoescondersenha.Size = new Size(30, 30);
	    botaoescondersenha.FlatStyle = FlatStyle.Flat;
	    botaoescondersenha.FlatAppearance.BorderSize = 1;
	    botaoescondersenha.Click += (sender, e) => {
	       escondersenha = !escondersenha;

	       CampoSenha.UseSystemPasswordChar = escondersenha;

	       Image img = Image.FromFile(
	          escondersenha
	             ? @"..\..\..\Recursos\Ocultar.png"
	             : @"..\..\..\Recursos\mostar.png"
	       );
	       botaoescondersenha.Image = new Bitmap(img, new Size(20, 20));
	    };
	    PainelLogin.Controls.Add(botaoescondersenha);

	    Button BotaoEntrar = new Button();
	    BotaoEntrar.Text = "ENTRAR";
	    BotaoEntrar.AutoSize = true;
	    BotaoEntrar.Location = new Point(215, 350);
	    BotaoEntrar.Font = new Font("Arial", 20, FontStyle.Bold);
	    BotaoEntrar.ForeColor = Color.FromArgb(255, 189, 89);
	    BotaoEntrar.FlatStyle = FlatStyle.Flat;
	    BotaoEntrar.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
	    BotaoEntrar.BackColor = Color.White;
	    BotaoEntrar.FlatAppearance.BorderSize = 1;
	    
	    // --- LÓGICA DE LOGIN INSERIDA AQUI ---
	    BotaoEntrar.Click += async (sender, e) => {
	        string usuario = CampoUsuario.Text;
	        string senha = CampoSenha.Text;

	        if (string.IsNullOrWhiteSpace(usuario)) {
	            MessageBox.Show("Por favor, digite seu usuário!");
	            return;
	        }

	        if (string.IsNullOrWhiteSpace(senha)) {
	            MessageBox.Show("Por favor, digite sua senha!");
	            return;
	        }

	        try {
	            using (HttpClient cliente = new HttpClient()) {
	                string url = "http://localhost/projeto_sa/logar.php";

	                // Monta o pacote de dados com "usuario" e "senha"
	                var dados = new FormUrlEncodedContent(new[] {
	                    new KeyValuePair<string, string>("usuario", usuario),
	                    new KeyValuePair<string, string>("senha", senha)
	                });
	                
	                HttpResponseMessage resposta = await cliente.PostAsync(url, dados);

	                if (resposta.IsSuccessStatusCode) {
	                    
	                    string resultado = await resposta.Content.ReadAsStringAsync();
	            
	                    
	                    resultado = resultado.Trim(); 

	                    
	                    switch (resultado) {
		                    case "COLABORADOR":
			                    CampoUsuario.Clear();
			                    CampoSenha.Clear();
			                    MessageBox.Show("Bem-vindo, Colaborador!");
			                    PainelLogin.Visible = false;
			                    // PainelColaborador.Visible = true; // Exemplo de redirecionamento
			                    Menucolaborador.Visible = true; 
			                    break;

		                    case "CLIENTE":
			                    CampoUsuario.Clear();
			                    CampoSenha.Clear();
			                    MessageBox.Show("Bem-vindo, Cliente!");
			                    PainelLogin.Visible = false;
			                    // PainelCliente.Visible = true; 
			                    menucliente.Visible = true;
			                    break;

		                    case "FORNECEDOR":
			                    CampoUsuario.Clear();
			                    CampoSenha.Clear();
			                    MessageBox.Show("Bem-vindo, Fornecedor!");
			                    PainelLogin.Visible = false;
			                    // PainelFornecedor.Visible = true;
			                    MENUFORNECEDOR.Visible = true;
			                    break;

	                        case "FALHA":
	                            MessageBox.Show("Usuário ou senha incorretos!");
	                            break;

	                        default:
	                            MessageBox.Show("Erro retornado pelo servidor: " + resultado);
	                            break;
	                    }
	                } else {
	                    MessageBox.Show("Erro no servidor: " + resposta.StatusCode);
	                }
	            }
	        }
	        catch (Exception ex) {
	            MessageBox.Show("Erro de conexão: " + ex.Message);
	        }
	    };

    PainelLogin.Controls.Add(BotaoEntrar);
    this.Controls.Add(PainelLogin);
	}

	public void CriarPainelRegistro()
	{
		bool escondersenha = false;

		PainelRegistro = new Panel();
		PainelRegistro.Name = "PainelRegistro";
		PainelRegistro.Size = this.ClientSize;
		PainelRegistro.Location = new Point(0, 0);
		PainelRegistro.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		PainelRegistro.BackgroundImageLayout = ImageLayout.Stretch;
		PainelRegistro.Visible = false;

		Label labelTituloRegistro = new Label();
		labelTituloRegistro.Text = "Crie sua Conta";
		labelTituloRegistro.Location = new Point(410, 100);
		labelTituloRegistro.Font = new Font("Arial", 28, FontStyle.Bold);
		labelTituloRegistro.AutoSize = true;
		labelTituloRegistro.BackColor = Color.Transparent;
		labelTituloRegistro.ForeColor = Color.FromArgb(255, 189, 89);
		PainelRegistro.Controls.Add(labelTituloRegistro);

		TextBox campoNovoUsuario = new TextBox();
		campoNovoUsuario.Location = new Point(410, 180);
		campoNovoUsuario.Size = new Size(300, 30);
		campoNovoUsuario.Font = new Font("Arial", 20);
		campoNovoUsuario.PlaceholderText = "Digite seu usuário";
		campoNovoUsuario.TextAlign = HorizontalAlignment.Center;
		PainelRegistro.Controls.Add(campoNovoUsuario);

		TextBox campoNovaSenha = new TextBox();
		campoNovaSenha.Location = new Point(410, 240);
		campoNovaSenha.Size = new Size(300, 30);
		campoNovaSenha.Font = new Font("Arial", 20);
		campoNovaSenha.PlaceholderText = "Digite sua senha";
		campoNovaSenha.TextAlign = HorizontalAlignment.Center;
		PainelRegistro.Controls.Add(campoNovaSenha);

		TextBox campoConfirmarSenha = new TextBox();
		campoConfirmarSenha.Location = new Point(410, 300);
		campoConfirmarSenha.Size = new Size(300, 30);
		campoConfirmarSenha.Font = new Font("Arial", 20);
		campoConfirmarSenha.PlaceholderText = "Confirme sua senha";
		campoConfirmarSenha.TextAlign = HorizontalAlignment.Center;
		PainelRegistro.Controls.Add(campoConfirmarSenha);

		ListBox listTipoUsuario = new ListBox();
		listTipoUsuario.Location = new Point(410, 350);
		listTipoUsuario.Size = new Size(300, 70); 
		listTipoUsuario.Font = new Font("Arial", 12);
		listTipoUsuario.Items.Add("Colaborador");
		listTipoUsuario.Items.Add("Cliente");
		listTipoUsuario.Items.Add("Fornecedor");
		PainelRegistro.Controls.Add(listTipoUsuario);
		
		Button botaoescondersenha = new Button();
		Image imagemOriginal = Image.FromFile(@"..\..\..\Recursos\Ocultar.png");
		botaoescondersenha.Image = new Bitmap(imagemOriginal, new Size(20, 20));
		botaoescondersenha.ImageAlign = ContentAlignment.MiddleCenter;
		botaoescondersenha.Location = new Point(720, 245);
		botaoescondersenha.Size = new Size(30, 30);
		botaoescondersenha.BackColor = Color.White;
		botaoescondersenha.ForeColor = Color.FromArgb(255, 189, 89);
		botaoescondersenha.FlatStyle = FlatStyle.Flat;
		botaoescondersenha.FlatAppearance.BorderSize = 1;
		botaoescondersenha.Click += (sender, e) => {
			escondersenha = !escondersenha;

			campoNovaSenha.UseSystemPasswordChar = escondersenha;
			campoConfirmarSenha.UseSystemPasswordChar = escondersenha;

			Image img = Image.FromFile(
				escondersenha
					? @"..\..\..\Recursos\Ocultar.png"
					: @"..\..\..\Recursos\mostar.png"
			);
			botaoescondersenha.Image = new Bitmap(img, new Size(20, 20));
		};
		PainelRegistro.Controls.Add(botaoescondersenha);

		Button botaoConfirmar = new Button();
		botaoConfirmar.Text = "CONFIRMAR REGISTRO";
		botaoConfirmar.Location = new Point(410, 440); 
		botaoConfirmar.Size = new Size(300, 50);
		botaoConfirmar.Font = new Font("Arial", 16, FontStyle.Bold);
		botaoConfirmar.BackColor = Color.White;
		botaoConfirmar.ForeColor = Color.FromArgb(255, 189, 89);
		botaoConfirmar.FlatStyle = FlatStyle.Flat;
		botaoConfirmar.FlatAppearance.BorderSize = 1;
		botaoConfirmar.Click += async (sender, e) => { 
		    string novoUsuario = campoNovoUsuario.Text;
		    string novaSenha = campoNovaSenha.Text;
		    string tipoSelecionado = listTipoUsuario.SelectedItem?.ToString();

		    // Validações básicas de interface
		    if (string.IsNullOrWhiteSpace(novoUsuario)) {
		        MessageBox.Show("Por favor, preencha o campo Usuário!");
		        return;
		    }

		    if (string.IsNullOrWhiteSpace(novaSenha)) {
		        MessageBox.Show("Por favor, preencha o campo Senha!");
		        return;
		    }

		    if (string.IsNullOrWhiteSpace(tipoSelecionado)) {
		        MessageBox.Show("Por favor, selecione o Tipo de Usuário!");
		        return;
		    }

		    if (campoNovoUsuario.TextLength < 4) {
		        MessageBox.Show("O seu usuario deve ter pelo menos 4 caracteres!");
		        return;
		    }

		    if (campoNovaSenha.TextLength < 8) {
		        MessageBox.Show("A senha deve ter pelo menos 8 caracteres!");
		        return;
		    }

		    if (novaSenha != campoConfirmarSenha.Text) {
		        MessageBox.Show("As senhas não conferem!");
		        return;
		    }

		    try {
		        using (HttpClient cliente = new HttpClient()){
		                  
		            string url = "http://localhost/projeto_sa/cadastrar.php";
		                  
		            var dados = new FormUrlEncodedContent(new[] {
		                new KeyValuePair<string, string>("novoUsuario", novoUsuario),
		                new KeyValuePair<string, string>("novaSenha", novaSenha),
		                new KeyValuePair<string, string>("tipoUsuario", tipoSelecionado),
		            });

		            HttpResponseMessage resposta = await cliente.PostAsync(url, dados);

		            if (resposta.IsSuccessStatusCode) {
		                string conteudo = await resposta.Content.ReadAsStringAsync();
		                
		                
		                if (conteudo.Contains("sucesso")) {
		                    MessageBox.Show("Usuário registrado com sucesso!");
		                    
		                    // Limpa os campos após o sucesso
		                    campoNovoUsuario.Clear();
		                    campoNovaSenha.Clear();
		                    campoConfirmarSenha.Clear();

		                    // Troca de tela
		                    PainelRegistro.Visible = false;
		                    PainelLogin.Visible = true;
		                } 
		                else if (conteudo.Contains("erro_usuario_existe")) {
		                    MessageBox.Show("Este nome de usuário já está em uso. Escolha outro!");
		                } 
		                else {
		                    MessageBox.Show("Erro ao cadastrar: " + conteudo);
		                }
		               
		            }
		            else {
		                MessageBox.Show("Erro no servidor: " + resposta.StatusCode);
		            }
		        }
		    }
		    catch (Exception ex){
		        MessageBox.Show("Erro de conexão: " + ex.Message);
		    }
		};
		PainelRegistro.Controls.Add(botaoConfirmar);

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
			PainelRegistro.Visible = false;
			PainelLogin.Visible = true;
		};
		PainelRegistro.Controls.Add(botaoVoltar);
		this.Controls.Add(PainelRegistro);
		PainelRegistro.BringToFront();
	}

	public void MenuColaborador()
	{

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
			MEmprestimoPrinc.Visible = true;
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
			adicionaritem.Visible = true;
		};
		Menucolaborador.Controls.Add(BotaoDA);

		Button BotaoFinancimento = new Button();
		BotaoFinancimento.Text = "Financiamento";
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
			removeritem.Visible = true;
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

	public void MenuFornecedor()
	{
		MENUFORNECEDOR = new Panel();
		MENUFORNECEDOR.Name = "Temporario";
		MENUFORNECEDOR.Size = this.ClientSize;
		MENUFORNECEDOR.Location = new Point(0, 0);
		MENUFORNECEDOR.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		MENUFORNECEDOR.BackgroundImageLayout = ImageLayout.Stretch;
		MENUFORNECEDOR.Visible = false;


		Label labelMenuADM = new Label();
		labelMenuADM.Text = "Menu Fornecedor";
		labelMenuADM.Location = new Point(450, 100);
		labelMenuADM.Font = new Font("Arial", 28, FontStyle.Bold);
		labelMenuADM.AutoSize = true;
		labelMenuADM.BackColor = Color.Transparent;
		labelMenuADM.ForeColor = Color.FromArgb(255, 189, 89);
		MENUFORNECEDOR.Controls.Add(labelMenuADM);


		Button BotaoEstoque = new Button();
		BotaoEstoque.Text = "Ver Entregas";
		BotaoEstoque.Size = new Size(230, 40);
		BotaoEstoque.Location = new Point(480, 180);
		BotaoEstoque.Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoEstoque.ForeColor = Color.FromArgb(255, 189, 89);
		BotaoEstoque.FlatStyle = FlatStyle.Flat;
		BotaoEstoque.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoEstoque.BackColor = Color.White;
		BotaoEstoque.FlatAppearance.BorderSize = 1;
		BotaoEstoque.Click += (sender, e) => {

			MENUFORNECEDOR.Visible = false;

		};
		MENUFORNECEDOR.Controls.Add(BotaoEstoque);


		Button BotaoMenuFerra = new Button();
		BotaoMenuFerra.Text = "Histórico";
		BotaoMenuFerra.Size = new Size(230, 40);
		BotaoMenuFerra.Location = new Point(480, 230);
		BotaoMenuFerra.Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoMenuFerra.ForeColor = Color.FromArgb(255, 189, 89);
		BotaoMenuFerra.FlatStyle = FlatStyle.Flat;
		BotaoMenuFerra.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoMenuFerra.BackColor = Color.White;
		BotaoMenuFerra.FlatAppearance.BorderSize = 1;
		BotaoMenuFerra.Click += (sender, e) => {
			MENUFORNECEDOR.Visible = false;
			MEmprestimoPrinc.Visible = true;
		};
		MENUFORNECEDOR.Controls.Add(BotaoMenuFerra);

		Button BotaoProdutos = new Button();
		BotaoProdutos.Text = "Contrato";
		BotaoProdutos.Size = new Size(230, 40);
		BotaoProdutos.Location = new Point(480, 280);
		BotaoProdutos.Font = new Font("Arial", 20, FontStyle.Bold);
		BotaoProdutos.ForeColor = Color.FromArgb(255, 189, 89);
		BotaoProdutos.FlatStyle = FlatStyle.Flat;
		BotaoProdutos.FlatAppearance.BorderColor = Color.FromArgb(255, 189, 89);
		BotaoProdutos.BackColor = Color.White;
		BotaoProdutos.FlatAppearance.BorderSize = 1;
		BotaoProdutos.Click += (sender, e) => {
			MENUFORNECEDOR.Visible = false;
			adicionaritem.Visible = true;
		};
		MENUFORNECEDOR.Controls.Add(BotaoProdutos);

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
			MEmprestimoPrinc.Visible = true;
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
			adicionaritem.Visible = true;
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
			removeritem.Visible = true;
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

	public void MenuVerlotes() {
		Menuverlotes = new Panel();
		Menuverlotes.Name = "Temporario";
		Menuverlotes.Size = this.ClientSize;
		Menuverlotes.Location = new Point(0, 0);
		Menuverlotes.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		Menuverlotes.BackgroundImageLayout = ImageLayout.Stretch;
		Menuverlotes.Visible = false;



		
	}
	
	public void MenuConsultoria() {
		Menuconsultoria = new Panel();
		Menuconsultoria.Name = "Temporario";
		Menuconsultoria.Size = this.ClientSize;
		Menuconsultoria.Location = new Point(0, 0);
		Menuconsultoria.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		Menuconsultoria.BackgroundImageLayout = ImageLayout.Stretch;
		Menuconsultoria.Visible = false;




	}
	
	public void MenuDA() {
		MenucDA = new Panel();
		MenucDA.Name = "Temporario";
		MenucDA.Size = this.ClientSize;
		MenucDA.Location = new Point(0, 0);
		MenucDA.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		MenucDA.BackgroundImageLayout = ImageLayout.Stretch;
		MenucDA.Visible = false;




	}
	
	public void MenuFinanciamentoa() {
		Menufinanciamentos = new Panel();
		Menufinanciamentos.Name = "Temporario";
		Menufinanciamentos.Size = this.ClientSize;
		Menufinanciamentos.Location = new Point(0, 0);
		Menufinanciamentos.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		Menufinanciamentos.BackgroundImageLayout = ImageLayout.Stretch;
		Menufinanciamentos.Visible = false;




	}
}

