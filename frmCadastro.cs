using Projeto_Urna.DAO;
using Projeto_Urna.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Urna
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void grpCadastro_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar2_Click(object sender, EventArgs e)
        {
            try {
                if (radAluno.Checked)
                {
                    DTOAluno aluno = new DTOAluno();

                    aluno.Rn1 = txtRNcad.Text;
                    aluno.Curso1 = cmbCurso.Text;
                    aluno.Turma1 = cmbTurma.Text;
                    aluno.Modulo1 = cmbModulo.Text;
                    aluno.Senha1 = txtSenhacad.Text;

                    AlunoDao dao = new AlunoDao();
                    object retorno = dao.inserir(aluno);
                

                    if (retorno.ToString() == "1")
                    {
                        MessageBox.Show("Registro inserido com sucesso !");
                        Consistencia.Limpar(this);
                    }

                }
                else 
                {
                    DTOProfessor professor = new DTOProfessor();

                    professor.Rn1 = txtRNcad.Text;
                    professor.Senha1 = txtSenhacad.Text;
                    


                    ProfessorDao dao = new ProfessorDao();
                    object retorno = dao.inserir(professor);
                   

                    if (retorno.ToString() == "1")
                    {
                        MessageBox.Show("Registro inserido com sucesso !");
                        Consistencia.Limpar(this);

                    }
                   
                }
            }

            catch (Expection ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    
        private void RadProfessor_CheckedChanged(object sender, EventArgs e)
        {
            if (radProfessor.Checked)
            {

                lblCurso.Visible = false;
                cmbCurso.Visible = false;
                lblTurma.Visible = false;
                cmbTurma.Visible = false;
                lblCurso.Visible = false;
                cmbCurso.Visible = false;
                grpEscolhaModulo.Visible = false;
                cmbModulo.Visible = false;

            }

            else if(radAluno.Checked)
            {
                lblCurso.Visible = true;
                cmbCurso.Visible = true;
                lblTurma.Visible = true;
                cmbTurma.Visible = true;
                lblCurso.Visible = true;
                cmbCurso.Visible = true;
                grpEscolhaModulo.Visible = true;
                cmbModulo.Visible = true;

            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Consistencia.Limpar(this);
            
        }
    }

    [Serializable]
    internal class Expection : Exception
    {
        public Expection()
        {
        }

        public Expection(string message) : base(message)
        {
        }

        public Expection(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Expection(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
