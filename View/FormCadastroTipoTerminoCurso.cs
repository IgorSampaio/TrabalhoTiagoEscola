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
    public partial class FormCadastroTipoTerminoCurso : Form
    {
        public FormCadastroTipoTerminoCurso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool erro = false;

            if (txtNome.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNome, Erros.TipoCursoNome);
                erro = true;
            }

            if (erro == false)
            {
                MTipoTerminoCurso item = new MTipoTerminoCurso();
                item.Nome = txtNome.Text.Trim();

                try
                {
                    CTipoTerminoCurso.Inserir(item);
                    MessageBox.Show("Cadastro realizado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (ExcecaoPersonalizada ex)
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
