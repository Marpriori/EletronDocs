using Electron.Docs.Tables.Designer.Atributos;
using System.Collections.Generic;
using System.Reflection;

namespace Electron.Docs.Tables.Entidades.Configuracao
{

    public class Empresa : Tabela
    {
        private const string TABGERAL = "Geral";
        private const string TABENDERECO = "Endereço";

        [CampoTabela]
        [CampoTela(TABGERAL, "CNPJ")]
        public string Cnpj { get; set; }

        [CampoTabela]
        [CampoTela(TABGERAL, "Inscrição Estadual")]
        public string InscricaoEstadual { get; set; }

        [CampoTabela]
        [CampoTela(TABGERAL, "Razão Social")]
        public string RazaoSocial { get; set; }

        [CampoTabela]
        [CampoTela(TABGERAL, "Nome Fantasia")]
        public string Fantasia { get; set; }

        [CampoTabela]
        [CampoTela(TABENDERECO, "Logradouro")]
        public string Logradouro { get; set; }

        [CampoTabela]
        [CampoTela(TABENDERECO, "Número")]
        public string Numero { get; set; }

        [CampoTabela]
        [CampoTela(TABENDERECO, "Complemento")]
        public string Complemento { get; set; }

        [CampoTabela]
        [CampoTela(TABENDERECO, "Bairro")]
        public string Bairro { get; set; }

        [CampoTabela]
        [CampoTela(TABENDERECO, "CEP")]
        public string Cep { get; set; }

        [CampoTabela]
        [CampoTela(TABENDERECO, "Município")]
        public string Municipio { get; set; }

        [CampoTabela]
        [CampoTela(TABENDERECO, "Estado")]
        public string Estado { get; set; }



        public void SetPropertyValue(string propertyName, object value)
        {
            typeof(Empresa).GetProperty(propertyName).SetValue(this, value);
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
