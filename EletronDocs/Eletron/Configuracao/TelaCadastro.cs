using System;
using System.Linq;
using System.Windows.Forms;
using Electron.Docs.Tables.Designer;
using Eletron.Designer.Campos;
using Electron.Docs.Tables.Entidades;
using Electron.Docs.Tables.Designer.Atributos;
using Electron.Docs.Tables.Entidades.Listas;
using System.Collections.Generic;

namespace Eletron.Configuracao
{
    public partial class TelaCadastro : Form
    {
        readonly ITabela tabela;
        public TelaCadastro(ITabela tabela)
        {
            InitializeComponent();
            this.tabela = tabela;
            GerarCampos();
        }

        public void GerarCampos()
        {
            tabControl1.TabPages.Clear();
            var campos = tabela.BuscarCamposTela();
            var abas = campos.Select(c => c.Atributo.Aba).Distinct();

            var abaIndex = 0;
            foreach (var aba in abas)
            {
                var tabPage = new TabPage
                {
                    AutoScroll = true,
                    Location = new System.Drawing.Point(4, 22),
                    Name = "tab" + aba.RemoveSpecialCharacters(),
                    Padding = new Padding(3),
                    Size = new System.Drawing.Size(325, 228),
                    TabIndex = abaIndex,
                    Text = aba,
                    UseVisualStyleBackColor = true
                };
                tabControl1.Controls.Add(tabPage);

                var tamanhoTotal = tabControl1.Size.Width - 20;

                var tabIndex = 0;
                var linhaIndex = 0;
                var totalSizeLinha = 0;
                foreach (var campo in campos.Where(c => c.Atributo.Aba == aba))
                {
                    totalSizeLinha += 10;
                    var tamanhoCampo = campo.Atributo.Tamanho;

                    if ((totalSizeLinha + tamanhoCampo) >= (tamanhoTotal))
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

                    var txtCampo = GerarCampo(linhaIndex, totalSizeLinha, campo, tamanhoCampo);
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

        private Control GerarCampo(int linhaIndex, int totalSizeLinha, CamposTela campo, int tamanhoCampo)
        {
            Control txtCampo;
            switch (campo.Atributo.TipoCampo)
            {
                case TipoCampo.LISTA:
                    txtCampo = new FieldDesktopComboBox(
                        ((ICampoLista)Activator.CreateInstance(campo.Atributo.Lista)).Lista,
                        tabela.GetPropertyValue(campo.Nome));
                    break;
                default:
                    if (!string.IsNullOrWhiteSpace(campo.Atributo.Mascara))
                        txtCampo = new FieldDesktopMaskedTextBox(campo.Atributo.Mascara);
                    else
                        txtCampo = new FieldDesktopTextBox();
                    break;
            }

            txtCampo.Location = new System.Drawing.Point(totalSizeLinha, 25 + (linhaIndex * 40));
            txtCampo.Name = "field" + campo.Nome;
            txtCampo.Tag = campo.Atributo.Rotulo;
            txtCampo.Size = new System.Drawing.Size(tamanhoCampo, 20);
            txtCampo.TabIndex = 1;
            txtCampo.Text = tabela.GetPropertyValue(campo.Nome) as string;
            return txtCampo;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                var campos = tab.Controls.Cast<object>().Where(c => c is IFieldDesktop).ToList();

                foreach (var campo in campos)
                {
                    var fieldDesktop = campo as IFieldDesktop;
                    if (fieldDesktop != null && fieldDesktop.Obrigatorio)
                    {
                        var control = campo as Control;
                        if (control != null && string.IsNullOrWhiteSpace(control.Text))
                        {
                            MessageBox.Show(string.Format("Campo '{0}' obrigatório.", control.Tag));
                            return;
                        }
                    }

                    var tiposCampos = new List<Type>() 
                    {
                        typeof(FieldDesktopTextBox), 
                        typeof(FieldDesktopMaskedTextBox),
                        typeof(FieldDesktopComboBox)
 
                    };
                    if (tiposCampos.Contains(campo.GetType()))
                    {
                        var campoTraduzido = campo as Control;


                        tabela.SetPropertyValue(campoTraduzido.Name.Replace("field", ""), campoTraduzido.Text);
                    }
                }
            }
            tabela.Save();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }

    }
}
