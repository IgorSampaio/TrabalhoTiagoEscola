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
    public partial class FormEditarCurso : Form
    {
        MCurso Item;
        public bool Salvou = false;

        public FormEditarCurso(MCurso item)
        {
            Item = item;
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
                Item.Nome = txtNome.Text.Trim();

                try
                {
                    CCurso.Atualizar(Item);
                    MessageBox.Show("Cadastro atualizado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Salvou = true;
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

        private void FormEditarCurso_Load(object sender, EventArgs e)
        {
            MTipoCurso item = new MTipoCurso();
            List<MTipoCurso> lista = CTipoCurso.Pesquisar(item);

            foreach (MTipoCurso caso in (List<MTipoCurso>)lista)
            {
                cbxTipoCurso.Items.Add(caso.Nome);
            }
            
        }
    }
}
