namespace ProjetoSA;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public partial class Formprinciapl : Form {
    public Formprinciapl() {
        InitializeComponent();

        //Configuracoes do forms
        
        this.Text = "Menu Principal";
        this.Width = 1000;
        this.Height = 700;
        
            //Limito o tamnho da tela
        this.Size = new System.Drawing.Size(1000,700);

            //impede o redimensionamento
        this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //impede o usuario de maximar a tela
        this.MaximizeBox = false;

            //Centraliza a janela na tela
        this.StartPosition = FormStartPosition.CenterScreen;

        this.BackgroundImage = Image.FromFile(@"..\..\..\Recursos\FundoDeTela.png");
        this.BackgroundImageLayout = ImageLayout.Stretch;
        
        //INICIO DO CODIGO
        
            //LAbel falando Bem Vindo
        Label TextoOlaAmigo = new Label();
        TextoOlaAmigo.Text = "Olá, Amigo!";
        TextoOlaAmigo.Location = new Point(650, 200);//Define a posicao horizontal(vulgo X) do label dentro do forms e a posicao vertical(vulgo Y) do label dentro do forms
        TextoOlaAmigo.AutoSize = true;
        TextoOlaAmigo.Font = new Font("Arial",24, FontStyle.Bold);
        TextoOlaAmigo.ForeColor = Color.White;
        TextoOlaAmigo.BackColor = Color.Transparent; //Deixa o fundo transparente
        this.Controls.Add(TextoOlaAmigo); // obviamente adiciona o label

            //Label do insira detalhes
        Label InsiraDetalhes = new Label();
        InsiraDetalhes.Text = "Insira alguns Detalhes e comece sua jornada";
        InsiraDetalhes.Location = new Point(590,240);
        InsiraDetalhes.AutoSize = true;
        InsiraDetalhes.Font = new Font("Arial", 10, FontStyle.Bold);
        InsiraDetalhes.ForeColor = Color.White;
        InsiraDetalhes.BackColor = Color.Transparent;
        this.Controls.Add(InsiraDetalhes);
        
            //COntinuacao do insira detalhes
        Label Conosco = new Label();
        Conosco.Text = "conosco.";
        Conosco.Location = new Point(710, 260);
        Conosco.AutoSize = true;
        Conosco.Font = new Font("Arial", 10, FontStyle.Bold);
        Conosco.ForeColor = Color.White;
        Conosco.BackColor = Color.Transparent;
        this.Controls.Add(Conosco);
        
            //Botao do Registrar
        Button BotaoRegistrar = new Button();
        BotaoRegistrar.Text = "REGISTRAR";
        BotaoRegistrar.AutoSize = true;
        BotaoRegistrar.Location = new Point(650, 290);
        BotaoRegistrar.Font = new Font("Arial",20,FontStyle.Bold);
        BotaoRegistrar.ForeColor = Color.White;
        BotaoRegistrar.BackColor = Color.FromArgb(0, 171, 155);
        BotaoRegistrar.FlatStyle = FlatStyle.Flat; //tira a borda azul quando o mouse passa por cima
        BotaoRegistrar.FlatAppearance.BorderColor = Color.White;
        BotaoRegistrar.FlatAppearance.BorderSize = 1;
        BotaoRegistrar.Click += (sender, e) => { }; //quando clicam no botao o ponteiro manda para a funcao
        this.Controls.Add(BotaoRegistrar);

            //Entrar no sistema
        Label Entrar_NoSistema = new Label();
        Entrar_NoSistema.Text = "ENTRAR NO SISTEMA";
        Entrar_NoSistema.Left = 70;
        Entrar_NoSistema.Top = 200;
        Entrar_NoSistema.AutoSize = true;
        Entrar_NoSistema.Font = new Font("Arial",24,FontStyle.Bold);
        Entrar_NoSistema.ForeColor =  Color.FromArgb(0, 171, 155);
        Entrar_NoSistema.BackColor = Color.Transparent;
        this.Controls.Add(Entrar_NoSistema);
        
            //Campo de texto
        TextBox CampoUsuario = new TextBox();
        CampoUsuario.Name = "campousuario";
        CampoUsuario.Location = new Point(120, 280);
        CampoUsuario.Size = new Size(250, 30);
        CampoUsuario.Font = new Font("Arial", 20);
        CampoUsuario.PlaceholderText = "Usuário";
        CampoUsuario.TextAlign = HorizontalAlignment.Center;
        this.Controls.Add(CampoUsuario);
        
            //campodetexto senha
        TextBox CampoSenha = new TextBox();
        CampoSenha.Name = "camposenha";
        CampoSenha.Location = new Point(120, 330);
        CampoSenha.Size = new Size(250, 30);
        CampoSenha.Font = new Font("Arial", 20);
        CampoSenha.PlaceholderText = "Senha";
        CampoSenha.TextAlign = HorizontalAlignment.Center;
        this.Controls.Add(CampoSenha);
        
            //Botao do esqueceu sua senha
        Button BotaoEsqueceuSenha = new Button();
        BotaoEsqueceuSenha.Text = "Esqueceu sua senha?";
        BotaoEsqueceuSenha.Location = new Point(160, 380);
        BotaoEsqueceuSenha.AutoSize = true;
        BotaoEsqueceuSenha.Font = new Font("Arial", 10, FontStyle.Bold);
        BotaoEsqueceuSenha.ForeColor = Color.FromArgb(0, 171, 155);
        BotaoEsqueceuSenha.BackColor = Color.White;
        BotaoEsqueceuSenha.FlatStyle = FlatStyle.Flat;
        BotaoEsqueceuSenha.FlatAppearance.BorderColor = Color.White;
        BotaoEsqueceuSenha.Click += (sender, e) => { };
        this.Controls.Add(BotaoEsqueceuSenha);

        //Botao entrar
        Button BotaoEntrar = new Button();
        BotaoEntrar.Text = "ENTRAR";
        BotaoEntrar.AutoSize = true;
        BotaoEntrar.Location = new Point(175, 410);
        BotaoEntrar.Font = new Font("Arial", 20, FontStyle.Bold);
        BotaoEntrar.ForeColor = Color.FromArgb(0, 171, 155);
        BotaoEntrar.FlatStyle = FlatStyle.Flat;
        BotaoEntrar.FlatAppearance.BorderColor = Color.FromArgb(0, 171, 155);
        BotaoEntrar.BackColor = Color.White;
        BotaoEntrar.FlatAppearance.BorderSize = 1;
        BotaoEntrar.Click += (sender, e) => { };
        this.Controls.Add(BotaoEntrar);
    }
}