using Electron.Docs.Tables.Entidades.Configuracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eletron.Configuracao
{
    public partial class EmpresasLista : Form
    {
        public EmpresasLista()
        {
            InitializeComponent();
            ListarEmpresas();
        }

        private void ListarEmpresas()
        {
            dataGridView1.DataSource = new Empresa().GetAll();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var empresaSelecionada = dataGridView1.CurrentRow.DataBoundItem as Empresa;
            if (empresaSelecionada != null)
            {
                var telaEditar = new TelaCadastro(empresaSelecionada);
                if (telaEditar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    ListarEmpresas();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var telaEditar = new TelaCadastro(new Empresa());
            if (telaEditar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                ListarEmpresas();
        }
    }
}
