using Electron.Docs.Tables.Designer.Atributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Electron.Docs.Tables.Entidades
{
    public abstract class Tabela : ITabela
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
}
