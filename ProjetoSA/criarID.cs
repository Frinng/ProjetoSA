namespace ProjetoSA;

public static class criarID {
    
    private static readonly Random CriarID = new Random();

    public static int GerarID() {
        return CriarID.Next( 1111,10000);
    }
}