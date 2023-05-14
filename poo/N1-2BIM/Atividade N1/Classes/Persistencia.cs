using System;
using System.Diagnostics;
using System.IO;

namespace Atividade_N1.Classes
{
    public class Persistencia
    {
        private string arquivoMarcas = "marcas.json";
        private string arquivoVeiculos = "veiculos.json";
        private string arquivoModelos = "modelos.json";

        public void Gravar<T>()
        {
            // 
        }

        public void Ler(bool executarNotePad = false)
        {
            if (File.Exists(_caminho))
            {
                // Ler o arquivo
                string json = JsonConvert.DeserializeObject(File.ReadAllText(_caminho));
            }
        }

        public void Exibir()
        {
            Process.Start("notepad.exe", _caminho);
        }
    }
}