namespace EX_2;

public class Program
{
    static void Main(string[] args)
    {
        Jogo[] vetor = new Jogo[10];

        for (int i = 0; i < vetor.Length; i++)
        {
            Jogo jogo = new Jogo();
            jogo = CadastrarJogo(jogo);

            Console.WriteLine("Deseja continuar? <S/N>: ");
            if (Console.ReadLine().ToUpper() == "N")
                break;
        }
    }

    public static Jogo CadastrarJogo(Jogo j)
    {
        do
        {
            try
            {
                Console.WriteLine("Digite o código do jogo:");
                j.SetCodigo(Convert.ToInt32(Console.ReadLine()));
                break;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Digite um número menor!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite apenas números inteiros!");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
        while (true);

        do
        {
            try
            {
                Console.WriteLine("Digite o nome do jogo: ");
                j.SetNome(Console.ReadLine());
                break;
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
        while (true);

        do
        {
            try
            {

                Console.WriteLine("Digite a categoria do jogo: ");
                j.SetCategoria(Console.ReadLine());
                break;
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
        while (true);

        do
        {
            try
            {
                Console.WriteLine("Digite a data de lançamento do jogo: ");
                j.SetDataLancamento(Convert.ToDateTime(Console.ReadLine()));
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite uma data válida!!!");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
        while (true);

        return j;
    }
}