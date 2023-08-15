namespace EX_5;

public class Program
{
    static void Main(string[] args)
    {
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
            catch(Exception ex)
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
    }
}