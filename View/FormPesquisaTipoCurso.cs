using Controller;
using Model;
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
    public partial class FormPesquisaTipoCurso : Form
    {
        string nomeantigo = "";

        public FormPesquisaTipoCurso()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MTipoCurso item = new MTipoCurso();
            item.Nome = txtNome.Text.Trim();

            try
            {
                List<MTipoCurso> lista = CTipoCurso.Pesquisar(item);
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
                    MTipoCurso item = new MTipoCurso();

                    item.Id = (int)dgvResultado.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value;

                    try
                    {
                        CTipoCurso.Remover(item);

                        txtNome.Text = nomeantigo;
                        btnPesquisar_Click(null, null);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(Erros.ErroPadrao + "\nTalvez você esteja excluindo um Tipo de Curso que já está vinculado a algum Curso?" + "\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count != 0)
            {
                MTipoCurso item = new MTipoCurso();

                item.Id = (int)dgvResultado.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value;

                FormEditarTipoCurso feditar = new FormEditarTipoCurso(item);
                feditar.ShowDialog();

                if (feditar.Salvou)
                {
                    txtNome.Text = nomeantigo;
                    btnPesquisar_Click(null, null);
                }
            }
        }
    }
}
