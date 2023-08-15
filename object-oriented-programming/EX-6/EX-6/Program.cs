namespace EX_6;

public class Program
{
    static void Main(string[] args)
    {
        Aluno[] alunos = new Aluno[10];

        for (int i = 0; i < 10; i++)
        {
            Aluno aux = CadastraAluno();
            alunos[i] = aux;
        }

        Console.WriteLine("A lista de alunos foi preenchida completamente");
    }

    public static Aluno CadastraAluno()
    {
        Console.WriteLine("--cadastro de novo aluno--");
        Aluno a = new Aluno();

        while (true)
        {
            try
            {
                Console.WriteLine("Nome: ");
                a.Nome = Console.ReadLine();
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        while (true)
        {
            try
            {
                Console.WriteLine("Nota 1: ");
                a.Nota1 = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        while (true)
        {
            try
            {
                Console.WriteLine("Nota 2: ");
                a.Nota2 = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine("Pressione [R] para revelar os dados cadastrados.\n");
        while (Console.ReadKey(true).Key != ConsoleKey.R) { }


        Console.WriteLine(a.Nome);
        Console.WriteLine(a.Nota1);
        Console.WriteLine(a.Nota2);
        Console.WriteLine(a.Media);

        return a;
    }
}