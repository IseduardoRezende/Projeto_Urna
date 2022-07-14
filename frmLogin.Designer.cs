
namespace Projeto_Urna
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblRN = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtrn = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.radProfessorLogin = new System.Windows.Forms.RadioButton();
            this.radAlunoLogin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(572, 57);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(652, 64);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Faça seu Login para Votar";
            // 
            // lblRN
            // 
            this.lblRN.AutoSize = true;
            this.lblRN.BackColor = System.Drawing.Color.Transparent;
            this.lblRN.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRN.ForeColor = System.Drawing.Color.Black;
            this.lblRN.Location = new System.Drawing.Point(480, 203);
            this.lblRN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRN.Name = "lblRN";
            this.lblRN.Size = new System.Drawing.Size(296, 50);
            this.lblRN.TabIndex = 1;
            this.lblRN.Text = "Digite seu RM:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(480, 277);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(344, 50);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Digite sua Senha:";
            // 
            // txtrn
            // 
            this.txtrn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtrn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrn.ForeColor = System.Drawing.Color.Black;
            this.txtrn.Location = new System.Drawing.Point(850, 218);
            this.txtrn.Margin = new System.Windows.Forms.Padding(2);
            this.txtrn.Name = "txtrn";
            this.txtrn.Size = new System.Drawing.Size(272, 35);
            this.txtrn.TabIndex = 3;
            this.txtrn.TextChanged += new System.EventHandler(this.Txtrn_TextChanged);
            // 
            // txtsenha
            // 
            this.txtsenha.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtsenha.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.ForeColor = System.Drawing.Color.Black;
            this.txtsenha.Location = new System.Drawing.Point(850, 292);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(272, 35);
            this.txtsenha.TabIndex = 4;
            this.txtsenha.UseSystemPasswordChar = true;
            this.txtsenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Black;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(1201, 233);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(149, 72);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(757, 682);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(253, 72);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastre-se";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // radProfessorLogin
            // 
            this.radProfessorLogin.AutoSize = true;
            this.radProfessorLogin.BackColor = System.Drawing.Color.White;
            this.radProfessorLogin.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radProfessorLogin.ForeColor = System.Drawing.Color.Black;
            this.radProfessorLogin.Location = new System.Drawing.Point(819, 371);
            this.radProfessorLogin.Name = "radProfessorLogin";
            this.radProfessorLogin.Size = new System.Drawing.Size(191, 46);
            this.radProfessorLogin.TabIndex = 7;
            this.radProfessorLogin.TabStop = true;
            this.radProfessorLogin.Text = "Professor";
            this.radProfessorLogin.UseVisualStyleBackColor = false;
            this.radProfessorLogin.CheckedChanged += new System.EventHandler(this.RadProfessorLogin_CheckedChanged);
            // 
            // radAlunoLogin
            // 
            this.radAlunoLogin.AutoSize = true;
            this.radAlunoLogin.BackColor = System.Drawing.Color.White;
            this.radAlunoLogin.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAlunoLogin.ForeColor = System.Drawing.Color.Black;
            this.radAlunoLogin.Location = new System.Drawing.Point(1036, 371);
            this.radAlunoLogin.Name = "radAlunoLogin";
            this.radAlunoLogin.Size = new System.Drawing.Size(132, 46);
            this.radAlunoLogin.TabIndex = 8;
            this.radAlunoLogin.TabStop = true;
            this.radAlunoLogin.Text = "Aluno";
            this.radAlunoLogin.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Projeto_Urna.Properties.Resources.etec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.radAlunoLogin);
            this.Controls.Add(this.radProfessorLogin);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtrn);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblRN);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frmLogin";
            this.Text = "Urna Eletrônica.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRN;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtrn;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RadioButton radProfessorLogin;
        private System.Windows.Forms.RadioButton radAlunoLogin;
    }
}

