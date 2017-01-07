using Electron.Docs.Tables.Designer.Atributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Electron.Docs.Tables.Entidades
{
    public abstract class Tabela: ITabela
    {
        [CampoTabela]
        public int Id { get; set; }

        public void Save()
        {
            DBhelperClass db = new DBhelperClass();
            db.SalvarTabela(this);
        }

        public PropertyInfo[] GetCampos()
        {
            return this.GetType().GetProperties();
        }
    }
}
