using Electron.Docs.Tables.Designer;
using Electron.Docs.Tables.Designer.Atributos;
using System.Collections.Generic;
using System.Reflection;

namespace Electron.Docs.Tables.Entidades
{
    public abstract class Tabela<T> : ITabela where T : new()
    {
        [CampoTabela]
        public int Id { get; set; }
        
        protected DBhelperClass Db = new DBhelperClass();

        public void Save()
        {
            Db.SalvarTabela(this);
        }

        public PropertyInfo[] GetProperties()
        {
            return GetType().GetProperties();
        }

        public void SetPropertyValue(string propertyName, object value)
        {
            GetType().GetProperty(propertyName).SetValue(this, value);
        }

        public object GetPropertyValue(string propertyName)
        {
            return GetType().GetProperty(propertyName).GetValue(this);
        }

        public List<CamposTela> BuscarCamposTela()
        {
            var camposTela = new List<CamposTela>();


            foreach (var prop in GetProperties())
            {
                var attrs = prop.GetCustomAttributes(true);
                foreach (var attr in attrs)
                {
                    var authAttr = attr as CampoTelaAttribute;
                    if (authAttr == null) continue;

                    var propName = prop.Name;
                    camposTela.Add(new CamposTela
                    {
                        Nome = propName,
                        Atributo = authAttr
                    });
                }
            }

            return camposTela;
        }

        public List<T> GetAll()
        {
            return Db.GetAll<T>();
        }

        public void Delete()
        {
            Db.Delete(this);
        }



        //public void SetPropertyValue(string p1, string p2)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
