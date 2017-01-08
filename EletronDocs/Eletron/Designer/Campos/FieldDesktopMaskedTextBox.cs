using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eletron.Designer.Campos
{
    class FieldDesktopMaskedTextBox: MaskedTextBox, IFieldDesktop
    {
        public bool Obrigatorio { get; set; }
        public FieldDesktopMaskedTextBox(string mask)
            : base(mask)
        {

        }
    }
}
