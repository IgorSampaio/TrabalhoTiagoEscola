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
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.términoDeCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.alunoToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.tipoDeToolStripMenuItem,
            this.términoDeCursoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.pesquisarToolStripMenuItem});
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.inserirToolStripMenuItem.Text = "Inserir";
            this.inserirToolStripMenuItem.Click += new System.EventHandler(this.inserirToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem1,
            this.pesquisarToolStripMenuItem1});
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.cursoToolStripMenuItem.Text = "Curso";
            // 
            // inserirToolStripMenuItem1
            // 
            this.inserirToolStripMenuItem1.Name = "inserirToolStripMenuItem1";
            this.inserirToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.inserirToolStripMenuItem1.Text = "Inserir";
            this.inserirToolStripMenuItem1.Click += new System.EventHandler(this.inserirToolStripMenuItem1_Click);
            // 
            // pesquisarToolStripMenuItem1
            // 
            this.pesquisarToolStripMenuItem1.Name = "pesquisarToolStripMenuItem1";
            this.pesquisarToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.pesquisarToolStripMenuItem1.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem1.Click += new System.EventHandler(this.pesquisarToolStripMenuItem1_Click);
            // 
            // tipoDeToolStripMenuItem
            // 
            this.tipoDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem2,
            this.pesquisarToolStripMenuItem2});
            this.tipoDeToolStripMenuItem.Name = "tipoDeToolStripMenuItem";
            this.tipoDeToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.tipoDeToolStripMenuItem.Text = "Tipo de Curso";
            // 
            // inserirToolStripMenuItem2
            // 
            this.inserirToolStripMenuItem2.Name = "inserirToolStripMenuItem2";
            this.inserirToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.inserirToolStripMenuItem2.Text = "Inserir";
            this.inserirToolStripMenuItem2.Click += new System.EventHandler(this.inserirToolStripMenuItem2_Click);
            // 
            // pesquisarToolStripMenuItem2
            // 
            this.pesquisarToolStripMenuItem2.Name = "pesquisarToolStripMenuItem2";
            this.pesquisarToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.pesquisarToolStripMenuItem2.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem2.Click += new System.EventHandler(this.pesquisarToolStripMenuItem2_Click);
            // 
            // términoDeCursoToolStripMenuItem
            // 
            this.términoDeCursoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem3,
            this.pesquisarToolStripMenuItem3});
            this.términoDeCursoToolStripMenuItem.Name = "términoDeCursoToolStripMenuItem";
            this.términoDeCursoToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.términoDeCursoToolStripMenuItem.Text = "Término de Curso";
            // 
            // inserirToolStripMenuItem3
            // 
            this.inserirToolStripMenuItem3.Name = "inserirToolStripMenuItem3";
            this.inserirToolStripMenuItem3.Size = new System.Drawing.Size(181, 26);
            this.inserirToolStripMenuItem3.Text = "Inserir";
            this.inserirToolStripMenuItem3.Click += new System.EventHandler(this.inserirToolStripMenuItem3_Click);
            // 
            // pesquisarToolStripMenuItem3
            // 
            this.pesquisarToolStripMenuItem3.Name = "pesquisarToolStripMenuItem3";
            this.pesquisarToolStripMenuItem3.Size = new System.Drawing.Size(181, 26);
            this.pesquisarToolStripMenuItem3.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem3.Click += new System.EventHandler(this.pesquisarToolStripMenuItem3_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 322);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Projeto Escola";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem términoDeCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem3;
    }
}