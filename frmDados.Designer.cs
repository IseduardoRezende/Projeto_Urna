namespace Projeto_Urna
{
    partial class frmDados
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
            this.dgvVotacao = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblTituloFinalizacao = new System.Windows.Forms.Label();
            this.lblTituloQuantidadeVotos = new System.Windows.Forms.Label();
            this.lblZe = new System.Windows.Forms.Label();
            this.lblRosa = new System.Windows.Forms.Label();
            this.txtZeVotos = new System.Windows.Forms.TextBox();
            this.txtRosaVotos = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVotacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVotacao
            // 
            this.dgvVotacao.AllowUserToAddRows = false;
            this.dgvVotacao.AllowUserToDeleteRows = false;
            this.dgvVotacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVotacao.BackgroundColor = System.Drawing.Color.Black;
            this.dgvVotacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVotacao.GridColor = System.Drawing.Color.White;
            this.dgvVotacao.Location = new System.Drawing.Point(66, 368);
            this.dgvVotacao.Margin = new System.Windows.Forms.Padding(1);
            this.dgvVotacao.Name = "dgvVotacao";
            this.dgvVotacao.ReadOnly = true;
            this.dgvVotacao.RowHeadersWidth = 20;
            this.dgvVotacao.ShowEditingIcon = false;
            this.dgvVotacao.Size = new System.Drawing.Size(708, 317);
            this.dgvVotacao.TabIndex = 0;
            this.dgvVotacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVotacao_CellContentClick);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Black;
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(284, 763);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(263, 75);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // lblTituloFinalizacao
            // 
            this.lblTituloFinalizacao.AutoSize = true;
            this.lblTituloFinalizacao.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFinalizacao.ForeColor = System.Drawing.Color.Black;
            this.lblTituloFinalizacao.Location = new System.Drawing.Point(78, 209);
            this.lblTituloFinalizacao.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTituloFinalizacao.Name = "lblTituloFinalizacao";
            this.lblTituloFinalizacao.Size = new System.Drawing.Size(728, 64);
            this.lblTituloFinalizacao.TabIndex = 2;
            this.lblTituloFinalizacao.Text = "Resultado da Urna Eletrônica";
            // 
            // lblTituloQuantidadeVotos
            // 
            this.lblTituloQuantidadeVotos.AutoSize = true;
            this.lblTituloQuantidadeVotos.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloQuantidadeVotos.Location = new System.Drawing.Point(1030, 209);
            this.lblTituloQuantidadeVotos.Name = "lblTituloQuantidadeVotos";
            this.lblTituloQuantidadeVotos.Size = new System.Drawing.Size(555, 64);
            this.lblTituloQuantidadeVotos.TabIndex = 3;
            this.lblTituloQuantidadeVotos.Text = "Quantidade de Votos ";
            // 
            // lblZe
            // 
            this.lblZe.AutoSize = true;
            this.lblZe.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZe.Location = new System.Drawing.Point(1047, 452);
            this.lblZe.Name = "lblZe";
            this.lblZe.Size = new System.Drawing.Size(87, 64);
            this.lblZe.TabIndex = 4;
            this.lblZe.Text = "Zé";
            // 
            // lblRosa
            // 
            this.lblRosa.AutoSize = true;
            this.lblRosa.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRosa.Location = new System.Drawing.Point(1047, 551);
            this.lblRosa.Name = "lblRosa";
            this.lblRosa.Size = new System.Drawing.Size(146, 64);
            this.lblRosa.TabIndex = 5;
            this.lblRosa.Text = "Rosa";
            // 
            // txtZeVotos
            // 
            this.txtZeVotos.BackColor = System.Drawing.Color.Black;
            this.txtZeVotos.Enabled = false;
            this.txtZeVotos.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZeVotos.ForeColor = System.Drawing.Color.White;
            this.txtZeVotos.Location = new System.Drawing.Point(1228, 472);
            this.txtZeVotos.Name = "txtZeVotos";
            this.txtZeVotos.ReadOnly = true;
            this.txtZeVotos.Size = new System.Drawing.Size(283, 50);
            this.txtZeVotos.TabIndex = 6;
            this.txtZeVotos.TextChanged += new System.EventHandler(this.TxtZeVotos_TextChanged);
            // 
            // txtRosaVotos
            // 
            this.txtRosaVotos.BackColor = System.Drawing.Color.Black;
            this.txtRosaVotos.Enabled = false;
            this.txtRosaVotos.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRosaVotos.ForeColor = System.Drawing.Color.White;
            this.txtRosaVotos.Location = new System.Drawing.Point(1228, 570);
            this.txtRosaVotos.Name = "txtRosaVotos";
            this.txtRosaVotos.ReadOnly = true;
            this.txtRosaVotos.Size = new System.Drawing.Size(283, 50);
            this.txtRosaVotos.TabIndex = 7;
            this.txtRosaVotos.TextChanged += new System.EventHandler(this.TxtRosaVotos_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1278, 774);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(207, 63);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // frmDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtRosaVotos);
            this.Controls.Add(this.txtZeVotos);
            this.Controls.Add(this.lblRosa);
            this.Controls.Add(this.lblZe);
            this.Controls.Add(this.lblTituloQuantidadeVotos);
            this.Controls.Add(this.lblTituloFinalizacao);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvVotacao);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmDados";
            this.Text = "Dados da Urna Eletrônica.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVotacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVotacao;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblTituloFinalizacao;
        private System.Windows.Forms.Label lblTituloQuantidadeVotos;
        private System.Windows.Forms.Label lblZe;
        private System.Windows.Forms.Label lblRosa;
        private System.Windows.Forms.TextBox txtZeVotos;
        private System.Windows.Forms.TextBox txtRosaVotos;
        private System.Windows.Forms.Button btnSair;
    }
}