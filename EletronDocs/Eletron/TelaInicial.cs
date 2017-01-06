using Electron.Docs.Tables;
using Eletron.Configuracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eletron
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            VerificarDataBase();
        }

        private void VerificarDataBase()
        {
            var db = new DBhelperClass();
            DataTable retorno = db.GetDataTable("select * from conexao");
            if (retorno.Rows.Count > 0)
                toolStatusDatabase.Text = "Conectado.";
        }

        private void empresaAtualComboBox_Click(object sender, EventArgs e)
        {

        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empresaCadastro = new EmpresaCadastro();
            empresaCadastro.ShowDialog();
        }

        private void validarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new DBhelperClass();
                db.ValidarBaseDados();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
