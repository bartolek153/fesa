namespace EX_11;

public class ContaCorrente
{
    public int Agencia { get; set; }
    private string NumeroConta { get; set; }
    public string NomeTitular { get; set; }
    public double Saldo { get; private set; }

    public ContaCorrente(int agencia, string numeroConta, string nomeTitular, double saldo)
    {
        Agencia = agencia;
        NumeroConta = numeroConta;
        NomeTitular = nomeTitular;
        Saldo = saldo;
    }

    public void Saque(double valor) => this.Saldo -= valor;

    public void Deposito(double valor) => this.Saldo += valor;
}

public class Program
{
    static void Main(string[] args)
    {
        ContaCorrente cc = new ContaCorrente(1, "asdf", "Luiz", 0);
        cc.Deposito(10.00);
        cc.Saque(20.00);
        
        Console.WriteLine(cc.Saldo);
    }
}