namespace EX_3;

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
                f.SetCodigo(int.Parse(Console.ReadLine()));
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
                f.SetNome(Console.ReadLine());
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
                f.SetRG(Console.ReadLine());
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
                f.SetSalario(double.Parse(Console.ReadLine()));
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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