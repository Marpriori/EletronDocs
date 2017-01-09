using Electron.Docs.Tables.Designer;
using Electron.Docs.Tables.Designer.Atributos;
using Electron.Docs.Tables.Entidades.Configuracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Electron.Docs.Tables.Entidades
{
    public abstract class Tabela<T> : ITabela where T : new()
    {
        [CampoTabela]
        public int Id { get; set; }
        
        protected DBhelperClass db = new DBhelperClass();

        public void Save()
        {
            db.SalvarTabela(this);
        }

        public PropertyInfo[] GetProperties()
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


            foreach (PropertyInfo prop in GetProperties())
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

        public List<T> GetAll()
        {
            return db.GetAll<T>();
        }
   
    }
}
