namespace ProjetoSA;

public partial class Form1 : Form
{
    public Form1() {
        InitializeComponent();
        
        //Limito o tamnho da tela
        this.Size = new System.Drawing.Size(1000,700);

        //impede o redimensionamento
        this.FormBorderStyle = FormBorderStyle.FixedSingle;

        //impede o usuario de maximar a tela
        this.MaximizeBox = false;

        //Centraliza a janela na tela
        this.StartPosition = FormStartPosition.CenterScreen;
    }
}