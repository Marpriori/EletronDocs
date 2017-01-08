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
using Eletron.Designer.Campos;

namespace Eletron.Configuracao
{
    public partial class EmpresaCadastro : Form
    {
        Empresa empresa;
        public EmpresaCadastro()
        {
            InitializeComponent();
            GerarCampos();
        }

        public void GerarCampos()
        {

            empresa = new Empresa();
            var campos = empresa.GetDescricao();
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
                this.tabControl1.Controls.Add(tabPage);

                int tamanhoTotal = this.tabControl1.Size.Width - 20;
                int tamanhoUnidade = tamanhoTotal / 12;

                int tabIndex = 0;
                int linhaIndex = 0;
                int totalSizeLinha = 0;
                foreach (var campo in campos.Where(c=> c.Atributo.Aba == aba))
                {
                    totalSizeLinha += 10;
                    int tamanhoCampo = ((int)campo.Atributo.Tamanho) * tamanhoUnidade;

                    if ((totalSizeLinha+ tamanhoCampo) >= (tamanhoTotal + 10))
                    {
                        linhaIndex++;
                        totalSizeLinha = 10;

                    }

                    var label = new Label();
                    tabPage.Controls.Add(label);
                    label.AutoSize = true;
                    label.Location = new System.Drawing.Point(totalSizeLinha, 10 + (linhaIndex * 40));
                    label.Name = "label" + campo.Nome;
                    label.TabIndex = tabIndex;
                    label.Text = campo.Atributo.Rotulo;

                    tabIndex++;

                    var txtCampo = new FieldDesktopTextBox();
                    txtCampo.Location = new System.Drawing.Point(totalSizeLinha, 25 + (linhaIndex * 40));
                    txtCampo.Name = "field" + campo.Nome;
                    txtCampo.Tag = campo.Atributo.Rotulo;
                    
                    txtCampo.Size = new System.Drawing.Size(tamanhoCampo, 20);
                    txtCampo.TabIndex = 1;
                    tabPage.Controls.Add(txtCampo);
                    totalSizeLinha += tamanhoCampo;
                    if (totalSizeLinha >= tamanhoTotal)
                    {
                        linhaIndex++;
                        totalSizeLinha = 0;

                    }
                }




                abaIndex++;
            }


        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in this.tabControl1.TabPages)
            {
                var campos = tab.Controls.Cast<object>().Where(c => c is IFieldDesktop).ToList();

                foreach (var campo in campos)
                {
                    if ((campo as IFieldDesktop).Obrigatorio)
                    {
                        var control = campo as Control;
                        if (string.IsNullOrWhiteSpace(control.Text))
                        {
                            MessageBox.Show(string.Format("Campo '{0}' obrigatório.", control.Tag));
                            return;
                        }
                    }

                    if(campo is FieldDesktopTextBox){

                        var campoTraduzido = campo as FieldDesktopTextBox;

                        empresa.SetPropertyValue(campoTraduzido.Name.Replace("field",""), campoTraduzido.Text);

                    }

                }

            }

            empresa.Save();

        }
    }
}
