namespace Projeto_Urna
{
    partial class frmUrna
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
            this.mnuUrna = new System.Windows.Forms.MenuStrip();
            this.chapasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chapaZéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chapaRosaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreNósToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTituloVoto = new System.Windows.Forms.Label();
            this.grpVotar = new System.Windows.Forms.GroupBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.grpEscolhaVoto = new System.Windows.Forms.GroupBox();
            this.radChapaZe = new System.Windows.Forms.RadioButton();
            this.radChapaRosa = new System.Windows.Forms.RadioButton();
            this.process1 = new System.Diagnostics.Process();
            this.process2 = new System.Diagnostics.Process();
            this.process3 = new System.Diagnostics.Process();
            this.process4 = new System.Diagnostics.Process();
            this.mnuUrna.SuspendLayout();
            this.grpVotar.SuspendLayout();
            this.grpEscolhaVoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUrna
            // 
            this.mnuUrna.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chapasToolStripMenuItem,
            this.sobreNósToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mnuUrna.Location = new System.Drawing.Point(0, 0);
            this.mnuUrna.Name = "mnuUrna";
            this.mnuUrna.Size = new System.Drawing.Size(1370, 24);
            this.mnuUrna.TabIndex = 3;
            // 
            // chapasToolStripMenuItem
            // 
            this.chapasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chapaZéToolStripMenuItem,
            this.chapaRosaToolStripMenuItem});
            this.chapasToolStripMenuItem.Name = "chapasToolStripMenuItem";
            this.chapasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.chapasToolStripMenuItem.Text = "Chapas";
            this.chapasToolStripMenuItem.Click += new System.EventHandler(this.ChapasToolStripMenuItem_Click);
            // 
            // chapaZéToolStripMenuItem
            // 
            this.chapaZéToolStripMenuItem.Name = "chapaZéToolStripMenuItem";
            this.chapaZéToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chapaZéToolStripMenuItem.Text = "Chapa do Zé ";
            this.chapaZéToolStripMenuItem.Click += new System.EventHandler(this.chapaZéToolStripMenuItem_Click);
            // 
            // chapaRosaToolStripMenuItem
            // 
            this.chapaRosaToolStripMenuItem.Name = "chapaRosaToolStripMenuItem";
            this.chapaRosaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chapaRosaToolStripMenuItem.Text = "Chapa da Rosa";
            this.chapaRosaToolStripMenuItem.Click += new System.EventHandler(this.chapaRosaToolStripMenuItem_Click);
            // 
            // sobreNósToolStripMenuItem
            // 
            this.sobreNósToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criadoresToolStripMenuItem});
            this.sobreNósToolStripMenuItem.Name = "sobreNósToolStripMenuItem";
            this.sobreNósToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.sobreNósToolStripMenuItem.Text = "Sobre nós";
            this.sobreNósToolStripMenuItem.Click += new System.EventHandler(this.SobreNósToolStripMenuItem_Click);
            // 
            // criadoresToolStripMenuItem
            // 
            this.criadoresToolStripMenuItem.Name = "criadoresToolStripMenuItem";
            this.criadoresToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.criadoresToolStripMenuItem.Text = "Criadores";
            this.criadoresToolStripMenuItem.Click += new System.EventHandler(this.criadoresToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.AjudaToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // lblTituloVoto
            // 
            this.lblTituloVoto.AutoSize = true;
            this.lblTituloVoto.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloVoto.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVoto.ForeColor = System.Drawing.Color.Black;
            this.lblTituloVoto.Location = new System.Drawing.Point(498, 168);
            this.lblTituloVoto.Name = "lblTituloVoto";
            this.lblTituloVoto.Size = new System.Drawing.Size(369, 64);
            this.lblTituloVoto.TabIndex = 4;
            this.lblTituloVoto.Text = "Hora de Votar";
            // 
            // grpVotar
            // 
            this.grpVotar.BackColor = System.Drawing.Color.Transparent;
            this.grpVotar.Controls.Add(this.btnVotar);
            this.grpVotar.Controls.Add(this.grpEscolhaVoto);
            this.grpVotar.ForeColor = System.Drawing.Color.White;
            this.grpVotar.Location = new System.Drawing.Point(396, 390);
            this.grpVotar.Name = "grpVotar";
            this.grpVotar.Size = new System.Drawing.Size(662, 303);
            this.grpVotar.TabIndex = 5;
            this.grpVotar.TabStop = false;
            this.grpVotar.Text = "Votação";
            // 
            // btnVotar
            // 
            this.btnVotar.BackColor = System.Drawing.Color.Black;
            this.btnVotar.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotar.ForeColor = System.Drawing.Color.Yellow;
            this.btnVotar.Location = new System.Drawing.Point(393, 110);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(188, 100);
            this.btnVotar.TabIndex = 2;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = false;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // grpEscolhaVoto
            // 
            this.grpEscolhaVoto.Controls.Add(this.radChapaZe);
            this.grpEscolhaVoto.Controls.Add(this.radChapaRosa);
            this.grpEscolhaVoto.Location = new System.Drawing.Point(17, 53);
            this.grpEscolhaVoto.Name = "grpEscolhaVoto";
            this.grpEscolhaVoto.Size = new System.Drawing.Size(344, 192);
            this.grpEscolhaVoto.TabIndex = 3;
            this.grpEscolhaVoto.TabStop = false;
            // 
            // radChapaZe
            // 
            this.radChapaZe.AutoSize = true;
            this.radChapaZe.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChapaZe.Location = new System.Drawing.Point(20, 46);
            this.radChapaZe.Name = "radChapaZe";
            this.radChapaZe.Size = new System.Drawing.Size(204, 40);
            this.radChapaZe.TabIndex = 0;
            this.radChapaZe.TabStop = true;
            this.radChapaZe.Text = "Chapa do Zé";
            this.radChapaZe.UseVisualStyleBackColor = true;
            // 
            // radChapaRosa
            // 
            this.radChapaRosa.AutoSize = true;
            this.radChapaRosa.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChapaRosa.Location = new System.Drawing.Point(20, 101);
            this.radChapaRosa.Name = "radChapaRosa";
            this.radChapaRosa.Size = new System.Drawing.Size(234, 40);
            this.radChapaRosa.TabIndex = 1;
            this.radChapaRosa.TabStop = true;
            this.radChapaRosa.Text = "Chapa da Rosa";
            this.radChapaRosa.UseVisualStyleBackColor = true;
            this.radChapaRosa.CheckedChanged += new System.EventHandler(this.RadChapaRosa_CheckedChanged);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // process2
            // 
            this.process2.StartInfo.Domain = "";
            this.process2.StartInfo.LoadUserProfile = false;
            this.process2.StartInfo.Password = null;
            this.process2.StartInfo.StandardErrorEncoding = null;
            this.process2.StartInfo.StandardOutputEncoding = null;
            this.process2.StartInfo.UserName = "";
            this.process2.SynchronizingObject = this;
            // 
            // process3
            // 
            this.process3.StartInfo.Domain = "";
            this.process3.StartInfo.LoadUserProfile = false;
            this.process3.StartInfo.Password = null;
            this.process3.StartInfo.StandardErrorEncoding = null;
            this.process3.StartInfo.StandardOutputEncoding = null;
            this.process3.StartInfo.UserName = "";
            this.process3.SynchronizingObject = this;
            // 
            // process4
            // 
            this.process4.StartInfo.Domain = "";
            this.process4.StartInfo.LoadUserProfile = false;
            this.process4.StartInfo.Password = null;
            this.process4.StartInfo.StandardErrorEncoding = null;
            this.process4.StartInfo.StandardOutputEncoding = null;
            this.process4.StartInfo.UserName = "";
            this.process4.SynchronizingObject = this;
            // 
            // frmUrna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Projeto_Urna.Properties.Resources.urnai;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.grpVotar);
            this.Controls.Add(this.lblTituloVoto);
            this.Controls.Add(this.mnuUrna);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(11);
            this.Name = "frmUrna";
            this.Text = "Votar.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuUrna.ResumeLayout(false);
            this.mnuUrna.PerformLayout();
            this.grpVotar.ResumeLayout(false);
            this.grpEscolhaVoto.ResumeLayout(false);
            this.grpEscolhaVoto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuUrna;
        private System.Windows.Forms.ToolStripMenuItem chapasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreNósToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chapaZéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chapaRosaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.Label lblTituloVoto;
        private System.Windows.Forms.GroupBox grpVotar;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.GroupBox grpEscolhaVoto;
        private System.Diagnostics.Process process1;
        private System.Diagnostics.Process process2;
        private System.Diagnostics.Process process3;
        private System.Diagnostics.Process process4;
        private System.Windows.Forms.RadioButton radChapaZe;
        private System.Windows.Forms.RadioButton radChapaRosa;
    }
}