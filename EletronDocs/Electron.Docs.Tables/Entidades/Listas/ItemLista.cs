using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electron.Docs.Tables.Entidades.Listas
{
    public class ItemLista
    {
        public object Valor { get; set; }
        public string Descricao { get; set; }

        public ItemLista(object valor, string descricao)
        {
            Valor = valor;
            Descricao = descricao;
        }
        public ItemLista(string descricao)
            : this(descricao, descricao)
        {

        }
    }
}
