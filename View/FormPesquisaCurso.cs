using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace View
{
    public partial class FormPesquisaCurso : Form
    {
        string nomeantigo = "";
        public FormPesquisaCurso()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvResultado.Rows.Clear();
            MCurso item = new MCurso();
            item.Nome = txtNome.Text.Trim();

            try
            {
                List<MCurso> lista = CCurso.Pesquisar(item);
                foreach (MCurso caso in (List<MCurso>)lista)
                {
                    dgvResultado.Rows.Insert(0, caso.Id, caso.Nome, caso.CHMaxima, caso.FKTipoCurso.Nome);
                } 
                
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
                    MCurso item = new MCurso();

                    item.Id = (int)dgvResultado.SelectedRows[0].Cells["ID"].Value;

                    try
                    {
                        CCurso.Remover(item);

                        txtNome.Text = nomeantigo;
                        dgvResultado.Rows.Clear();
                        btnPesquisar_Click(null, null);
                    }
                    catch
                    {
                        MessageBox.Show(Erros.ErroPadrao, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Entrei no tsb1Click com Count = " + dgvResultado.SelectedRows.Count.ToString());
            if (dgvResultado.SelectedRows.Count > 0)
            {
                //MessageBox.Show("Entrei no if do tsb1Click");
                MCurso item = new MCurso();

                item.Id = (int)dgvResultado.SelectedRows[0].Cells["ID"].Value;
                //MessageBox.Show("O ID selecionado é " + item.Id.ToString());
                item = CCurso.Obter(item);
                //MessageBox.Show("O nome do curso é " + item.Nome + " e seu tipo é " + item.FKTipoCurso.Nome);

                FormEditarCurso feditar = new FormEditarCurso(item);
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
