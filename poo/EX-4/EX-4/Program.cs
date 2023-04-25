namespace EX_4;

public class Program
{
    static void Main(string[] args)
    {
        Funcionario f = new Funcionario();


        Console.Write("Código: ");
        while (true)
        {
            try
            {
                f.Codigo = (Convert.ToInt32(Console.ReadLine()));
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        Console.Write("Nome: ");
        while (true)
        {
            try
            {
                f.Nome = (Console.ReadLine());
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        Console.Write("RG: ");
        while (true)
        {
            try
            {
                f.Rg = (Console.ReadLine());
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        Console.Write("Salário: ");
        while (true)
        {
            try
            {
                f.Salario = (double.Parse(Console.ReadLine()));
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        Console.WriteLine("Pressione [R] para revelar os dados cadastrados.\n");
        while (Console.ReadKey(true).Key != ConsoleKey.R) { }

        Console.WriteLine(f.Codigo);
        Console.WriteLine(f.Nome);
        Console.WriteLine(f.Rg);
        Console.WriteLine(f.Salario);
        Console.WriteLine(f.CalculaSalario());

    }
}