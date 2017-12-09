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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inserçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCadastroTipoCurso f = new View.FormCadastroTipoCurso();
            f.ShowDialog();
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaTipoCurso p = new View.FormPesquisaTipoCurso();
            p.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inserçãoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCadastroCurso f = new View.FormCadastroCurso();
            f.ShowDialog();
        }

        private void pesquisaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPesquisaCurso p = new View.FormPesquisaCurso();
            p.ShowDialog();
        }

        private void perquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaTipoTerminoCurso f = new View.FormPesquisaTipoTerminoCurso();
            f.ShowDialog();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroTipoTerminoCurso f = new View.FormCadastroTipoTerminoCurso();
            f.ShowDialog();
        }
    }
}
