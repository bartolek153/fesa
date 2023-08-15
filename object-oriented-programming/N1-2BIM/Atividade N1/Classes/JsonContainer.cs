using Atividade_N1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using Atividade_N1.Properties;

namespace Atividade_N1
{
    public class JsonContainer
    {
        public List<IVeiculo> Veiculos { get; set; }
        public List<Marca> Marcas { get; set; }
        public List<Modelo> Modelos { get; set; }

        public JsonContainer() { }

        public JsonContainer(List<IVeiculo> veiculos, List<Marca> marcas, List<Modelo> modelos)
        {
            this.Veiculos = veiculos;
            this.Marcas = marcas;
            this.Modelos = modelos;
        }

        private static bool ValidacaoJsonExiste()
        {
            if (File.Exists("dados.json"))
                return true;
                 
            MessageBox.Show("Não existem dados persistidos em 'dados.json'.");
            return false;
        }

        public void Salvar()
        {
            try
            {
                string json = JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                });
                File.WriteAllText("dados.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static JsonContainer CarregarDados()
        {
            try
            {
                if (ValidacaoJsonExiste())
                {
                    string json = File.ReadAllText("dados.json");
                    return JsonConvert.DeserializeObject<JsonContainer>(json, new JsonSerializerSettings {
                        TypeNameHandling = TypeNameHandling.All,
                        TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple
                    });
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void Exibir()
        {
            if (ValidacaoJsonExiste())
            {
                Process.Start("notepad.exe", "dados.json");
            }
        }
    }
}
