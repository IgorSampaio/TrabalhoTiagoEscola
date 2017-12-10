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
    public partial class FormPesquisaAluno : Form
    {
        string nomeAntigo = "";

        public FormPesquisaAluno()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MAluno item = new MAluno();
            item.Nome = txtPesquisa.Text.Trim();
            try
            {
                List<MAluno> lista = CAluno.Pesquisar(item);
                dgvResultado.DataSource = lista;
                nomeAntigo = item.Nome;
            }catch(ExcecaoPersonalizada ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }catch(Exception ex)
            {
                MessageBox.Show(Erros.ErroPadrao + "\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(dgvResultado.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente excluir o aluno selecionado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resultado == DialogResult.Yes)
                {
                    MAluno item = new MAluno();
                    item.CPF = dgvResultado.SelectedRows[0].Cells["CPF"].Value.ToString();

                    try
                    {
                        CAluno.Remover(item);
                        MessageBox.Show("Aluno excluído com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        nomeAntigo = item.Nome;
                        btnPesquisar_Click(null, null);
                    }catch(Exception ex)
                    {
                        MessageBox.Show(Erros.ErroPadrao + "\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(dgvResultado.SelectedRows.Count > 0)
            {
                MAluno item = new MAluno();
                item.CPF = dgvResultado.SelectedRows[0].Cells["CPF"].Value.ToString();
                item.Nome = dgvResultado.SelectedRows[0].Cells["Nome"].Value.ToString();
                item.Nascimento = (DateTime)dgvResultado.SelectedRows[0].Cells["Nascimento"].Value;

                try
                {
                    FormCadastroAluno feditar = new FormCadastroAluno(item);
                    feditar.ShowDialog();
                    if(feditar.Salvou)
                        btnPesquisar_Click(null, null);
                }catch(Exception ex)
                {
                    MessageBox.Show(Erros.ErroPadrao + "\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
