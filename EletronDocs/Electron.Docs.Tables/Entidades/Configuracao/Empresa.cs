using Electron.Docs.Tables.Designer.Atributos;
using System.Collections.Generic;
using System.Reflection;

namespace Electron.Docs.Tables.Entidades.Configuracao
{

    public partial class Empresa 
    {

      
    }

    public class CamposTela
    {
        public string Nome { get; set; }
        public CampoTelaAttribute Atributo { get; set; }
    }
}
