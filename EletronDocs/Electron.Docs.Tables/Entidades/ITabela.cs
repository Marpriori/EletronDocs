using Electron.Docs.Tables.Designer;
using System.Collections.Generic;

namespace Electron.Docs.Tables.Entidades
{
    public interface ITabela
    {
        List<CamposTela> BuscarCamposTela();

        void SetPropertyValue(string propertyName, object value);
        object GetPropertyValue(string propertyName);
        void Save();
    }
}
