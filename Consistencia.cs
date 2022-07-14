using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Projeto_Urna
{
    class Consistencia
    {
        #region Método para Limpar Campos
        public static void Limpar(Form formlimpar)
        {
            foreach (Control controle in formlimpar.Controls)
            {
                if (controle is GroupBox)
                {
                    for (int i = 0; i < controle.Controls.Count - 1; i++)
                    {
                        if (controle.Controls[i] is TextBox)
                        {
                            controle.Controls[i].Text = "";
                        }
                     //  if (controle.Controls[i] is ComboBox)
                      //  {
                      //   (controle as ComboBox).Text = null;
                      // }
                    }
                }
            }
        }
        #endregion


    }
}
