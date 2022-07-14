using Projeto_Urna.DAO;
using Projeto_Urna.DTO;
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
    public partial class frmUrna : Form
    {
        public frmUrna()
        {
            InitializeComponent();
        }

        private void SobreNósToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CuriosidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SegurancçaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ConfiabilidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ObjetivosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void ObjetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            try 
                {
                if (radChapaZe.Checked)
                {
                    DTOVotacao votar = new DTOVotacao();

                    votar.Nomechapa = radChapaZe.Text;
              

                    VotacaoDao dao = new VotacaoDao();
                    object retorno = dao.inserir(votar);


                    if (retorno.ToString() == "1")
                    {
                        MessageBox.Show("Seu voto foi registrado !");
                        Consistencia.Limpar(this);
                    }

                    frmFinalização finalização = new frmFinalização();
                    //aluno.Show(); - Formato não modal
                    finalização.ShowDialog();

                }
                else if (radChapaRosa.Checked)
                {
                    DTOVotacao votacao = new DTOVotacao();

                    votacao.Nomechapa = radChapaRosa.Text;
                    

                    VotacaoDao dao = new VotacaoDao();
                    object retorno = dao.inserir(votacao);


                    if (retorno.ToString() == "1")
                    {
                        MessageBox.Show("Seu voto foi registrado !");
                        Consistencia.Limpar(this);
                    }
                    frmFinalização finalização= new frmFinalização();
                    //aluno.Show(); - Formato não modal
                    finalização.ShowDialog();

                }
            }

            catch (Expection ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void criadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "file:///C:/Users/aluno/Desktop/Projeto_Urna/Projeto_Urna/Criadores.pdf";
            process1.Start();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process2.StartInfo.FileName = "file:///C:/Users/aluno/Desktop/Projeto_Urna/Projeto_Urna/Manual%20Urna%20Eletrônica.pdf";
            process2.Start();     
        }

        private void chapaZéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process3.StartInfo.FileName = "file:///C:/Users/aluno/Desktop/Projeto_Urna/Projeto_Urna/Metas%20de%20Campanha%20do%20Zé%2012.pdf";
            process3.Start();
        }

        private void chapaRosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process4.StartInfo.FileName = "file:///C:/Users/aluno/Desktop/Projeto_Urna/Projeto_Urna/Metas%20de%20campanha%20da%20Rosa%2012.pdf";
            process4.Start();
        }

        private void AjudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ChapasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RadChapaRosa_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
