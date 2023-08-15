namespace EX_9;

public class Program
{
    static void Main(string[] args)
    {
        Funcionario f;

        while (true)
        {
            try
            {
                Console.Write("Código: ");
                bool valido = int.TryParse(Console.ReadLine(), out int codigo);

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("RG: ");
                string rg = Console.ReadLine();

                Console.Write("Salario: ");
                bool salalario_valido = double.TryParse(Console.ReadLine(), out double salario);


                f = new Funcionario(codigo, nome, rg, salario);
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Refaça o cadastro... ");
            }
        }

        Console.WriteLine("Pressione [R] para revelar os dados cadastrados.");
        while (Console.ReadKey(true).Key != ConsoleKey.R) { }

        Console.WriteLine(f.GetCodigo());
        Console.WriteLine(f.GetNome());
        Console.WriteLine(f.GetRG());
        Console.WriteLine(f.GetSalario());
        Console.WriteLine(f.CalculaSalario());

    }
}