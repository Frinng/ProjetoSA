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
        TextoOlaAmigo.Left = 650; //Define a posicao horizontal(vulgo X) do label dentro do forms
        TextoOlaAmigo.Top = 260; //Define a posicao vertical(vulgo Y) do label dentro do forms
        TextoOlaAmigo.AutoSize = true;
        TextoOlaAmigo.Font = new Font("Arial",24, FontStyle.Bold);
        TextoOlaAmigo.ForeColor = Color.White;
        TextoOlaAmigo.BackColor = Color.Transparent; //Deixa o fundo transparente
        this.Controls.Add(TextoOlaAmigo); // obviamente adiciona o label

        //Label do insira detalhes
        Label InsiraDetalhes = new Label();
        InsiraDetalhes.Text = "Insira alguns Detalhes e comece sua jornada";
        InsiraDetalhes.Left = 590;
        InsiraDetalhes.Top = 300;
        InsiraDetalhes.AutoSize = true;
        InsiraDetalhes.Font = new Font("Arial", 10, FontStyle.Bold);
        InsiraDetalhes.ForeColor = Color.White;
        InsiraDetalhes.BackColor = Color.Transparent;
        this.Controls.Add(InsiraDetalhes);
        
        //COntinuacao do insira detalhes
        Label Conosco = new Label();
        Conosco.Text = "conosco.";
        Conosco.Left = 710;
        Conosco.Top = 315;
        Conosco.AutoSize = true;
        Conosco.Font = new Font("Arial", 10, FontStyle.Bold);
        Conosco.ForeColor = Color.White;
        Conosco.BackColor = Color.Transparent;
        this.Controls.Add(Conosco);
        
        //Botao do Registrar
        Button BotaoRegistrar = new Button();
        BotaoRegistrar.Text = "REGISTRAR";
        BotaoRegistrar.AutoSize = true;
        BotaoRegistrar.Left = 650;
        BotaoRegistrar.Top = 350;
        BotaoRegistrar.Font = new Font("Arial",20,FontStyle.Bold);
        BotaoRegistrar.ForeColor = Color.White;
        BotaoRegistrar.BackColor = Color.FromArgb(0, 171, 155);
        BotaoRegistrar.FlatStyle = FlatStyle.Flat; //tira a borda azul quando o mouse passa por cima
        BotaoRegistrar.FlatAppearance.BorderSize = 0; //tira a bora azul quando o mouse passa por cima
        BotaoRegistrar.Click += (sender, e) => { }; //quando clicam no botao o ponteiro manda para a funcao
        this.Controls.Add(BotaoRegistrar);
        
        
        
    }
    
}