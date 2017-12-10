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
    public partial class FormCadastroAlunoCurso : Form
    {
        public FormCadastroAlunoCurso()
        {
            InitializeComponent();
        }

        private void FormCadastroAlunoCurso_Load(object sender, EventArgs e)
        {
            MCurso item = new MCurso();
            MAluno item2 = new MAluno();
            MTipoTerminoCurso item3 = new MTipoTerminoCurso();

            try
            {
                List<MCurso> lista = CCurso.Pesquisar(item);

                foreach (MCurso caso in (List<MCurso>)lista)
                {
                    cbxCurso.Items.Add(caso.Nome);
                }
                //List<MAluno> lista2 = CAluno.Pesquisar(item2);

                //foreach (MAluno caso in (List<MAluno>)lista2)
                //{
                //    cbxCurso.Items.Add(caso.Nome);
                //}
                List<MTipoTerminoCurso> lista3 = CTipoTerminoCurso.Pesquisar(item3);

                foreach (MTipoTerminoCurso caso in (List<MTipoTerminoCurso>)lista3)
                {
                    cbxTermino.Items.Add(caso.Nome);
                }
                dtpFim.Format = DateTimePickerFormat.Custom;
                dtpFim.CustomFormat = "dd-MM-yyyy";
            }
            catch
            {
                MessageBox.Show(Erros.ErroPadrao, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool erro = false;

            if (txtProntuario.Text.Trim() == "")
            {
                errorProvider1.SetError(txtProntuario, Erros.TipoCursoNome);
                erro = true;
            }

            if (erro == false)
            {
                MAlunoCurso item = new MAlunoCurso();
                MCurso item1 = new MCurso();
                MTipoTerminoCurso item2 = new MTipoTerminoCurso();
                MAluno item3 = new MAluno();
                item.Prontuario = txtProntuario.Text.Trim();
                item.Inicio = dtpInicio.Value.Date;
                item.Termino = dtpFim.Value.Date;
                item1.Nome = cbxCurso.Text.Trim();
                item2.Nome = cbxTermino.Text.Trim();
                List<MCurso> lista = CCurso.Pesquisar(item1);
                List<MTipoTerminoCurso> lista1 = CTipoTerminoCurso.Pesquisar(item2);
                item.FKCursoID = lista[0];
                item.FKTipoTerminoCursoID = lista1[0];

                try
                {
                    CAlunoCurso.Inserir(item);
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
