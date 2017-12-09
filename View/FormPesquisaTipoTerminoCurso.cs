using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace View
{
    public partial class FormPesquisaTipoTerminoCurso : Form
    {
        string nomeantigo = "";

        public FormPesquisaTipoTerminoCurso()
        {
            InitializeComponent();
        }

        private void FormPesquisarTipoTerminoCurso_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count != 0)
            {
                MTipoTerminoCurso item = new MTipoTerminoCurso();

                item.Id = (int)dgvResultado.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value;

                FormEditarTipoTerminoCurso feditar = new FormEditarTipoTerminoCurso(item);
                feditar.ShowDialog();

                if (feditar.Salvou)
                {
                    txtNome.Text = nomeantigo;
                    button1_Click(null, null);
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MTipoTerminoCurso item = new MTipoTerminoCurso();
            item.Nome = txtNome.Text.Trim();

            try
            {
                List<MTipoTerminoCurso> lista = CTipoTerminoCurso.Pesquisar(item);
                dgvResultado.DataSource = lista;

                nomeantigo = item.Nome;
            }
            catch
            {
                MessageBox.Show(Erros.ErroPadrao, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count != 0)
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente excluir o tipo de curso selecionado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {
                    MTipoTerminoCurso item = new MTipoTerminoCurso();

                    item.Id = (int)dgvResultado.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value;

                    try
                    {
                        CTipoTerminoCurso.Remover(item);

                        txtNome.Text = nomeantigo;
                        button1_Click(null, null);
                    }
                    catch
                    {
                        MessageBox.Show(Erros.ErroPadrao, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
