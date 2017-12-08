namespace View
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserçãoToolStripMenuItem,
            this.tipoDeCursoToolStripMenuItem,
            this.alunosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inserçãoToolStripMenuItem
            // 
            this.inserçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.inserçãoToolStripMenuItem.Name = "inserçãoToolStripMenuItem";
            this.inserçãoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.inserçãoToolStripMenuItem.Text = "Sistema";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tipoDeCursoToolStripMenuItem
            // 
            this.tipoDeCursoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisaToolStripMenuItem,
            this.inserçãoToolStripMenuItem1});
            this.tipoDeCursoToolStripMenuItem.Name = "tipoDeCursoToolStripMenuItem";
            this.tipoDeCursoToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.tipoDeCursoToolStripMenuItem.Text = "Tipo de Curso";
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.pesquisaToolStripMenuItem.Text = "Pesquisa";
            this.pesquisaToolStripMenuItem.Click += new System.EventHandler(this.pesquisaToolStripMenuItem_Click);
            // 
            // inserçãoToolStripMenuItem1
            // 
            this.inserçãoToolStripMenuItem1.Name = "inserçãoToolStripMenuItem1";
            this.inserçãoToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.inserçãoToolStripMenuItem1.Text = "Inserção";
            this.inserçãoToolStripMenuItem1.Click += new System.EventHandler(this.inserçãoToolStripMenuItem1_Click);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisaToolStripMenuItem1,
            this.inserçãoToolStripMenuItem2});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.alunosToolStripMenuItem.Text = "Curso";
            // 
            // pesquisaToolStripMenuItem1
            // 
            this.pesquisaToolStripMenuItem1.Name = "pesquisaToolStripMenuItem1";
            this.pesquisaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pesquisaToolStripMenuItem1.Text = "Pesquisa";
            this.pesquisaToolStripMenuItem1.Click += new System.EventHandler(this.pesquisaToolStripMenuItem1_Click);
            // 
            // inserçãoToolStripMenuItem2
            // 
            this.inserçãoToolStripMenuItem2.Name = "inserçãoToolStripMenuItem2";
            this.inserçãoToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.inserçãoToolStripMenuItem2.Text = "Inserção";
            this.inserçãoToolStripMenuItem2.Click += new System.EventHandler(this.inserçãoToolStripMenuItem2_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Projeto Escola";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem2;
    }
}