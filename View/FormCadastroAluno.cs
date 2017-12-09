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
    public partial class FormCadastroAluno : Form
    {
        public FormCadastroAluno()
        {
            InitializeComponent();
        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mtxtCPF.Text);
            errorProvider1.Clear();
            bool erro = false;

            if(txtNome.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNome, Erros.AlunoNome);
                erro = true;
            }
            if(mtxtCPF.Text.Trim() == "")
            {
                errorProvider1.SetError(mtxtCPF, Erros.AlunoCPF);
                erro = true;
            }

            if (!erro)
            {
                MAluno aluno = new MAluno();
                aluno.Nome = txtNome.Text;
                aluno.CPF = mtxtCPF.Text;
                aluno.Nascimento = dtpDataNasc.Value;

                try
                {
                    CAluno.Inserir(aluno);
                    MessageBox.Show("Aluno inserido com sucesso!");
                    this.Close();
                }catch(ExcecaoPersonalizada ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(Erros.ErroPadrao + "\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
