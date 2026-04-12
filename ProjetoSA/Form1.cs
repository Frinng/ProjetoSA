namespace ProjetoSA;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;

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
	public Panel Menuhisto;
	public Panel Menucontrato;
	public Panel Menuentrega;
	public Panel Menucaract;
	public Panel Menuinfolotes;
	public Panel Menucarrinho;
	public Panel Menurastreio;
	public Panel MenuLoteMaternida;
	public Panel MenuLoteengorda;
	public Panel MenuLotequarentena;
	public Panel Menuvercontratos;
	public Panel Menunovoscontratos;
	
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
		MenuEntrega();
		Menuhistorico();
		MenuContrato();
		MenuCaracteristicas();
		MenuInfoLotes();
		MenuCarrinho();
		MenuRastreio();
		MenuLoteMaternidad();
		MenuLoteQuarentena();
		MenuLoteEngorda();
		MenuVerContratos();
		MenuNovosContratos();
		
		this.Controls.Add(Menunovoscontratos);
		this.Controls.Add(Menuvercontratos);
		this.Controls.Add(MenuLoteMaternida);
		this.Controls.Add(MenuLoteengorda);
		this.Controls.Add(MenuLotequarentena);
		this.Controls.Add(Menucaract);
		this.Controls.Add(Menuinfolotes);
		this.Controls.Add(Menucarrinho);
		this.Controls.Add(Menurastreio);
		this.Controls.Add(Menuverlotes);
		this.Controls.Add(Menuconsultoria);
		this.Controls.Add(MenucDA);
		this.Controls.Add(Menufinanciamentos);
		this.Controls.Add(Menuhisto);
		this.Controls.Add(Menucontrato);
		this.Controls.Add(Menuentrega);
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
	    CampoSenha.UseSystemPasswordChar = true;
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
			                    MENUFORNECEDOR.Visible = true;
			                    break;

	                        case "FALHA":
	                            MessageBox.Show("Usuário ou senha incorretos!");
	                            break;
		                    
		                    case "EMAIL_INEXISTENTE":
			                    MessageBox.Show("Este e-mail não está cadastrado no sistema!", "Usuário não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
		bool escondersenha = true;

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

		TextBox campoNovoEmail = new TextBox();
		campoNovoEmail.Location = new Point(410, 180);
		campoNovoEmail.Size = new Size(300, 30);
		campoNovoEmail.Font = new Font("Arial", 20);
		campoNovoEmail.PlaceholderText = "Digite seu e-mail";
		campoNovoEmail.TextAlign = HorizontalAlignment.Center;
		PainelRegistro.Controls.Add(campoNovoEmail);

		TextBox campoNovaSenha = new TextBox();
		campoNovaSenha.Location = new Point(410, 240);
		campoNovaSenha.Size = new Size(300, 30);
		campoNovaSenha.Font = new Font("Arial", 20);
		campoNovaSenha.PlaceholderText = "Digite sua senha";
		campoNovaSenha.TextAlign = HorizontalAlignment.Center;
		campoNovaSenha.UseSystemPasswordChar = true;
		PainelRegistro.Controls.Add(campoNovaSenha);

		TextBox campoConfirmarSenha = new TextBox();
		campoConfirmarSenha.Location = new Point(410, 300);
		campoConfirmarSenha.Size = new Size(300, 30);
		campoConfirmarSenha.Font = new Font("Arial", 20);
		campoConfirmarSenha.PlaceholderText = "Confirme sua senha";
		campoConfirmarSenha.TextAlign = HorizontalAlignment.Center;
		campoConfirmarSenha.UseSystemPasswordChar = true;
		PainelRegistro.Controls.Add(campoConfirmarSenha);

		ListBox listTipoUsuario = new ListBox();
		listTipoUsuario.Location = new Point(410, 350);
		listTipoUsuario.Size = new Size(300, 45);
		listTipoUsuario.Font = new Font("Arial", 12);
		listTipoUsuario.ForeColor = Color.FromArgb(255, 189, 89);
		listTipoUsuario.Items.Add("Colaborador");
		listTipoUsuario.Items.Add("Cliente");
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
			string novoEmail = campoNovoEmail.Text;
		    string novaSenha = campoNovaSenha.Text;
		    string tipoSelecionado = listTipoUsuario.SelectedItem?.ToString();

		    // Validações básicas de interface
		    if (string.IsNullOrWhiteSpace(novoEmail)) {
			    MessageBox.Show("Por favor, preencha o campo E-mail!");
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

		    if (!novoEmail.Contains("@") || !novoEmail.Contains(".")) {
			    MessageBox.Show("Por favor, insira um e-mail válido!");
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
		                new KeyValuePair<string, string>("novoUsuario", novoEmail),
		                new KeyValuePair<string, string>("novaSenha", novaSenha),
		                new KeyValuePair<string, string>("tipoUsuario", tipoSelecionado),
		            });

		            HttpResponseMessage resposta = await cliente.PostAsync(url, dados);

		            if (resposta.IsSuccessStatusCode) {
		                string conteudo = await resposta.Content.ReadAsStringAsync();
		                
		                
		                if (conteudo.Contains("sucesso")) {
		                    MessageBox.Show("Usuário registrado com sucesso!");
		                    
		                    // Limpa os campos após o sucesso
		                    campoNovoEmail.Clear();
		                    campoNovaSenha.Clear();
		                    campoConfirmarSenha.Clear();

		                    // Troca de tela
		                    PainelRegistro.Visible = false;
		                    PainelLogin.Visible = true;
		                } 
		                else if (conteudo.Contains("erro_email_existe")) {
			                MessageBox.Show("Este e-mail já está cadastrado!");
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

	public void MenuColaborador() {

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
	    lblAbate.Text = "Animais prontos para abate: Carregando...";
	    lblAbate.Location = new Point(400, 180);
	    lblAbate.Font = new Font("Arial", 14, FontStyle.Bold);
	    lblAbate.ForeColor = Color.FromArgb(255, 189, 89);
	    lblAbate.BackColor = Color.Transparent;
	    lblAbate.AutoSize = true;
	    Menuconsultoria.Controls.Add(lblAbate);

	    // 2. Vacas Doentes
	    Label lblDoentes = new Label();
	    lblDoentes.Text = "Vacas em Quarentena (Doentes): Carregando...";
	    lblDoentes.Location = new Point(400, 220);
	    lblDoentes.Font = new Font("Arial", 14, FontStyle.Bold);
	    lblDoentes.ForeColor = Color.FromArgb(255, 189, 89);
	    lblDoentes.BackColor = Color.Transparent;
	    lblDoentes.AutoSize = true;
	    Menuconsultoria.Controls.Add(lblDoentes);

	    // 3. Preço da Arroba
	    Label lblPrecoArroba = new Label();
	    lblPrecoArroba.Text = "Preço da Arroba: R$ 0,00";
	    lblPrecoArroba.Location = new Point(400, 260);
	    lblPrecoArroba.Font = new Font("Arial(14)", 14, FontStyle.Bold);
	    lblPrecoArroba.ForeColor = Color.FromArgb(255, 189, 89);
	    lblPrecoArroba.BackColor = Color.Transparent;
	    lblPrecoArroba.AutoSize = true;
	    Menuconsultoria.Controls.Add(lblPrecoArroba);

	    // 4. Taxas e Vacinas
	    Label lblTaxas = new Label();
	    lblTaxas.Text = "Custos: Vacina R$ 15,20 | Abate R$ 45,00";
	    lblTaxas.Location = new Point(400, 300);
	    lblTaxas.Font = new Font("Arial", 14, FontStyle.Bold);
	    lblTaxas.ForeColor = Color.FromArgb(255, 189, 89);
	    lblTaxas.BackColor = Color.Transparent;
	    lblTaxas.AutoSize = true;
	    Menuconsultoria.Controls.Add(lblTaxas);

	    // 5. Margem de Lucro
	    Label lblMargem = new Label();
	    lblMargem.Text = "Margem de Lucro Prevista: 0%";
	    lblMargem.Location = new Point(400, 340);
	    lblMargem.Font = new Font("Arial", 14, FontStyle.Bold);
	    lblMargem.ForeColor = Color.FromArgb(255, 189, 89);
	    lblMargem.BackColor = Color.Transparent;
	    lblMargem.AutoSize = true;
	    Menuconsultoria.Controls.Add(lblMargem);

	    // --- BOTÃO ATUALIZAR ---
	    Button btnAtualizar = new Button();
	    btnAtualizar.Text = "Sincronizar Dados";
	    btnAtualizar.Location = new Point(460, 380);
	    btnAtualizar.Size = new Size(220, 45);
	    btnAtualizar.BackColor = Color.White;
	    btnAtualizar.ForeColor = Color.FromArgb(255, 189, 89);
	    btnAtualizar.FlatStyle = FlatStyle.Flat;
	    btnAtualizar.Font = new Font("Arial", 12, FontStyle.Bold);
	    btnAtualizar.Click += (sender, e) => {
	        // Aqui você chamaria a função que lê o PHP
	        // Simulação dos valores vindo do banco:
	        lblAbate.Text = "Animais prontos para abate: 15";
	        lblDoentes.Text = "Vacas em Quarentena (Doentes): 2";
	        lblPrecoArroba.Text = "Preço da Arroba: R$ 285,50";
	        lblMargem.Text = "Margem de Lucro Prevista: 5%";
	    };
	    Menuconsultoria.Controls.Add(btnAtualizar);
		
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

	public void MenuVerContratos() {
		Menuvercontratos = new Panel();
		Menuvercontratos.Name = "Temporario";
		Menuvercontratos.Size = this.ClientSize;
		Menuvercontratos.Location = new Point(0, 0);
		Menuvercontratos.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
		Menuvercontratos.BackgroundImageLayout = ImageLayout.Stretch;
		Menuvercontratos.Visible = false;


		
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
