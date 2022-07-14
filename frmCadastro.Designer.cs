
namespace Projeto_Urna
{
    partial class frmCadastro
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
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.grpCadastro = new System.Windows.Forms.GroupBox();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.btnCadastrar2 = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.grpEscolhaModulo = new System.Windows.Forms.GroupBox();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.txtSenhacad2 = new System.Windows.Forms.TextBox();
            this.lblSenhacad2 = new System.Windows.Forms.Label();
            this.txtSenhacad = new System.Windows.Forms.TextBox();
            this.lblSenhacad = new System.Windows.Forms.Label();
            this.txtRNcad = new System.Windows.Forms.TextBox();
            this.lblRNcad = new System.Windows.Forms.Label();
            this.grpEscolha = new System.Windows.Forms.GroupBox();
            this.radProfessor = new System.Windows.Forms.RadioButton();
            this.radAluno = new System.Windows.Forms.RadioButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpCadastro.SuspendLayout();
            this.grpEscolhaModulo.SuspendLayout();
            this.grpEscolha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.White;
            this.lblTitulo2.Location = new System.Drawing.Point(783, 126);
            this.lblTitulo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(514, 64);
            this.lblTitulo2.TabIndex = 0;
            this.lblTitulo2.Text = "Cadastro para Votar";
            // 
            // grpCadastro
            // 
            this.grpCadastro.BackColor = System.Drawing.Color.Black;
            this.grpCadastro.Controls.Add(this.cmbTurma);
            this.grpCadastro.Controls.Add(this.lblTurma);
            this.grpCadastro.Controls.Add(this.btnCadastrar2);
            this.grpCadastro.Controls.Add(this.lblCurso);
            this.grpCadastro.Controls.Add(this.cmbCurso);
            this.grpCadastro.Controls.Add(this.grpEscolhaModulo);
            this.grpCadastro.Controls.Add(this.txtSenhacad2);
            this.grpCadastro.Controls.Add(this.lblSenhacad2);
            this.grpCadastro.Controls.Add(this.txtSenhacad);
            this.grpCadastro.Controls.Add(this.lblSenhacad);
            this.grpCadastro.Controls.Add(this.txtRNcad);
            this.grpCadastro.Controls.Add(this.lblRNcad);
            this.grpCadastro.Controls.Add(this.grpEscolha);
            this.grpCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCadastro.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCadastro.ForeColor = System.Drawing.Color.White;
            this.grpCadastro.Location = new System.Drawing.Point(569, 222);
            this.grpCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.grpCadastro.Name = "grpCadastro";
            this.grpCadastro.Padding = new System.Windows.Forms.Padding(2);
            this.grpCadastro.Size = new System.Drawing.Size(885, 526);
            this.grpCadastro.TabIndex = 2;
            this.grpCadastro.TabStop = false;
            this.grpCadastro.Text = "Cadastrando-se:";
            this.grpCadastro.Enter += new System.EventHandler(this.grpCadastro_Enter);
            // 
            // cmbTurma
            // 
            this.cmbTurma.BackColor = System.Drawing.Color.White;
            this.cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTurma.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurma.ForeColor = System.Drawing.Color.Black;
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Items.AddRange(new object[] {
            " ",
            "Aª",
            "Bª"});
            this.cmbTurma.Location = new System.Drawing.Point(642, 293);
            this.cmbTurma.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(156, 34);
            this.cmbTurma.TabIndex = 19;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(340, 294);
            this.lblTurma.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(288, 28);
            this.lblTurma.TabIndex = 18;
            this.lblTurma.Text = "Em qual turma você está ?";
            // 
            // btnCadastrar2
            // 
            this.btnCadastrar2.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar2.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar2.Location = new System.Drawing.Point(332, 400);
            this.btnCadastrar2.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar2.Name = "btnCadastrar2";
            this.btnCadastrar2.Size = new System.Drawing.Size(215, 57);
            this.btnCadastrar2.TabIndex = 17;
            this.btnCadastrar2.Text = "Cadastrar";
            this.btnCadastrar2.UseVisualStyleBackColor = true;
            this.btnCadastrar2.Click += new System.EventHandler(this.btnCadastrar2_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(341, 229);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(287, 28);
            this.lblCurso.TabIndex = 16;
            this.lblCurso.Text = "Em qual curso você está ? ";
            // 
            // cmbCurso
            // 
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCurso.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "  ",
            "DS",
            "RH"});
            this.cmbCurso.Location = new System.Drawing.Point(642, 228);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(156, 34);
            this.cmbCurso.TabIndex = 15;
            // 
            // grpEscolhaModulo
            // 
            this.grpEscolhaModulo.Controls.Add(this.cmbModulo);
            this.grpEscolhaModulo.ForeColor = System.Drawing.Color.White;
            this.grpEscolhaModulo.Location = new System.Drawing.Point(15, 181);
            this.grpEscolhaModulo.Margin = new System.Windows.Forms.Padding(2);
            this.grpEscolhaModulo.Name = "grpEscolhaModulo";
            this.grpEscolhaModulo.Padding = new System.Windows.Forms.Padding(2);
            this.grpEscolhaModulo.Size = new System.Drawing.Size(322, 141);
            this.grpEscolhaModulo.TabIndex = 14;
            this.grpEscolhaModulo.TabStop = false;
            this.grpEscolhaModulo.Text = "Em qual modulo você está ?";
            // 
            // cmbModulo
            // 
            this.cmbModulo.BackColor = System.Drawing.Color.White;
            this.cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbModulo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModulo.ForeColor = System.Drawing.Color.Black;
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Items.AddRange(new object[] {
            "Selecione uma opção",
            "1 º Módulo",
            "2 º Módulo",
            "3 º Módulo"});
            this.cmbModulo.Location = new System.Drawing.Point(25, 47);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(280, 34);
            this.cmbModulo.TabIndex = 0;
            // 
            // txtSenhacad2
            // 
            this.txtSenhacad2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhacad2.Location = new System.Drawing.Point(552, 157);
            this.txtSenhacad2.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhacad2.Name = "txtSenhacad2";
            this.txtSenhacad2.Size = new System.Drawing.Size(204, 33);
            this.txtSenhacad2.TabIndex = 9;
            this.txtSenhacad2.UseSystemPasswordChar = true;
            // 
            // lblSenhacad2
            // 
            this.lblSenhacad2.AutoSize = true;
            this.lblSenhacad2.Location = new System.Drawing.Point(322, 157);
            this.lblSenhacad2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhacad2.Name = "lblSenhacad2";
            this.lblSenhacad2.Size = new System.Drawing.Size(227, 28);
            this.lblSenhacad2.TabIndex = 8;
            this.lblSenhacad2.Text = "Confirme sua senha:";
            // 
            // txtSenhacad
            // 
            this.txtSenhacad.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhacad.Location = new System.Drawing.Point(552, 105);
            this.txtSenhacad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhacad.Name = "txtSenhacad";
            this.txtSenhacad.Size = new System.Drawing.Size(204, 33);
            this.txtSenhacad.TabIndex = 7;
            // 
            // lblSenhacad
            // 
            this.lblSenhacad.AutoSize = true;
            this.lblSenhacad.Location = new System.Drawing.Point(328, 104);
            this.lblSenhacad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhacad.Name = "lblSenhacad";
            this.lblSenhacad.Size = new System.Drawing.Size(180, 28);
            this.lblSenhacad.TabIndex = 6;
            this.lblSenhacad.Text = "Crie uma senha:";
            // 
            // txtRNcad
            // 
            this.txtRNcad.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRNcad.Location = new System.Drawing.Point(552, 55);
            this.txtRNcad.Margin = new System.Windows.Forms.Padding(2);
            this.txtRNcad.Name = "txtRNcad";
            this.txtRNcad.Size = new System.Drawing.Size(204, 33);
            this.txtRNcad.TabIndex = 5;
            // 
            // lblRNcad
            // 
            this.lblRNcad.AutoSize = true;
            this.lblRNcad.Location = new System.Drawing.Point(328, 55);
            this.lblRNcad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRNcad.Name = "lblRNcad";
            this.lblRNcad.Size = new System.Drawing.Size(167, 28);
            this.lblRNcad.TabIndex = 4;
            this.lblRNcad.Text = "Digite seu RM:";
            // 
            // grpEscolha
            // 
            this.grpEscolha.BackColor = System.Drawing.Color.Black;
            this.grpEscolha.Controls.Add(this.radProfessor);
            this.grpEscolha.Controls.Add(this.radAluno);
            this.grpEscolha.ForeColor = System.Drawing.Color.White;
            this.grpEscolha.Location = new System.Drawing.Point(15, 49);
            this.grpEscolha.Margin = new System.Windows.Forms.Padding(2);
            this.grpEscolha.Name = "grpEscolha";
            this.grpEscolha.Padding = new System.Windows.Forms.Padding(2);
            this.grpEscolha.Size = new System.Drawing.Size(292, 108);
            this.grpEscolha.TabIndex = 3;
            this.grpEscolha.TabStop = false;
            this.grpEscolha.Text = "Escolha em qual se encaixa:";
            this.grpEscolha.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radProfessor
            // 
            this.radProfessor.AutoSize = true;
            this.radProfessor.Location = new System.Drawing.Point(115, 55);
            this.radProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.radProfessor.Name = "radProfessor";
            this.radProfessor.Size = new System.Drawing.Size(131, 32);
            this.radProfessor.TabIndex = 1;
            this.radProfessor.TabStop = true;
            this.radProfessor.Text = "Professor";
            this.radProfessor.UseVisualStyleBackColor = true;
            this.radProfessor.CheckedChanged += new System.EventHandler(this.RadProfessor_CheckedChanged);
            // 
            // radAluno
            // 
            this.radAluno.AutoSize = true;
            this.radAluno.Location = new System.Drawing.Point(5, 55);
            this.radAluno.Margin = new System.Windows.Forms.Padding(2);
            this.radAluno.Name = "radAluno";
            this.radAluno.Size = new System.Drawing.Size(94, 32);
            this.radAluno.TabIndex = 0;
            this.radAluno.TabStop = true;
            this.radAluno.Text = "Aluno";
            this.radAluno.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(77, 718);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(132, 53);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(257, 718);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(141, 53);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1515, 837);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.grpCadastro);
            this.Controls.Add(this.lblTitulo2);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "frmCadastro";
            this.Text = "Cadastro para Votar.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpCadastro.ResumeLayout(false);
            this.grpCadastro.PerformLayout();
            this.grpEscolhaModulo.ResumeLayout(false);
            this.grpEscolha.ResumeLayout(false);
            this.grpEscolha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.GroupBox grpCadastro;
        private System.Windows.Forms.GroupBox grpEscolha;
        private System.Windows.Forms.RadioButton radProfessor;
        private System.Windows.Forms.RadioButton radAluno;
        private System.Windows.Forms.Label lblRNcad;
        private System.Windows.Forms.TextBox txtSenhacad;
        private System.Windows.Forms.Label lblSenhacad;
        private System.Windows.Forms.TextBox txtRNcad;
        private System.Windows.Forms.TextBox txtSenhacad2;
        private System.Windows.Forms.Label lblSenhacad2;
        private System.Windows.Forms.GroupBox grpEscolhaModulo;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Button btnCadastrar2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.Button btnLimpar;
    }
}