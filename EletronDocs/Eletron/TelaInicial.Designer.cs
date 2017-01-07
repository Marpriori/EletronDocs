namespace Eletron
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStatusDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cTeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaAtualComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatusDatabase});
            this.statusStrip1.Location = new System.Drawing.Point(0, 304);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(694, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStatusDatabase
            // 
            this.toolStatusDatabase.Name = "toolStatusDatabase";
            this.toolStatusDatabase.Size = new System.Drawing.Size(168, 17);
            this.toolStatusDatabase.Text = "Conectando banco de dados...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentosToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.configuraçãoToolStripMenuItem,
            this.empresaAtualComboBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cTeToolStripMenuItem});
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(87, 23);
            this.documentosToolStripMenuItem.Text = "Documentos";
            // 
            // cTeToolStripMenuItem
            // 
            this.cTeToolStripMenuItem.Name = "cTeToolStripMenuItem";
            this.cTeToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.cTeToolStripMenuItem.Text = "CTe";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.operaçõesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.baseDeDadosToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.empresaToolStripMenuItem.Text = "Empresas";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // baseDeDadosToolStripMenuItem
            // 
            this.baseDeDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validarToolStripMenuItem});
            this.baseDeDadosToolStripMenuItem.Name = "baseDeDadosToolStripMenuItem";
            this.baseDeDadosToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.baseDeDadosToolStripMenuItem.Text = "Base de dados";
            // 
            // validarToolStripMenuItem
            // 
            this.validarToolStripMenuItem.Name = "validarToolStripMenuItem";
            this.validarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.validarToolStripMenuItem.Text = "Validar";
            this.validarToolStripMenuItem.Click += new System.EventHandler(this.validarToolStripMenuItem_Click);
            // 
            // empresaAtualComboBox
            // 
            this.empresaAtualComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.empresaAtualComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaAtualComboBox.DropDownWidth = 170;
            this.empresaAtualComboBox.Items.AddRange(new object[] {
            "EMPRESA 2 ME",
            "GUSTAVO PRIORI ME"});
            this.empresaAtualComboBox.Name = "empresaAtualComboBox";
            this.empresaAtualComboBox.Size = new System.Drawing.Size(180, 23);
            this.empresaAtualComboBox.Sorted = true;
            this.empresaAtualComboBox.Click += new System.EventHandler(this.empresaAtualComboBox_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 326);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaInicial";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cTeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox empresaAtualComboBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusDatabase;
        private System.Windows.Forms.ToolStripMenuItem baseDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarToolStripMenuItem;
    }
}

