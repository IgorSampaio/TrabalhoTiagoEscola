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
        int tipo; //0 = Adicionar, 1 = Alterar
        public bool Salvou = false;
        public FormCadastroAluno()
        {
            tipo = 0;
            InitializeComponent();
        }

        public FormCadastroAluno(MAluno item)
        {
            tipo = 1;
            InitializeComponent();
            txtNome.Text = item.Nome;
            mtxtCPF.Text = item.CPF;
            mtxtCPF.Enabled = false;
            dtpDataNasc.Value = item.Nascimento;
        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
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
                    if(tipo == 0)
                    {
                        CAluno.Inserir(aluno);
                        MessageBox.Show("Aluno inserido com sucesso!");
                    }
                    else
                    {
                        CAluno.Alterar(aluno);
                        MessageBox.Show("Aluno alterado com sucesso!");
                        Salvou = true;
                    }
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
