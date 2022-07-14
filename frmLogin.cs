using Projeto_Urna.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Urna
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            //aluno.Show(); - Formato não modal
            cadastro.ShowDialog();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            //Botao faz login
            string rn, senha, tipo=null;
                              
            rn = txtrn.Text;
            senha = txtsenha.Text;

            if (radProfessorLogin.Checked)
            {
                tipo = radProfessorLogin.Text;
            }

            else if (radAlunoLogin.Checked)
            {
                tipo = radAlunoLogin.Text;
            }

            ProfessorDao dao = new ProfessorDao();

            if (dao.EfetuaLogin(rn, senha, tipo))
            {
                //Abre a tela da urna
                frmUrna tela = new frmUrna();
                tela.Show();
            }
            else
            {
                MessageBox.Show("RN ou senha incorreto");
            }
        
        }

        private void RadProfessorLogin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Txtrn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
