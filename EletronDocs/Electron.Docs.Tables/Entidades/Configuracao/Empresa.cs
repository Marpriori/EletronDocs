using Electron.Docs.Tables.Designer.Atributos;
using System.Collections.Generic;
using System.Reflection;

namespace Electron.Docs.Tables.Entidades.Configuracao
{

    public class Empresa
    {
        private const string TABGERAL = "Geral";
        private const string TABENDERECO = "Endereço";

        [CampoTela(TABGERAL, "ID")]
        public int Id { get; set; }
        [CampoTela(TABGERAL, "CNPJ")]
        public string Cnpj { get; set; }
        [CampoTela(TABGERAL, "Inscrição Estadual")]
        public string InscricaoEstadual { get; set; }
        [CampoTela(TABGERAL, "Razão Social")]
        public string RazaoSocial { get; set; }
        [CampoTela(TABGERAL, "Nome Fantasia")]
        public string Fantasia { get; set; }

        [CampoTela(TABENDERECO, "Logradouro")]
        public string Logradouro { get; set; }

        [CampoTela(TABENDERECO, "Número")]
        public string Numero { get; set; }

        [CampoTela(TABENDERECO, "Complemento")]
        public string Complemento { get; set; }

        [CampoTela(TABENDERECO, "Bairro")]
        public string Bairro { get; set; }

        [CampoTela(TABENDERECO, "CEP")]
        public string Cep { get; set; }

        [CampoTela(TABENDERECO, "Município")]
        public string Municipio { get; set; }

        [CampoTela(TABENDERECO, "Estado")]
        public string Estado { get; set; }

        public PropertyInfo[] GetCampos()
        {
            return typeof(Empresa).GetProperties();
        }

        public List<CamposTela> GetDescricao()
        {
            var camposTela = new List<CamposTela>();


            foreach (PropertyInfo prop in GetCampos())
            {
                object[] attrs = prop.GetCustomAttributes(true);
                foreach (object attr in attrs)
                {
                    CampoTelaAttribute authAttr = attr as CampoTelaAttribute;
                    if (authAttr != null)
                    {
                        string propName = prop.Name;
                        camposTela.Add(new CamposTela()
                        {
                            Nome = propName,
                            Atributo = authAttr
                        });
                    }
                }
            }

            return camposTela;
        }
    }

    public class CamposTela
    {
        public string Nome { get; set; }
        public CampoTelaAttribute Atributo { get; set; }
    }
}
