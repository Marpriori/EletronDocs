using Electron.Docs.Tables.Entidades.Listas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eletron.Designer.Campos
{
    class FieldDesktopComboBox: ComboBox, IFieldDesktop
    {
        public bool Obrigatorio { get; set; }

        public FieldDesktopComboBox(List<ItemLista> lista)
            :this(lista, null)
        {

        }
        public FieldDesktopComboBox(List<ItemLista> lista, object selectedValue)
        {
            Items.AddRange(lista.ToArray());
            ValueMember = "Valor";
            DisplayMember = "Descricao";
            DropDownStyle = ComboBoxStyle.DropDownList;

            if (selectedValue == null) return;

            var selecionado = lista.FirstOrDefault(item => item.Valor == selectedValue);
            if(selecionado != null)
                SelectedIndex = FindStringExact(selecionado.Descricao);
        }
    }
}
