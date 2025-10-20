namespace ProjetoSA;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public partial class Formprinciapl : Form {

    public Panel PainelRegistro;
    public Panel PainelLogin;
    public Panel ADM;
    public Panel VerPlanilha;
    private DataGridView tabelaEstoque;
    public Panel Menuprincipal;
    public Panel MEmprestimoPrinc;
    public Panel VerFerramentasDisponiveis;
    private DataGridView tabelaFerramentas;

    public Formprinciapl() {
        InitializeComponent();
        this.DoubleBuffered = true;

        this.Text = "Menu Principal";
        this.Width = 900;
        this.Height = 600;

        this.Size = new System.Drawing.Size(1200, 675);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.StartPosition = FormStartPosition.CenterScreen;

        this.BackColor = Color.White;

        CriarPainelLogin();
        CriarPainelRegistro();
        MenuADM();
        Ver_Planilha();
        Menu_EmprestimoPrinci();
        this.Controls.Add(PainelLogin);
        this.Controls.Add(PainelRegistro);
        this.Controls.Add(ADM);
        this.Controls.Add(VerPlanilha);
        this.Controls.Add(MEmprestimoPrinc);
        PainelLogin.BringToFront();
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
        BotaoRegistrar.BackColor = Color.FromArgb(0, 171, 155);
        BotaoRegistrar.FlatStyle = FlatStyle.Flat;
        BotaoRegistrar.FlatAppearance.BorderColor = Color.White;
        BotaoRegistrar.FlatAppearance.BorderSize = 1;
        BotaoRegistrar.Click += (sender, e) => {
            PainelLogin.Visible = false;
            PainelRegistro.Visible = true;
        };
        PainelLogin.Controls.Add(BotaoRegistrar);

        Label Entrar_NoSistema = new Label();
        Entrar_NoSistema.Text = "ENTRAR NO SISTEMA";
        Entrar_NoSistema.Location = new Point(130, 200);
        Entrar_NoSistema.AutoSize = true;
        Entrar_NoSistema.Font = new Font("Arial", 20, FontStyle.Bold);
        Entrar_NoSistema.ForeColor = Color.FromArgb(0, 171, 155);
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
                    
                    
                    
                    break;

                case "ADMIN":
                    CampoUsuario.Clear();
                    CampoSenha.Clear();
                    MessageBox.Show("Bem-vindo, Administrador!");
                    PainelLogin.Visible = false;
                    ADM.Visible = true;
                    break;

                case "FALHA":
                    MessageBox.Show("Usuário ou senha incorretos!");
                    break;

                case "ERRO":
                    break;
            }
        };
        PainelLogin.Controls.Add(BotaoEntrar);
        this.Controls.Add(PainelLogin);
    }

    public void CriarPainelRegistro() {
        
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
        labelTituloRegistro.ForeColor = Color.FromArgb(0, 171, 155);
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

        Button botaoConfirmar = new Button();
        botaoConfirmar.Text = "CONFIRMAR REGISTRO";
        botaoConfirmar.Location = new Point(410, 370);
        botaoConfirmar.Size = new Size(300, 50);
        botaoConfirmar.Font = new Font("Arial", 16, FontStyle.Bold);
        botaoConfirmar.BackColor = Color.White;
        botaoConfirmar.ForeColor = Color.FromArgb(0, 171, 155);
        botaoConfirmar.FlatStyle = FlatStyle.Flat;
        botaoConfirmar.FlatAppearance.BorderSize = 1;
        botaoConfirmar.Click += (sender, e) => {
            string novoUsuario = campoNovoUsuario.Text;
            string novaSenha = campoNovaSenha.Text;

            if (string.IsNullOrWhiteSpace(campoNovoUsuario.Text)) {
                MessageBox.Show("Por favor, preencha o campo Usuário!");
                return;
            }

            if (string.IsNullOrWhiteSpace(campoNovaSenha.Text)) {
                MessageBox.Show("Por favor, preencha o campo Senha!");
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

            string resultado = LeitorPlanilha.AdicionarUsuario(novoUsuario, novaSenha);

            switch (resultado) {
                case "SUCESSO":
                    MessageBox.Show("Usuário registrado com sucesso!");
                    campoNovoUsuario.Text = "";
                    campoNovaSenha.Text = "";
                    campoConfirmarSenha.Text = "";
                    PainelRegistro.Visible = false;
                    PainelLogin.Visible = true;
                    break;

                case "USUARIO_EXISTE":
                    MessageBox.Show("Este nome de usuário já existe. Por favor, escolha outro.");
                    break;

                case "ERRO_ARQUIVO":
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
    
    public void MenuPrincipal() {
        

    }
    
    public void MenuADM() {
        ADM = new Panel();
        ADM.Name = "Temporario";
        ADM.Size = this.ClientSize;
        ADM.Location = new Point(0, 0);
        ADM.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
        ADM.BackgroundImageLayout = ImageLayout.Stretch;
        ADM.Visible = false;

        
        Label labelMenuADM = new Label();
        labelMenuADM.Text = "Menu Principal";
        labelMenuADM.Location = new Point(450, 100);
        labelMenuADM.Font = new Font("Arial", 28, FontStyle.Bold);
        labelMenuADM.AutoSize = true;
        labelMenuADM.BackColor = Color.Transparent;
        labelMenuADM.ForeColor = Color.FromArgb(0, 171, 155);
        ADM.Controls.Add(labelMenuADM);
        
        
        Button BotaoEntrar = new Button();
        BotaoEntrar.Text = "Ver Estoque";
        BotaoEntrar.Size = new Size(230, 40);
        BotaoEntrar.Location = new Point(480, 180);
        BotaoEntrar.Font = new Font("Arial", 20, FontStyle.Bold);
        BotaoEntrar.ForeColor = Color.FromArgb(0, 171, 155);
        BotaoEntrar.FlatStyle = FlatStyle.Flat;
        BotaoEntrar.FlatAppearance.BorderColor = Color.FromArgb(0, 171, 155);
        BotaoEntrar.BackColor = Color.White;
        BotaoEntrar.FlatAppearance.BorderSize = 1;
        BotaoEntrar.Click += (sender, e) => {
            tabelaEstoque.DataSource = MostrarPlanilha.LerPlanilhas();
            ADM.Visible = false;
            VerPlanilha.Visible = true;
        };
        ADM.Controls.Add(BotaoEntrar);
        
        
        Button BotaoMenuFerra = new Button();
        BotaoMenuFerra.Text = "Emprestimo";
        BotaoMenuFerra.Size = new Size(230, 40);
        BotaoMenuFerra.Location = new Point(480, 240);
        BotaoMenuFerra.Font = new Font("Arial", 20, FontStyle.Bold);
        BotaoMenuFerra.ForeColor = Color.FromArgb(0, 171, 155);
        BotaoMenuFerra.FlatStyle = FlatStyle.Flat;
        BotaoMenuFerra.FlatAppearance.BorderColor = Color.FromArgb(0, 171, 155);
        BotaoMenuFerra.BackColor = Color.White;
        BotaoMenuFerra.FlatAppearance.BorderSize = 1;
        BotaoMenuFerra.Click += (sender, e) => {
            ADM.Visible = false;
            MEmprestimoPrinc.Visible = true;
        };
        ADM.Controls.Add(BotaoMenuFerra);
        
        

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
            ADM.Visible = false;
            PainelLogin.Visible = true;
        };
        ADM.Controls.Add(botaoVoltar);
    }

    public void Ver_Planilha() {
        VerPlanilha = new Panel();
        VerPlanilha.Size = this.ClientSize;
        VerPlanilha.Location = new Point(0, 0);
        VerPlanilha.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
        VerPlanilha.BackgroundImageLayout = ImageLayout.Stretch;
        VerPlanilha.Visible = false;

        tabelaEstoque = new DataGridView();
        tabelaEstoque.Location = new Point(20, 70); // Posição (X, Y) - 20px da borda, 70px do topo
        tabelaEstoque.Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 90); // Tamanho (Largura, Altura)
        tabelaEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabelaEstoque.ReadOnly = true;
        tabelaEstoque.BackgroundColor = Color.White;
        tabelaEstoque.ForeColor = Color.FromArgb(0, 171, 155);
        tabelaEstoque.DefaultCellStyle.BackColor = Color.White;
        tabelaEstoque.DefaultCellStyle.ForeColor = Color.FromArgb(0, 171, 155);
        tabelaEstoque.DefaultCellStyle.Font = new Font("Arial", 12);
        tabelaEstoque.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        tabelaEstoque.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
        tabelaEstoque.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 171, 155);
        tabelaEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        tabelaEstoque.EnableHeadersVisualStyles = false;
        VerPlanilha.Controls.Add(tabelaEstoque);

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
            VerPlanilha.Visible = false;
            ADM.Visible = true;
        };
        VerPlanilha.Controls.Add(botaoVoltar);
        this.Controls.Add(VerPlanilha);
    }

    public void Menu_EmprestimoPrinci() {
        MEmprestimoPrinc = new Panel();
        MEmprestimoPrinc.Name = "Temporario";
        MEmprestimoPrinc.Size = this.ClientSize;
        MEmprestimoPrinc.Location = new Point(0, 0);
        MEmprestimoPrinc.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
        MEmprestimoPrinc.BackgroundImageLayout = ImageLayout.Stretch;
        MEmprestimoPrinc.Visible = false;
        
        
        //Botao de mostrar ferramentas disponiveis
        //botao de pegar emprestado
        Button MostrarFerramentas = new Button();
        MostrarFerramentas.Text = "Ferramentas Disponiveis";
        MostrarFerramentas.AutoSize = true;
        MostrarFerramentas.Location = new Point(410, 180);
        MostrarFerramentas.Font = new Font("Arial", 20, FontStyle.Bold);
        MostrarFerramentas.ForeColor = Color.FromArgb(0, 171, 155);
        MostrarFerramentas.FlatStyle = FlatStyle.Flat;
        MostrarFerramentas.FlatAppearance.BorderColor = Color.FromArgb(0, 171, 155);
        MostrarFerramentas.BackColor = Color.White;
        MostrarFerramentas.FlatAppearance.BorderSize = 1;
        MostrarFerramentas.Click += (sender, e) => {
            tabelaFerramentas.DataSource = Emprestimo.LerPlanilhas();
            
            VerPlanilha.Visible = true;
        };
        MEmprestimoPrinc.Controls.Add(MostrarFerramentas);
        
        
        
        
        
        //botao de pegar emprestado
        Button BotaoPegarEmprestimo = new Button();
        BotaoPegarEmprestimo.Text = "PEGAR EMPRESTADO";
        BotaoPegarEmprestimo.AutoSize = true;
        BotaoPegarEmprestimo.Location = new Point(410, 180);
        BotaoPegarEmprestimo.Font = new Font("Arial", 20, FontStyle.Bold);
        BotaoPegarEmprestimo.ForeColor = Color.FromArgb(0, 171, 155);
        BotaoPegarEmprestimo.FlatStyle = FlatStyle.Flat;
        BotaoPegarEmprestimo.FlatAppearance.BorderColor = Color.FromArgb(0, 171, 155);
        BotaoPegarEmprestimo.BackColor = Color.White;
        BotaoPegarEmprestimo.FlatAppearance.BorderSize = 1;
        BotaoPegarEmprestimo.Click += (sender, e) => {
            
            
            VerPlanilha.Visible = true;
        };
        MEmprestimoPrinc.Controls.Add(BotaoPegarEmprestimo);
        
        
        //botao de devolver ferramenta
        Button BotaoDevolverEmprestimo = new Button();
        BotaoPegarEmprestimo.Text = "DEVOLVER FERRAMENTA";
        BotaoPegarEmprestimo.AutoSize = true;
        BotaoPegarEmprestimo.Location = new Point(410, 240);
        BotaoPegarEmprestimo.Font = new Font("Arial", 20, FontStyle.Bold);
        BotaoPegarEmprestimo.ForeColor = Color.FromArgb(0, 171, 155);
        BotaoPegarEmprestimo.FlatStyle = FlatStyle.Flat;
        BotaoPegarEmprestimo.FlatAppearance.BorderColor = Color.FromArgb(0, 171, 155);
        BotaoPegarEmprestimo.BackColor = Color.White;
        BotaoPegarEmprestimo.FlatAppearance.BorderSize = 1;
        BotaoPegarEmprestimo.Click += (sender, e) => {
            tabelaEstoque.DataSource = MostrarPlanilha.LerPlanilhas();
            
            VerPlanilha.Visible = true;
        };
        MEmprestimoPrinc.Controls.Add(BotaoPegarEmprestimo);
        
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
            
        };
        MEmprestimoPrinc.Controls.Add(botaoVoltar);
        this.Controls.Add(MEmprestimoPrinc);
    }

    public void VerFerramentas() {
        
        // Criando o painel
        VerFerramentasDisponiveis = new Panel();
        VerFerramentasDisponiveis.Size = this.ClientSize;
        VerFerramentasDisponiveis.Location = new Point(0, 0);
        VerFerramentasDisponiveis.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
        VerFerramentasDisponiveis.BackgroundImageLayout = ImageLayout.Stretch;
        VerFerramentasDisponiveis.Visible = false;

        // Criando o DataGridView
        tabelaFerramentas = new DataGridView();
        tabelaFerramentas.Location = new Point(20, 70);
        tabelaFerramentas.Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 90);
        tabelaFerramentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabelaFerramentas.ReadOnly = true;
        tabelaFerramentas.BackgroundColor = Color.White;
        tabelaFerramentas.ForeColor = Color.FromArgb(0, 171, 155);
        tabelaFerramentas.DefaultCellStyle.BackColor = Color.White;
        tabelaFerramentas.DefaultCellStyle.ForeColor = Color.FromArgb(0, 171, 155);
        tabelaFerramentas.DefaultCellStyle.Font = new Font("Arial", 12);
        tabelaFerramentas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        tabelaFerramentas.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
        tabelaFerramentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 171, 155);
        tabelaFerramentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        tabelaFerramentas.EnableHeadersVisualStyles = false;

        // Carregar os dados da planilha
        tabelaFerramentas.DataSource = Emprestimo.LerPlanilhas();

        VerFerramentasDisponiveis.Controls.Add(tabelaFerramentas);

        // Criando o botão Voltar
        Button botaoVoltar = new Button();
        botaoVoltar.Text = "Voltar";
        botaoVoltar.Location = new Point(20, 20);
        botaoVoltar.Font = new Font("Arial", 12, FontStyle.Bold);
        botaoVoltar.AutoSize = true;
        botaoVoltar.FlatStyle = FlatStyle.Flat;
        botaoVoltar.FlatAppearance.BorderSize = 0;
        botaoVoltar.BackColor = Color.White;
        botaoVoltar.ForeColor = Color.FromArgb(0, 171, 155);
        botaoVoltar.Click += (sender, e) =>
        {
            VerFerramentasDisponiveis.Visible = false;
            PainelLogin.Visible = true;
        };

        VerFerramentasDisponiveis.Controls.Add(botaoVoltar);

        // Adicionando o painel ao Form
        this.Controls.Add(VerFerramentasDisponiveis);

        
    }
    
}
