namespace EX_1;

public class Program
{
    private static void Main(string[] args)
    {
        Jogo jogo = new Jogo();

        jogo.SetCodigo(1);
        jogo.SetNome("Call Of Dutty: Black Ops 2");
        jogo.SetCategoria("Ação e FPS");
        jogo.SetDataLancamento(new DateTime(2013, 09, 13));

        Console.WriteLine(jogo.GetCodigo());
        Console.WriteLine(jogo.GetNome());
        Console.WriteLine(jogo.GetCategoria());
        Console.WriteLine(jogo.GetDataLancamento().ToString());
    }
}