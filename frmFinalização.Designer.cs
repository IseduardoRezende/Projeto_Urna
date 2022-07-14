
namespace Projeto_Urna
{
    partial class frmFinalização
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAgradecimento = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblVoto = new System.Windows.Forms.Label();
            this.btnResultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAgradecimento
            // 
            this.lblAgradecimento.AutoSize = true;
            this.lblAgradecimento.BackColor = System.Drawing.Color.Transparent;
            this.lblAgradecimento.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgradecimento.Location = new System.Drawing.Point(703, 287);
            this.lblAgradecimento.Name = "lblAgradecimento";
            this.lblAgradecimento.Size = new System.Drawing.Size(498, 86);
            this.lblAgradecimento.TabIndex = 0;
            this.lblAgradecimento.Text = "Agradecemos ";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.Location = new System.Drawing.Point(783, 406);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(307, 86);
            this.lblSubTitulo.TabIndex = 1;
            this.lblSubTitulo.Text = "pelo seu";
            // 
            // lblVoto
            // 
            this.lblVoto.AutoSize = true;
            this.lblVoto.BackColor = System.Drawing.Color.Transparent;
            this.lblVoto.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoto.Location = new System.Drawing.Point(810, 540);
            this.lblVoto.Name = "lblVoto";
            this.lblVoto.Size = new System.Drawing.Size(235, 86);
            this.lblVoto.TabIndex = 2;
            this.lblVoto.Text = "Voto !";
            // 
            // btnResultados
            // 
            this.btnResultados.BackColor = System.Drawing.Color.Black;
            this.btnResultados.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.ForeColor = System.Drawing.Color.Black;
            this.btnResultados.Location = new System.Drawing.Point(718, 663);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(399, 75);
            this.btnResultados.TabIndex = 3;
            this.btnResultados.Text = "Dados da Urna Eletrônica";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.BtnResultados_Click);
            // 
            // frmFinalização
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 881);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.lblVoto);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblAgradecimento);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "frmFinalização";
            this.Text = "Obrigado por Votar.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFinalização_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgradecimento;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblVoto;
        private System.Windows.Forms.Button btnResultados;
    }
}