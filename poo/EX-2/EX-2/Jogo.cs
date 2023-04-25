
namespace EX_2
{
    public class Jogo
    {

        private int _codigo;
        private string _nome;
        private string _categoria;
        private DateTime _dataLancamento;

        public int GetCodigo() => _codigo;
        public void SetCodigo(int codigo)
        {
            if (!(codigo > 0))
                throw new Exception("O código deve ser maior que 0.");

            this._codigo = codigo;
        }

        public string GetNome() => _nome;
        public void SetNome(string nome)
        {
            if (!(nome.Length > 0))
                throw new Exception("O nome não pode conter apenas espaços.");

            this._nome = nome;
        }

        public string GetCategoria() => _categoria;
        public void SetCategoria(string categoria) => this._categoria = categoria;

        public DateTime GetDataLancamento() => _dataLancamento;
        public void SetDataLancamento(DateTime data)
        {
            if (data > DateTime.Now)
                throw new Exception("Pessoa nem nasceu...");

            this._dataLancamento = data;
        }
    }
}
