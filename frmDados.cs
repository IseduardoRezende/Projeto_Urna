using MySql.Data.MySqlClient;
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
    public partial class frmDados : Form
    {
        VotacaoDao obj = new VotacaoDao();
        public frmDados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmDados_Load(object sender, EventArgs e)
        {
            VotacaoDao obj = new VotacaoDao();
            dgvVotacao.DataSource = obj.listaResultados();

            //txtZeVotos.Text = obj.RetornaQtdVotos("Chapa do Zé");

            //txtRosaVotos.Text = obj.RetornaQtdVotos("Chapa da Rosa");


        }

        private void DgvVotacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtZeVotos_TextChanged(object sender, EventArgs e)
        {
            VotacaoDao obj = new VotacaoDao();
            //dgvVotacao.DataSource = obj.listaResultados();

            //txtZeVotos.Text = obj.RetornaQtdVotos("Chapa do Zé");
        }

        private void TxtRosaVotos_TextChanged(object sender, EventArgs e)
        {
           // VotacaoDao obj = new VotacaoDao();
            //dgvVotacao.DataSource = obj.listaResultados();

            //txtRosaVotos.Text = obj.RetornaQtdVotos("Chapa da Rosa");
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            

        }
    }
}
