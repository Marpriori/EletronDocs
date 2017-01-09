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
    }

    public class Listas
    {
        public static List<ItemLista> Estados = new List<ItemLista>(){
            new ItemLista(12, "AC"),
            new ItemLista(27, "AL"),
            new ItemLista(13, "AM"),
            new ItemLista(16, "AP"),
            new ItemLista(29, "BA"),
            new ItemLista(23, "CE"),
            new ItemLista(53, "DF"),
            new ItemLista(32, "ES"),
            new ItemLista(52, "GO"),
            new ItemLista(21, "MA"),
            new ItemLista(31, "MG"),
            new ItemLista(50, "MS"),
            new ItemLista(51, "MT"),
            new ItemLista(15, "PA"),
            new ItemLista(25, "PB"),
            new ItemLista(26, "PE"),
            new ItemLista(22, "PI"),
            new ItemLista(41, "PR"),
            new ItemLista(33, "RJ"),
            new ItemLista(24, "RN"),
            new ItemLista(11, "RO"),
            new ItemLista(14, "RR"),
            new ItemLista(43, "RS"),
            new ItemLista(42, "SC"),
            new ItemLista(28, "SE"),
            new ItemLista(35, "SP"),
            new ItemLista(17, "TO")
        };

    }
}
