namespace SysPecNSDesk
{
    partial class FrmLogin
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
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnLogar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(189, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 23);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(189, 134);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(238, 23);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(189, 176);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 23);
            btnLogar.TabIndex = 2;
            btnLogar.Text = "&Entrar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(352, 176);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 72);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 116);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(111, 25);
            label3.Name = "label3";
            label3.Size = new Size(238, 22);
            label3.TabIndex = 6;
            label3.Text = "Area de Login Syspec";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(29, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 109);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AcceptButton = btnLogar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            CancelButton = btnCancelar;
            ClientSize = new Size(439, 240);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnLogar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnLogar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}