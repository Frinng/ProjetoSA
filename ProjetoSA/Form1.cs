namespace ProjetoSA;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ClosedXML.Excel;

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
    public Panel PainelPegarEmprestimo;
    public Panel PainelDevolver;
    public Panel PainelVerEmprestimos;
    public Panel adicionarproduto;
    public Panel removeritem;
    public Panel adicionaritem;
    public static string CaminhoDoEstoque = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PLanilhaSimuladoEstoque.xlsx");

    private DataGridView tabelaEmprestimos;

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
        VerFerramentas();
        CriarPainelPegarEmprestimo();
        CriarPainelDevolver();
        CriarPainelVerEmprestimos();
        Adicionaritem();
        Removeritem();
        MenuPrincipal();
        
        this.Controls.Add(Menuprincipal);
        this.Controls.Add(removeritem);
        this.Controls.Add(adicionaritem);
        this.Controls.Add(PainelVerEmprestimos);
        this.Controls.Add(PainelPegarEmprestimo);
        this.Controls.Add(PainelDevolver);
        this.Controls.Add(VerFerramentasDisponiveis);
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
                    
                    Menuprincipal.Visible = true;
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
        
        Menuprincipal = new Panel();
        Menuprincipal.Name = "MenuUsuario";
        Menuprincipal.Size = this.ClientSize;
        Menuprincipal.Location = new Point(0, 0);
        Menuprincipal.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
        Menuprincipal.BackgroundImageLayout = ImageLayout.Stretch;
        Menuprincipal.Visible = false;

        
        Label labelMenuADM = new Label();
        labelMenuADM.Text = "Menu Principal";
        labelMenuADM.Location = new Point(450, 100);
        labelMenuADM.Font = new Font("Arial", 28, FontStyle.Bold);
        labelMenuADM.AutoSize = true;
        labelMenuADM.BackColor = Color.Transparent;
        labelMenuADM.ForeColor = Color.FromArgb(0, 171, 155);
        Menuprincipal.Controls.Add(labelMenuADM);
        
        
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
        Menuprincipal.Controls.Add(BotaoEntrar);
        
        
        Button BotaoMenuFerra = new Button();
        BotaoMenuFerra.Text = "Emprestimo";
        BotaoMenuFerra.Size = new Size(230, 40);
        BotaoMenuFerra.Location = new Point(480, 230);
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
        Menuprincipal.Controls.Add(BotaoMenuFerra);
        
        Button BotaoAddItem = new Button();
        BotaoAddItem .Text = "Adicionar Produto";
        BotaoAddItem .Size = new Size(230, 40);
        BotaoAddItem .Location = new Point(480, 280);
        BotaoAddItem .Font = new Font("Arial", 20, FontStyle.Bold);
        BotaoAddItem .ForeColor = Color.FromArgb(0, 171, 155);
        BotaoAddItem .FlatStyle = FlatStyle.Flat;
        BotaoAddItem .FlatAppearance.BorderColor = Color.FromArgb(0, 171, 155);
        BotaoAddItem .BackColor = Color.White;
        BotaoAddItem .FlatAppearance.BorderSize = 1;
        BotaoAddItem .Click += (sender, e) => {
            ADM.Visible = false;
            adicionaritem.Visible = true;
        };
        Menuprincipal.Controls.Add(BotaoAddItem );
        
        Button BotaoRemoveItem = new Button();
        BotaoRemoveItem .Text = "Remover Produto";
        BotaoRemoveItem.Size = new Size(230, 40);
        BotaoRemoveItem.Location = new Point(480, 330);
        BotaoRemoveItem.Font = new Font("Arial", 20, FontStyle.Bold);
        BotaoRemoveItem.ForeColor = Color.FromArgb(0, 171, 155);
        BotaoRemoveItem.FlatStyle = FlatStyle.Flat;
        BotaoRemoveItem.FlatAppearance.BorderColor = Color.FromArgb(0, 171, 155);
        BotaoRemoveItem.BackColor = Color.White;
        BotaoRemoveItem.FlatAppearance.BorderSize = 1;
        BotaoRemoveItem.Click += (sender, e) => {
            ADM.Visible = false;
            removeritem.Visible = true;
        };
        Menuprincipal.Controls.Add(BotaoRemoveItem);

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
        Menuprincipal.Controls.Add(botaoVoltar);
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
        BotaoMenuFerra.Location = new Point(480, 230);
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
        
        Button BotaoAddItem = new Button();
        BotaoAddItem .Text = "Adicionar item";
        BotaoAddItem .Size = new Size(230, 40);
        BotaoAddItem .Location = new Point(480, 280);
        BotaoAddItem .Font = new Font("Arial", 20, FontStyle.Bold);
        BotaoAddItem .ForeColor = Color.FromArgb(0, 171, 155);
        BotaoAddItem .FlatStyle = FlatStyle.Flat;
        BotaoAddItem .FlatAppearance.BorderColor = Color.FromArgb(0, 171, 155);
        BotaoAddItem .BackColor = Color.White;
        BotaoAddItem .FlatAppearance.BorderSize = 1;
        BotaoAddItem .Click += (sender, e) => {
            ADM.Visible = false;
            adicionaritem.Visible = true;
        };
        ADM.Controls.Add(BotaoAddItem );
        
        Button BotaoRemoveItem = new Button();
        BotaoRemoveItem .Text = "Remover Item";
        BotaoRemoveItem.Size = new Size(230, 40);
        BotaoRemoveItem.Location = new Point(480, 330);
        BotaoRemoveItem.Font = new Font("Arial", 20, FontStyle.Bold);
        BotaoRemoveItem.ForeColor = Color.FromArgb(0, 171, 155);
        BotaoRemoveItem.FlatStyle = FlatStyle.Flat;
        BotaoRemoveItem.FlatAppearance.BorderColor = Color.FromArgb(0, 171, 155);
        BotaoRemoveItem.BackColor = Color.White;
        BotaoRemoveItem.FlatAppearance.BorderSize = 1;
        BotaoRemoveItem.Click += (sender, e) => {
            ADM.Visible = false;
            removeritem.Visible = true;
        };
        ADM.Controls.Add(BotaoRemoveItem);

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
        
        Label labelMenuEmp = new Label();
        labelMenuEmp.Text = "Menu De Emprestimo";
        labelMenuEmp.Location = new Point(370, 100);
        labelMenuEmp.Font = new Font("Arial", 28, FontStyle.Bold);
        labelMenuEmp.AutoSize = true;
        labelMenuEmp.BackColor = Color.Transparent;
        labelMenuEmp.ForeColor = Color.FromArgb(0, 171, 155);
        MEmprestimoPrinc.Controls.Add(labelMenuEmp);
        
        // Botao de mostrar ferramentas disponiveis
        Button MostrarFerramentas = new Button();
        MostrarFerramentas.Text = "Ferramentas";
        MostrarFerramentas.Size = new Size(240, 40);
        MostrarFerramentas.Location = new Point(460, 160);
        MostrarFerramentas.Font = new Font("Arial", 20, FontStyle.Bold);
        // ... (estilos) ...
        MostrarFerramentas.ForeColor = Color.FromArgb(0, 171, 155);
        MostrarFerramentas.FlatStyle = FlatStyle.Flat;
        MostrarFerramentas.FlatAppearance.BorderColor = Color.FromArgb(0, 171, 155);
        MostrarFerramentas.BackColor = Color.White;
        MostrarFerramentas.FlatAppearance.BorderSize = 1;
        MostrarFerramentas.Click += (sender, e) => {
            tabelaFerramentas.DataSource = Emprestimo.LerPlanilhas();
            VerFerramentasDisponiveis.Visible = true; 
            MEmprestimoPrinc.Visible = false;
        };
        MEmprestimoPrinc.Controls.Add(MostrarFerramentas);
        
        // Botão PEGAR EMPRESTADO
        Button BotaoPegarEmprestimo = new Button();
        BotaoPegarEmprestimo.Text = "PEGAR";
        BotaoPegarEmprestimo.Size = new Size(240, 40);
        BotaoPegarEmprestimo.Location = new Point(460, 210);
        BotaoPegarEmprestimo.Font = new Font("Arial", 20, FontStyle.Bold);
        // ... (estilos) ...
        BotaoPegarEmprestimo.ForeColor = Color.FromArgb(0, 171, 155);
        BotaoPegarEmprestimo.FlatStyle = FlatStyle.Flat;
        BotaoPegarEmprestimo.FlatAppearance.BorderColor = Color.FromArgb(0, 171, 155);
        BotaoPegarEmprestimo.BackColor = Color.White;
        BotaoPegarEmprestimo.FlatAppearance.BorderSize = 1;
        BotaoPegarEmprestimo.Click += (sender, e) => {
            MEmprestimoPrinc.Visible = false;
            PainelPegarEmprestimo.Visible = true;
        };
        MEmprestimoPrinc.Controls.Add(BotaoPegarEmprestimo);
        
        
        // Botão DEVOLVER FERRAMENTA
        Button BotaoDevolverEmprestimo = new Button();
        BotaoDevolverEmprestimo.Text = "DEVOLVER";
        BotaoDevolverEmprestimo.Size = new Size(240, 40);
        BotaoDevolverEmprestimo.Location = new Point(460, 260); // Posição 260
        BotaoDevolverEmprestimo.Font = new Font("Arial", 20, FontStyle.Bold);
        // ... (estilos) ...
        BotaoDevolverEmprestimo.ForeColor = Color.FromArgb(0, 171, 155);
        BotaoDevolverEmprestimo.FlatStyle = FlatStyle.Flat;
        BotaoDevolverEmprestimo.FlatAppearance.BorderColor = Color.FromArgb(0, 171, 155);
        BotaoDevolverEmprestimo.BackColor = Color.White;
        BotaoDevolverEmprestimo.FlatAppearance.BorderSize = 1;
        BotaoDevolverEmprestimo.Click += (sender, e) => {
            MEmprestimoPrinc.Visible = false;
            PainelDevolver.Visible = true;
        };
        MEmprestimoPrinc.Controls.Add(BotaoDevolverEmprestimo);
        
        // --- NOVO BOTÃO (Corrigido) ---
        Button VerEmprestimos = new Button();
        VerEmprestimos.Text = "VER EMPRÉSTIMOS"; // Texto corrigido
        VerEmprestimos.Size = new Size(240, 40);
        VerEmprestimos.Location = new Point(460, 310); // Posição corrigida (260 + 40 + 10)
        VerEmprestimos.Font = new Font("Arial", 20, FontStyle.Bold);
        // ... (estilos) ...
        VerEmprestimos.ForeColor = Color.FromArgb(0, 171, 155);
        VerEmprestimos.FlatStyle = FlatStyle.Flat;
        VerEmprestimos.FlatAppearance.BorderColor = Color.FromArgb(0, 171, 155);
        VerEmprestimos.BackColor = Color.White;
        VerEmprestimos.FlatAppearance.BorderSize = 1;
        VerEmprestimos.Click += (sender, e) => {
            // Ação corrigida:
            tabelaEmprestimos.DataSource = GerenciadorEmprestimos.LerPlanilhaLog(); // Carrega os dados
            MEmprestimoPrinc.Visible = false;
            PainelVerEmprestimos.Visible = true; // Abre o painel novo
        };
        MEmprestimoPrinc.Controls.Add(VerEmprestimos);
        
        // --- Botão Voltar ---
        Button botaoVoltar = new Button();
        botaoVoltar.Text = "Voltar";
        botaoVoltar.Location = new Point(20, 20);
        // ... (estilos) ...
        botaoVoltar.Font = new Font("Arial", 12, FontStyle.Bold);
        botaoVoltar.AutoSize = true;
        botaoVoltar.FlatStyle = FlatStyle.Flat;
        botaoVoltar.FlatAppearance.BorderSize = 0;
        botaoVoltar.BackColor = Color.White;
        botaoVoltar.ForeColor = Color.FromArgb(0, 171, 155);
        botaoVoltar.Click += (sender, e) => {
            MEmprestimoPrinc.Visible = false;
            ADM.Visible = true;
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
            MEmprestimoPrinc.Visible = true;
        };

        VerFerramentasDisponiveis.Controls.Add(botaoVoltar);

        // Adicionando o painel ao Form
        this.Controls.Add(VerFerramentasDisponiveis);

        
    }
   
    public void CriarPainelPegarEmprestimo() {
        
        PainelPegarEmprestimo = new Panel();
        PainelPegarEmprestimo.Size = this.ClientSize;
        PainelPegarEmprestimo.Location = new Point(0, 0);
        PainelPegarEmprestimo.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
        PainelPegarEmprestimo.BackgroundImageLayout = ImageLayout.Stretch;
        PainelPegarEmprestimo.Visible = false;

        Label labelTitulo = new Label();
        labelTitulo.Text = "Registrar Empréstimo";
        labelTitulo.Location = new Point(370, 100);
        labelTitulo.Font = new Font("Arial", 28, FontStyle.Bold);
        labelTitulo.AutoSize = true;
        labelTitulo.BackColor = Color.Transparent;
        labelTitulo.ForeColor = Color.FromArgb(0, 171, 155);
        PainelPegarEmprestimo.Controls.Add(labelTitulo);

        // --- Campos de Texto ---
        TextBox campoNomePessoa = new TextBox();
        campoNomePessoa.Location = new Point(410, 180);
        campoNomePessoa.Size = new Size(300, 30);
        campoNomePessoa.Font = new Font("Arial", 14);
        campoNomePessoa.PlaceholderText = "Nome Da Pessoa";
        PainelPegarEmprestimo.Controls.Add(campoNomePessoa);

        TextBox campoCPF = new TextBox();
        campoCPF.Location = new Point(410, 230);
        campoCPF.Size = new Size(300, 30);
        campoCPF.Font = new Font("Arial", 14);
        campoCPF.PlaceholderText = "CPF";
        PainelPegarEmprestimo.Controls.Add(campoCPF);

        TextBox campoEndereco = new TextBox();
        campoEndereco.Location = new Point(410, 280);
        campoEndereco.Size = new Size(300, 30);
        campoEndereco.Font = new Font("Arial", 14);
        campoEndereco.PlaceholderText = "Endereço";
        PainelPegarEmprestimo.Controls.Add(campoEndereco);

        TextBox campoCidade = new TextBox();
        campoCidade.Location = new Point(410, 330);
        campoCidade.Size = new Size(300, 30);
        campoCidade.Font = new Font("Arial", 14);
        campoCidade.PlaceholderText = "Cidade";
        PainelPegarEmprestimo.Controls.Add(campoCidade);

        // --- CAMPO MODIFICADO ---
        TextBox campoItemFerramenta = new TextBox(); // Renomeado
        campoItemFerramenta.Location = new Point(410, 380);
        campoItemFerramenta.Size = new Size(300, 30);
        campoItemFerramenta.Font = new Font("Arial", 14);
        campoItemFerramenta.PlaceholderText = "Item da Ferramenta"; // Texto modificado
        PainelPegarEmprestimo.Controls.Add(campoItemFerramenta);
        
        // (Campos Descricao e Marca/Modelo foram removidos deste formulário)
        
        // --- Botão Confirmar ---
        Button botaoConfirmar = new Button();
        botaoConfirmar.Text = "CONFIRMAR EMPRÉSTIMO";
        botaoConfirmar.Location = new Point(410, 430); // Posição Y ajustada
        botaoConfirmar.Size = new Size(300, 50);
        botaoConfirmar.Font = new Font("Arial", 16, FontStyle.Bold);
        botaoConfirmar.BackColor = Color.White;
        botaoConfirmar.ForeColor = Color.FromArgb(0, 171, 155);
        botaoConfirmar.FlatStyle = FlatStyle.Flat;
        botaoConfirmar.FlatAppearance.BorderSize = 1;
        botaoConfirmar.Click += (sender, e) => {
            // Chama a função do Gerenciador com o Item
            string resultado = GerenciadorEmprestimos.RealizarEmprestimo(
                campoNomePessoa.Text,
                campoCPF.Text,
                campoEndereco.Text,
                campoCidade.Text,
                campoItemFerramenta.Text // Passa o Item em vez do código
            );

            MessageBox.Show(resultado); 

            if (resultado.EndsWith("registrado com sucesso!"))
            {
                campoNomePessoa.Clear();
                campoCPF.Clear();
                campoEndereco.Clear();
                campoCidade.Clear();
                campoItemFerramenta.Clear();
                
                PainelPegarEmprestimo.Visible = false;
                MEmprestimoPrinc.Visible = true;
            }
        };
        PainelPegarEmprestimo.Controls.Add(botaoConfirmar);

        // --- Botão Voltar ---
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
            PainelPegarEmprestimo.Visible = false;
            MEmprestimoPrinc.Visible = true;
        };
        PainelPegarEmprestimo.Controls.Add(botaoVoltar);
    } 

    // --- NOVO PAINEL PARA DEVOLVER ---
    public void CriarPainelDevolver() {
        PainelDevolver = new Panel();
        PainelDevolver.Size = this.ClientSize;
        PainelDevolver.Location = new Point(0, 0);
        PainelDevolver.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
        PainelDevolver.BackgroundImageLayout = ImageLayout.Stretch;
        PainelDevolver.Visible = false;

        Label labelTitulo = new Label();
        labelTitulo.Text = "Registrar Devolução";
        labelTitulo.Location = new Point(370, 100);
        labelTitulo.Font = new Font("Arial", 28, FontStyle.Bold);
        labelTitulo.AutoSize = true;
        labelTitulo.BackColor = Color.Transparent;
        labelTitulo.ForeColor = Color.FromArgb(0, 171, 155);
        PainelDevolver.Controls.Add(labelTitulo);

        // --- Campos de Texto MODIFICADOS ---
        TextBox campoItem = new TextBox(); 
        campoItem.Location = new Point(410, 180);
        campoItem.Size = new Size(300, 30);
        campoItem.Font = new Font("Arial", 14);
        campoItem.PlaceholderText = "Item do Empréstimo (da Planilha Log)"; // Texto modificado
        PainelDevolver.Controls.Add(campoItem);

        // --- NOVO CAMPO ---
        TextBox campoNomePessoaDev = new TextBox();
        campoNomePessoaDev.Location = new Point(410, 230); // Posição Y ajustada
        campoNomePessoaDev.Size = new Size(300, 30);
        campoNomePessoaDev.Font = new Font("Arial", 14);
        campoNomePessoaDev.PlaceholderText = "Nome da Pessoa";
        PainelDevolver.Controls.Add(campoNomePessoaDev);
        
        // --- NOVO CAMPO ---
        TextBox campoCPFDev = new TextBox();
        campoCPFDev.Location = new Point(410, 280); // Posição Y ajustada
        campoCPFDev.Size = new Size(300, 30);
        campoCPFDev.Font = new Font("Arial", 14);
        campoCPFDev.PlaceholderText = "CPF da Pessoa";
        PainelDevolver.Controls.Add(campoCPFDev);

        // --- Botão Confirmar ---
        Button botaoConfirmar = new Button();
        botaoConfirmar.Text = "CONFIRMAR DEVOLUÇÃO";
        botaoConfirmar.Location = new Point(410, 330); // Posição Y ajustada
        botaoConfirmar.Size = new Size(300, 50);
        botaoConfirmar.Font = new Font("Arial", 16, FontStyle.Bold);
        // ... (estilos) ...
        botaoConfirmar.BackColor = Color.White;
        botaoConfirmar.ForeColor = Color.FromArgb(0, 171, 155);
        botaoConfirmar.FlatStyle = FlatStyle.Flat;
        botaoConfirmar.FlatAppearance.BorderSize = 1;
        botaoConfirmar.Click += (sender, e) => {
            
            // --- CHAMADA MODIFICADA ---
            string resultado = GerenciadorEmprestimos.RealizarDevolucao(
                campoItem.Text,
                campoNomePessoaDev.Text,
                campoCPFDev.Text
            );
            
            MessageBox.Show(resultado); // Mostra o resultado

            if (resultado.EndsWith("atualizado.")) // Limpa e volta
            {
                campoItem.Clear();
                campoNomePessoaDev.Clear();
                campoCPFDev.Clear();
                PainelDevolver.Visible = false;
                MEmprestimoPrinc.Visible = true;
            }
        };
        PainelDevolver.Controls.Add(botaoConfirmar);

        // --- Botão Voltar ---
        Button botaoVoltar = new Button();
        botaoVoltar.Text = "Voltar";
        botaoVoltar.Location = new Point(20, 20);
        // ... (estilos) ...
        botaoVoltar.Font = new Font("Arial", 12, FontStyle.Bold);
        botaoVoltar.AutoSize = true;
        botaoVoltar.FlatStyle = FlatStyle.Flat;
        botaoVoltar.FlatAppearance.BorderSize = 0;
        botaoVoltar.BackColor = Color.White;
        botaoVoltar.ForeColor = Color.FromArgb(0, 171, 155);
        botaoVoltar.Click += (sender, e) => {
            PainelDevolver.Visible = false;
            MEmprestimoPrinc.Visible = true;
        };
        PainelDevolver.Controls.Add(botaoVoltar);
    }
    public void CriarPainelVerEmprestimos() {
        
        PainelVerEmprestimos = new Panel();
        PainelVerEmprestimos.Size = this.ClientSize;
        PainelVerEmprestimos.Location = new Point(0, 0);
        PainelVerEmprestimos.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
        PainelVerEmprestimos.BackgroundImageLayout = ImageLayout.Stretch;
        PainelVerEmprestimos.Visible = false;

        // Criando o DataGridView
        tabelaEmprestimos = new DataGridView();
        tabelaEmprestimos.Location = new Point(20, 70);
        tabelaEmprestimos.Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 90);
        tabelaEmprestimos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabelaEmprestimos.ReadOnly = true;
        tabelaEmprestimos.BackgroundColor = Color.White;
        tabelaEmprestimos.ForeColor = Color.FromArgb(0, 171, 155);
        tabelaEmprestimos.DefaultCellStyle.BackColor = Color.White;
        tabelaEmprestimos.DefaultCellStyle.ForeColor = Color.FromArgb(0, 171, 155);
        tabelaEmprestimos.DefaultCellStyle.Font = new Font("Arial", 12);
        tabelaEmprestimos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        tabelaEmprestimos.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
        tabelaEmprestimos.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 171, 155);
        tabelaEmprestimos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        tabelaEmprestimos.EnableHeadersVisualStyles = false;

        PainelVerEmprestimos.Controls.Add(tabelaEmprestimos);

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
            PainelVerEmprestimos.Visible = false;
            MEmprestimoPrinc.Visible = true;
        };
        PainelVerEmprestimos.Controls.Add(botaoVoltar);
    }
    public void Adicionaritem() {
        
            adicionaritem = new Panel();
            adicionaritem.Size = this.ClientSize;
            adicionaritem.Location = new Point(0, 0);
            adicionaritem.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
            adicionaritem.BackgroundImageLayout = ImageLayout.Stretch;
            adicionaritem.Visible = false;

            Label titulo = new Label();
            titulo.Text = "Adicionar Novo Item";
            titulo.Font = new Font("Arial", 28, FontStyle.Bold);
            titulo.ForeColor = Color.FromArgb(0, 171, 155);
            titulo.AutoSize = true;
            titulo.BackColor = Color.Transparent;
            titulo.Location = new Point(380, 100);
            adicionaritem.Controls.Add(titulo);

            // --- Campos de texto ---
            TextBox txtDescricao = new TextBox();
            txtDescricao.PlaceholderText = "Descrição do Item";
            txtDescricao.Font = new Font("Arial", 14);
            txtDescricao.Location = new Point(410, 200);
            txtDescricao.Size = new Size(300, 30);
            adicionaritem.Controls.Add(txtDescricao);

            TextBox txtQuantidade = new TextBox();
            txtQuantidade.PlaceholderText = "Quantidade";
            txtQuantidade.Font = new Font("Arial", 14);
            txtQuantidade.Location = new Point(410, 250);
            txtQuantidade.Size = new Size(300, 30);
            adicionaritem.Controls.Add(txtQuantidade);

            TextBox txtMarca = new TextBox();
            txtMarca.PlaceholderText = "Marca / Modelo";
            txtMarca.Font = new Font("Arial", 14);
            txtMarca.Location = new Point(410, 300);
            txtMarca.Size = new Size(300, 30);
            adicionaritem.Controls.Add(txtMarca);

            TextBox txtLocal = new TextBox();
            txtLocal.PlaceholderText = "Local de Armazenamento";
            txtLocal.Font = new Font("Arial", 14);
            txtLocal.Location = new Point(410, 350);
            txtLocal.Size = new Size(300, 30);
            adicionaritem.Controls.Add(txtLocal);

            // --- Botão SALVAR ---
            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar Item";
            btnSalvar.Font = new Font("Arial", 16, FontStyle.Bold);
            btnSalvar.Size = new Size(250, 50);
            btnSalvar.Location = new Point(435, 420);
            btnSalvar.BackColor = Color.White;
            btnSalvar.ForeColor = Color.FromArgb(0, 171, 155);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.FlatAppearance.BorderSize = 1;

            btnSalvar.Click += (sender, e) => {
                string descricao = txtDescricao.Text;
                string marca = txtMarca.Text;
                string local = txtLocal.Text;
                int quantidade;

                if (string.IsNullOrWhiteSpace(descricao) || 
                    string.IsNullOrWhiteSpace(marca) || 
                    string.IsNullOrWhiteSpace(local) || 
                    !int.TryParse(txtQuantidade.Text, out quantidade))
                {
                    MessageBox.Show("Preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string caminho = CaminhoDoEstoque; // mesmo caminho usado no código original
                if (caminho == null) {
                    MessageBox.Show("Erro: Caminho do estoque não definido!");
                    return;
                }

                try
                {
                    using (var workbook = new XLWorkbook(caminho))
                    {
                        var ws = workbook.Worksheet(1);
                        int ultimaLinha = ws.LastRowUsed().RowNumber() + 1;
                        int novoNumero = ultimaLinha - 1;

                        ws.Cell(ultimaLinha, 1).Value = novoNumero;
                        ws.Cell(ultimaLinha, 2).Value = descricao;
                        ws.Cell(ultimaLinha, 3).Value = quantidade;
                        ws.Cell(ultimaLinha, 4).Value = marca;
                        ws.Cell(ultimaLinha, 5).Value = local;

                        workbook.Save();
                    }

                    MessageBox.Show("Item adicionado com sucesso!");
                    txtDescricao.Clear();
                    txtQuantidade.Clear();
                    txtMarca.Clear();
                    txtLocal.Clear();

                    adicionaritem.Visible = false;
                    ADM.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar: {ex.Message}");
                }
            };

            adicionaritem.Controls.Add(btnSalvar);

            // --- Botão Voltar ---
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
                adicionaritem.Visible = false;
                ADM.Visible = true;
            };
            adicionaritem.Controls.Add(botaoVoltar);

            this.Controls.Add(adicionaritem);
    }
    public void Removeritem() {
        removeritem = new Panel();
        removeritem.Size = this.ClientSize;
        removeritem.Location = new Point(0, 0);
        removeritem.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
        removeritem.BackgroundImageLayout = ImageLayout.Stretch;
        removeritem.Visible = false;

        Label titulo = new Label();
        titulo.Text = "Remover Item do Estoque";
        titulo.Font = new Font("Arial", 28, FontStyle.Bold);
        titulo.ForeColor = Color.FromArgb(0, 171, 155);
        titulo.AutoSize = true;
        titulo.BackColor = Color.Transparent;
        titulo.Location = new Point(350, 100);
        removeritem.Controls.Add(titulo);

        TextBox txtID = new TextBox();
        txtID.PlaceholderText = "Número do Item (ID)";
        txtID.Font = new Font("Arial", 14);
        txtID.Location = new Point(410, 220);
        txtID.Size = new Size(300, 30);
        removeritem.Controls.Add(txtID);

        Button btnRemover = new Button();
        btnRemover.Text = "Remover";
        btnRemover.Font = new Font("Arial", 16, FontStyle.Bold);
        btnRemover.Size = new Size(200, 50);
        btnRemover.Location = new Point(460, 280);
        btnRemover.BackColor = Color.Red;
        btnRemover.ForeColor = Color.White;
        btnRemover.FlatStyle = FlatStyle.Flat;
        btnRemover.FlatAppearance.BorderSize = 0;

        btnRemover.Click += (sender, e) => {
            if (!int.TryParse(txtID.Text, out int id)) {
                MessageBox.Show("Digite um número de item válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string caminho = CaminhoDoEstoque;
            
            if (caminho == null) {
                MessageBox.Show("Erro: Caminho do estoque não definido!");
                return;
            }

            try
            {
                using (var wb = new XLWorkbook(caminho))
                {
                    var ws = wb.Worksheet(1);

                    bool achou = false;
                    for (int i = 2; i <= ws.LastRowUsed().RowNumber(); i++)
                    {
                        if (ws.Cell(i, 1).GetValue<int>() == id)
                        {
                            ws.Row(i).Delete();
                            achou = true;
                            break;
                        }
                    }

                    if (achou)
                    {
                        wb.Save();
                        MessageBox.Show("Item removido com sucesso!");
                        txtID.Clear();
                        removeritem.Visible = false;
                        ADM.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("ID não encontrado!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        };

        removeritem.Controls.Add(btnRemover);

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
            removeritem.Visible = false;
            ADM.Visible = true;
        };
        removeritem.Controls.Add(botaoVoltar);

        this.Controls.Add(removeritem);
    }

    // Método de clique do botão
    private void BtnRemover_Click(object sender, EventArgs e)
    {
        // Aqui você pode colocar a lógica para remover o item desejado
        MessageBox.Show("Item removido com sucesso!", "Remoção", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Oculta o painel após a ação
        removeritem.Visible = false;
    }

    public void AdicionarProduto() {
        // Criação do painel
        adicionarproduto = new Panel();
        adicionarproduto.Size = this.ClientSize;
        adicionarproduto.Location = new Point(0, 0);
        adicionarproduto.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoTelaPadrao.png");
        adicionarproduto.BackgroundImageLayout = ImageLayout.Stretch;
        adicionarproduto.Visible = true; // Tornar visível para testar

        // Label e TextBox para o nome do produto
        Label lblNome = new Label();
        lblNome.Text = "Nome do Produto:";
        lblNome.Location = new Point(50, 50);
        lblNome.AutoSize = true;

        TextBox txtNome = new TextBox();
        txtNome.Location = new Point(200, 50);
        txtNome.Width = 200;

        // Label e TextBox para o preço do produto
        Label lblPreco = new Label();
        lblPreco.Text = "Preço:";
        lblPreco.Location = new Point(50, 100);
        lblPreco.AutoSize = true;

        TextBox txtPreco = new TextBox();
        txtPreco.Location = new Point(200, 100);
        txtPreco.Width = 100;

        // Botão salvar
        Button btnSalvar = new Button();
        btnSalvar.Text = "Salvar";
        btnSalvar.Size = new Size(100, 30);
        btnSalvar.Location = new Point(200, 150);

        // Evento do botão
        btnSalvar.Click += (s, e) => {
            string nome = txtNome.Text;
            string precoTexto = txtPreco.Text;

            // Validação simples
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(precoTexto))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (!decimal.TryParse(precoTexto, out decimal preco))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            // Aqui você pode adicionar o produto a uma lista, banco de dados, etc.
            MessageBox.Show($"Produto salvo:\nNome: {nome}\nPreço: {preco:C}");
        };

        // Adiciona os controles ao painel
        adicionarproduto.Controls.Add(lblNome);
        adicionarproduto.Controls.Add(txtNome);
        adicionarproduto.Controls.Add(lblPreco);
        adicionarproduto.Controls.Add(txtPreco);
        adicionarproduto.Controls.Add(btnSalvar);

        // Adiciona o painel ao formulário
        this.Controls.Add(adicionarproduto);
    }
}

