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
using Electron.Docs.Tables.Designer;

namespace Eletron.Configuracao
{
    public partial class EmpresaCadastro : Form
    {
        public EmpresaCadastro()
        {
            InitializeComponent();
            GerarCampos();
        }

        public void GerarCampos()
        {
            var campos = new Empresa().GetDescricao();

            var abas = campos.Select(c => c.Atributo.Aba).Distinct();

            var abaIndex = 0;
            foreach (var aba in abas)
            {
                var tabPage = new TabPage();
                tabPage.AutoScroll = true;
                tabPage.Location = new System.Drawing.Point(4, 22);
                tabPage.Name = "tab" + aba.RemoveSpecialCharacters();
                tabPage.Padding = new System.Windows.Forms.Padding(3);
                tabPage.Size = new System.Drawing.Size(325, 228);
                tabPage.TabIndex = abaIndex;
                tabPage.Text = aba;
                tabPage.UseVisualStyleBackColor = true;

                int tabIndex = 0;
                int campoIndex = 0;
                foreach (var campo in campos.Where(c=> c.Atributo.Aba == aba))
                {
                    var label = new Label();
                    tabPage.Controls.Add(label);
                    label.AutoSize = true;
                    label.Location = new System.Drawing.Point(10, 10 + (campoIndex * 40));
                    label.Name = "label" + campo.Nome;
                    label.TabIndex = tabIndex;
                    label.Text = campo.Atributo.Rotulo;

                    tabIndex++;

                    var txtCampo = new TextBox();
                    txtCampo.Location = new System.Drawing.Point(10, 25 + (campoIndex * 40));
                    txtCampo.Name = "field" + campo.Nome;
                    txtCampo.Size = new System.Drawing.Size(493, 20);
                    txtCampo.TabIndex = 1;
                    tabPage.Controls.Add(txtCampo);
                    campoIndex++;
                }


                this.tabControl1.Controls.Add(tabPage);

                abaIndex++;
            }


        }
    }
}
