using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroAluno f = new FormCadastroAluno();
            f.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaAluno f = new FormPesquisaAluno();
            f.ShowDialog();
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCadastroCurso f = new FormCadastroCurso();
            f.ShowDialog();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPesquisaCurso f = new FormPesquisaCurso();
            f.ShowDialog();
        }

        private void inserirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCadastroTipoCurso f = new FormCadastroTipoCurso();
            f.ShowDialog();
        }

        private void pesquisarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormPesquisaTipoCurso f = new FormPesquisaTipoCurso();
            f.ShowDialog();
        }

        private void inserirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormCadastroTipoTerminoCurso f = new FormCadastroTipoTerminoCurso();
            f.ShowDialog();
        }

        private void pesquisarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormPesquisaTipoTerminoCurso f = new FormPesquisaTipoTerminoCurso();
            f.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void inserçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroAlunoCurso f = new FormCadastroAlunoCurso();
            f.ShowDialog();
        }
    }
}
