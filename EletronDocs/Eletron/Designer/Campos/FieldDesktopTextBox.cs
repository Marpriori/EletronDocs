using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eletron.Designer.Campos
{
    class FieldDesktopTextBox : TextBox, IFieldDesktop
    {
        public bool Obrigatorio { get; set; }

    }
}
