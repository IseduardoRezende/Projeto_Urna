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
    public partial class frmFinalização : Form
    {
        public frmFinalização()
        {
            InitializeComponent();
        }

        private void frmFinalização_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnResultados_Click(object sender, EventArgs e)
        {
            frmDados dados = new frmDados();
            //aluno.Show(); - Formato não modal
            dados.ShowDialog();
        }
    }
}
