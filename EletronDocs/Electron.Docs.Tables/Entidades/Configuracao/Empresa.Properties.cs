using Electron.Docs.Tables.Designer.Atributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electron.Docs.Tables.Entidades.Configuracao
{
    public partial class Empresa : Tabela<Empresa>
    {
        private const string TABGERAL = "Geral";
        private const string TABENDERECO = "Endereço";

        [CampoTabela]
        [CampoTela(TABGERAL, "CNPJ", Mascara = "00.000.000/0000-00", Tamanho = 150)]
        public string Cnpj { get; set; }

        [CampoTabela]
        [CampoTela(TABGERAL, "Inscrição Estadual", Tamanho = 150)]
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
        [CampoTela(TABENDERECO, "Número", Tamanho = 50)]
        public string Numero { get; set; }

        [CampoTabela]
        [CampoTela(TABENDERECO, "Complemento")]
        public string Complemento { get; set; }

        [CampoTabela]
        [CampoTela(TABENDERECO, "Bairro")]
        public string Bairro { get; set; }

        [CampoTabela]
        [CampoTela(TABENDERECO, "CEP", Mascara = "00000-000", Tamanho = 100)]
        public string Cep { get; set; }

        [CampoTabela]
        [CampoTela(TABENDERECO, "Município", Tamanho = 200)]
        public string Municipio { get; set; }

        [CampoTabela]
        [CampoTela(TABENDERECO, "Estado", Tamanho = 200)]
        public string Estado { get; set; }

    }
}
