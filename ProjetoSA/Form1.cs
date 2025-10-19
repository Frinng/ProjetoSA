namespace ProjetoSA;

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
        
        
        

    }
}