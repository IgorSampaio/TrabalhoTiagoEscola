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
    public partial class FormCadastroTipoCurso : Form
    {
        public FormCadastroTipoCurso()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool erro = false;

            if (txtNome.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNome, Erros.TipoCursoNome);
                erro = true;
            }

            if(erro == false)
            {
                MTipoCurso item = new MTipoCurso();
                item.Nome = txtNome.Text.Trim();

                try
                {
                    CTipoCurso.Inserir(item);
                    MessageBox.Show("Cadastro realizado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch(ExcecaoPersonalizada ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show(Erros.ErroPadrao, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
