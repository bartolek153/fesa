namespace EX_7;

public class Program
{
    public static int Soma(int i1, int i2) => i1+ i2;

    public static double Soma(double d1, double d2) => d1 + d2;

    public static double Soma(string s1, string s2)
    {
        var soma = double.Parse(s1) + double.Parse(s2);
        return soma;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Soma(1, 2));
        Console.WriteLine(Soma(0.1, 0.2));
        Console.WriteLine(Soma("10", "20"));
    }
}