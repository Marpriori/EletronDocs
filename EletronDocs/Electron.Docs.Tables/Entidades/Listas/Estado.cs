using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electron.Docs.Tables.Entidades.Listas
{

    public class Estado : ICampoLista
    {
        public List<ItemLista> Lista { get; set; }
        public Estado()
        {
            Lista = new List<ItemLista>(){
            new ItemLista("AC"),
            new ItemLista("AL"),
            new ItemLista("AM"),
            new ItemLista("AP"),
            new ItemLista("BA"),
            new ItemLista("CE"),
            new ItemLista("DF"),
            new ItemLista("ES"),
            new ItemLista("GO"),
            new ItemLista("MA"),
            new ItemLista("MG"),
            new ItemLista("MS"),
            new ItemLista("MT"),
            new ItemLista("PA"),
            new ItemLista("PB"),
            new ItemLista("PE"),
            new ItemLista("PI"),
            new ItemLista("PR"),
            new ItemLista("RJ"),
            new ItemLista("RN"),
            new ItemLista("RO"),
            new ItemLista("RR"),
            new ItemLista("RS"),
            new ItemLista("SC"),
            new ItemLista("SE"),
            new ItemLista("SP"),
            new ItemLista("TO")
        };
        }
        public static List<ItemLista> EstadosIbge = new List<ItemLista>(){
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
