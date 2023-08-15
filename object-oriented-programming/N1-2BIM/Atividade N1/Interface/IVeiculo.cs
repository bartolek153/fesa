namespace Atividade_N1.Interface
{
    public interface IVeiculo
    {
        int VelocidadeAtual { get; set; }
        int Capacidade { get; set; }
        string Id { get; set; }
        int Peso { get; set; }
        Modelo Modelo { get; set; }
        void Acelerar();
        void Desacelerar();
    }
}
