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
    public partial class FormCadastroCurso : Form
    {
        public FormCadastroCurso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormCadastroCurso_Load(object sender, EventArgs e)
        {
            MTipoCurso item = new MTipoCurso();

            try
            {
                List<MTipoCurso> lista = CTipoCurso.Pesquisar(item);

                foreach (MTipoCurso caso in (List<MTipoCurso>)lista)
                {
                    cbxTipoCurso.Items.Add(caso.Nome);
                }   
            }
            catch
            {
                MessageBox.Show(Erros.ErroPadrao, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool erro = false;

            if (txtNome.Text.Trim() == "" || txtCH.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNome, Erros.TipoCursoNome);
                erro = true;
            }

            if (erro == false)
            {
                MCurso item = new MCurso();
                MTipoCurso itens = new MTipoCurso();
                item.Nome = txtNome.Text.Trim();
                item.CHMaxima = int.Parse(txtCH.Text);
                itens.Nome = cbxTipoCurso.Text.Trim();
                List<MTipoCurso> lista = CTipoCurso.Pesquisar(itens);
                item.FKTipoCurso = lista[0];

                try
                {
                    CCurso.Inserir(item);
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
