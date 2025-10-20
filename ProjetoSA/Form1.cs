namespace ProjetoSA;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public partial class Formprinciapl : Form {
    
    

    public Panel PainelRegistro;
    public Panel PainelLogin;
    public Panel Temp;
    
    public  Formprinciapl() {
            InitializeComponent();
            this.DoubleBuffered = true;
            
            this.Text = "Menu Principal";
            this.Width = 900;
            this.Height = 600;
            
            this.Size = new System.Drawing.Size(1200,675);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.BackColor = Color.White;
            
            // CORREÇÃO: Chame ambos os métodos de criação UMA VEZ.
            CriarPainelLogin();
            CriarPainelRegistro();
            
    }

    public void CriarPainelLogin() {
        
        PainelLogin = new Panel();
        PainelLogin.Name = "PainelLogin";
        PainelLogin.Size = this.ClientSize;
        PainelLogin.Location = new Point(0, 0);
        PainelLogin.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\ImagemLogin.png");
        PainelLogin.BackgroundImageLayout = ImageLayout.Stretch;
        PainelLogin.Visible = true;
        
        Label TextoOlaAmigo = new Label();
        TextoOlaAmigo.Text = "Olá, Amigo!";
        TextoOlaAmigo.Location = new Point(790, 200);
        TextoOlaAmigo.AutoSize = true;
        TextoOlaAmigo.Font = new Font("Arial",20, FontStyle.Bold);
        TextoOlaAmigo.ForeColor = Color.White;
        TextoOlaAmigo.BackColor = Color.Transparent; 
        PainelLogin.Controls.Add(TextoOlaAmigo); 

        Label InsiraDetalhes = new Label();
        InsiraDetalhes.Text = "Insira alguns Detalhes e comece sua jornada";
        InsiraDetalhes.Location = new Point(724,230);
        InsiraDetalhes.AutoSize = true;
        InsiraDetalhes.Font = new Font("Arial", 10, FontStyle.Bold);
        InsiraDetalhes.ForeColor = Color.White;
        InsiraDetalhes.BackColor = Color.Transparent;
        PainelLogin.Controls.Add(InsiraDetalhes);
            
        Label Conosco = new Label();
        Conosco.Text = "conosco.";
        Conosco.Location = new Point(835, 245);
        Conosco.AutoSize = true;
        Conosco.Font = new Font("Arial", 10, FontStyle.Bold);
        Conosco.ForeColor = Color.White;
        Conosco.BackColor = Color.Transparent;
        PainelLogin.Controls.Add(Conosco);
            
        Button BotaoRegistrar = new Button();
        BotaoRegistrar.Text = "REGISTRAR";
        BotaoRegistrar.AutoSize = true;
        BotaoRegistrar.Location = new Point(780, 270);
        BotaoRegistrar.Font = new Font("Arial",20,FontStyle.Bold);
        BotaoRegistrar.ForeColor = Color.White;
        BotaoRegistrar.BackColor = Color.FromArgb(0, 171, 155);
        BotaoRegistrar.FlatStyle = FlatStyle.Flat; 
        BotaoRegistrar.FlatAppearance.BorderColor = Color.White;
        BotaoRegistrar.FlatAppearance.BorderSize = 1;
        
        // CORREÇÃO: Alterne a visibilidade, não recrie o painel.
        BotaoRegistrar.Click += (sender, e) => { 
            PainelLogin.Visible = false;
            PainelRegistro.Visible = true;
        }; 
        PainelLogin.Controls.Add(BotaoRegistrar);

        Label Entrar_NoSistema = new Label();
        Entrar_NoSistema.Text = "ENTRAR NO SISTEMA";
        Entrar_NoSistema.Location = new Point(130,200);
        Entrar_NoSistema.AutoSize = true;
        Entrar_NoSistema.Font = new Font("Arial",20,FontStyle.Bold);
        Entrar_NoSistema.ForeColor =  Color.FromArgb(0, 171, 155);
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
            
        Button BotaoEsqueceuSenha = new Button();
        BotaoEsqueceuSenha.Text = "Esqueceusuasenha?";
        BotaoEsqueceuSenha.Location = new Point(205, 320);
        BotaoEsqueceuSenha.AutoSize = true;
        BotaoEsqueceuSenha.Font = new Font("Arial", 10, FontStyle.Bold);
        BotaoEsqueceuSenha.ForeColor = Color.FromArgb(0, 171, 155);
        BotaoEsqueceuSenha.BackColor = Color.White;
        BotaoEsqueceuSenha.FlatStyle = FlatStyle.Flat;
        BotaoEsqueceuSenha.FlatAppearance.BorderColor = Color.White;
        BotaoEsqueceuSenha.Click += (sender, e) => { };
        PainelLogin.Controls.Add(BotaoEsqueceuSenha);

        Button BotaoEntrar = new Button();
        BotaoEntrar.Text = "ENTRAR";
        BotaoEntrar.AutoSize = true;
        BotaoEntrar.Location = new Point(215, 350);
        BotaoEntrar.Font = new Font("Arial", 20, FontStyle.Bold);
        BotaoEntrar.ForeColor = Color.FromArgb(0, 171, 155);
        BotaoEntrar.FlatStyle = FlatStyle.Flat;
        BotaoEntrar.FlatAppearance.BorderColor = Color.FromArgb(0, 171, 155);
        BotaoEntrar.BackColor = Color.White;
        BotaoEntrar.FlatAppearance.BorderSize = 1;
        BotaoEntrar.Click += (sender, e) => {

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

            string resultado = ValidadorLogin.FazerLogin(usuario, senha);

            switch (resultado) {
                case "SUCESSO":
                    MessageBox.Show("Login realizado com sucesso!");
                    PainelLogin.Visible = false;
                    MenuTemp();
                    Temp.Visible = true;
                    this.Controls.Add(Temp);
                    break;

                case "ADMIN":
                    CampoUsuario.Clear();
                    CampoSenha.Clear();
                    
                    MessageBox.Show("Bem-vindo, Administrador!");
                    PainelLogin.Visible = false;
                    MenuTemp();
                    Temp.Visible = true;
                    this.Controls.Add(Temp);
                    break;

                case "FALHA":
                    MessageBox.Show("Usuário ou senha incorretos!");
                    break;

                case "ERRO":
                    break;
            }
            
        };
        PainelLogin.Controls.Add(BotaoEntrar);
        
        // CORREÇÃO: Adicione o PainelLogin ao Form
        this.Controls.Add(PainelLogin);
    }
    
    public void CriarPainelRegistro() {

        PainelRegistro = new Panel();
        PainelRegistro.Name = "PainelRegistro";
        PainelRegistro.Size = this.ClientSize;
        PainelRegistro.Location = new Point(0, 0);
        PainelRegistro.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
        PainelRegistro.BackgroundImageLayout = ImageLayout.Stretch;
        
        // CORREÇÃO: O painel de registro deve começar invisível.
        PainelRegistro.Visible = false;

        Label labelTituloRegistro = new Label();
        labelTituloRegistro.Text = "Crie sua Conta";
        labelTituloRegistro.Location = new Point(350, 100);
        labelTituloRegistro.Font = new Font("Arial", 28, FontStyle.Bold);
        labelTituloRegistro.AutoSize = true;
        labelTituloRegistro.BackColor = Color.Transparent;
        labelTituloRegistro.ForeColor = Color.FromArgb(0, 171, 155);
        PainelRegistro.Controls.Add(labelTituloRegistro); 

        TextBox campoNovoUsuario = new TextBox();
        campoNovoUsuario.Location = new Point(350, 180);
        campoNovoUsuario.Size = new Size(300, 30);
        campoNovoUsuario.Font = new Font("Arial", 20);
        campoNovoUsuario.PlaceholderText = "Digite seu usuário";
        campoNovoUsuario.TextAlign = HorizontalAlignment.Center;
        PainelRegistro.Controls.Add(campoNovoUsuario);

        TextBox campoNovaSenha = new TextBox();
        campoNovaSenha.Location = new Point(350, 240);
        campoNovaSenha.Size = new Size(300, 30);
        campoNovaSenha.Font = new Font("Arial", 20);
        campoNovaSenha.PlaceholderText = "Digite sua senha";
        campoNovaSenha.TextAlign = HorizontalAlignment.Center;
        PainelRegistro.Controls.Add(campoNovaSenha); 

        TextBox campoConfirmarSenha = new TextBox();
        campoConfirmarSenha.Location = new Point(350, 300);
        campoConfirmarSenha.Size = new Size(300, 30);
        campoConfirmarSenha.Font = new Font("Arial", 20);
        campoConfirmarSenha.PlaceholderText = "Confirme sua senha";
        campoConfirmarSenha.TextAlign = HorizontalAlignment.Center;
        PainelRegistro.Controls.Add(campoConfirmarSenha);
        
        Button botaoConfirmar = new Button();
        botaoConfirmar.Text = "CONFIRMAR REGISTRO";
        botaoConfirmar.Location = new Point(350, 370);
        botaoConfirmar.Size = new Size(300, 50);
        botaoConfirmar.Font = new Font("Arial", 16, FontStyle.Bold);
        botaoConfirmar.BackColor = Color.White;
        botaoConfirmar.ForeColor = Color.FromArgb(0, 171, 155);
        botaoConfirmar.FlatStyle = FlatStyle.Flat;
        botaoConfirmar.FlatAppearance.BorderSize = 1;
        botaoConfirmar.Click += (sender, e) => {
            
            // Pega os dados dos campos
            string novoUsuario = campoNovoUsuario.Text;
            string novaSenha = campoNovaSenha.Text;
            
            // VERIFICA SE O CAMPO de usuario ESTÁ VAZIO
            if (string.IsNullOrWhiteSpace(campoNovoUsuario.Text)) {
                MessageBox.Show("Por favor, preencha o campo Usuário!");
                return; // Para a execução do clique aqui
            }

            //VERIFICA SE O CAMPO DE SENHA ESTÁ VAZIO
            if (string.IsNullOrWhiteSpace(campoNovaSenha.Text)) {
                MessageBox.Show("Por favor, preencha o campo Senha!");
                return; // Para a execução do clique aqui
            }
            
            if (campoNovoUsuario.TextLength < 4) {
                
                MessageBox.Show("O seu usuario deve ter pelo menos 4 caracteres!");
                return; // Para a execução
                
            }
            
            if (campoNovaSenha.TextLength < 8) {
                
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres!");
                return; // Para a execução
                
            }
            if (novaSenha != campoConfirmarSenha.Text) {
                MessageBox.Show("As senhas não conferem!");
                return;
            }
            string resultado = LeitorPlanilha.AdicionarUsuario(novoUsuario, novaSenha);
            
            switch (resultado) {
                case "SUCESSO":
                    MessageBox.Show("Usuário registrado com sucesso!");
                    
                    // Limpa os campos
                    campoNovoUsuario.Text = "";
                    campoNovaSenha.Text = "";
                    campoConfirmarSenha.Text = "";
                    
                    // Volta para a tela de login
                    PainelRegistro.Visible = false;
                    PainelLogin.Visible = true;
                    break;
                
                case "USUARIO_EXISTE":
                    MessageBox.Show("Este nome de usuário já existe. Por favor, escolha outro.");
                    break;
                
                case "ERRO_ARQUIVO":
                    // A classe LeitorPlanilha já exibiu o MessageBox com o erro detalhado.
                    // Não precisa fazer nada aqui.
                    break;
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
        botaoVoltar.ForeColor = Color.FromArgb(0, 171, 155);
        botaoVoltar.Click += (sender, e) => {
            PainelRegistro.Visible = false;
            PainelLogin.Visible = true;
        };
        PainelRegistro.Controls.Add(botaoVoltar);
        
        this.Controls.Add(PainelRegistro);
        
        PainelRegistro.BringToFront(); 
        
    }

    public void MenuTemp() {
        
        
        Temp = new Panel();
        Temp.Name = "Temporario";
        Temp.Size = this.ClientSize;
        Temp.Location = new Point(0, 0);
        Temp.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
        Temp.BackgroundImageLayout = ImageLayout.Stretch;
        Temp.Visible = false;
        
        Button botaoVoltar = new Button();
        botaoVoltar.Text = "Voltar";
        botaoVoltar.Location = new Point(20, 20); 
        botaoVoltar.Font = new Font("Arial", 12, FontStyle.Bold);
        botaoVoltar.AutoSize = true;
        botaoVoltar.FlatStyle = FlatStyle.Flat;
        botaoVoltar.FlatAppearance.BorderSize = 0;
        botaoVoltar.BackColor = Color.White;
        botaoVoltar.ForeColor = Color.FromArgb(0, 171, 155);
        botaoVoltar.Click += (sender, e) => {
            Temp.Visible = false;
            PainelLogin.Visible = true;
        };
        Temp.Controls.Add(botaoVoltar);

    }
}