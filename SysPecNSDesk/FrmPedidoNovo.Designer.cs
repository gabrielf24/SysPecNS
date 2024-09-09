namespace SysPecNSDesk
{
    partial class FrmPedidoNovo
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
            groupBox1 = new GroupBox();
            btnAbrir = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtIdPedido = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btnAbrir);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Location = new Point(46, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 124);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Identificação";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(394, 93);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 23);
            btnAbrir.TabIndex = 4;
            btnAbrir.Text = "&Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnInserePedido_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 92);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Cliente";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(75, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(285, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 43);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 1;
            label3.Text = "Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(74, 43);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(286, 23);
            txtUsuario.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(46, 237);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(556, 213);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Itens do Pedido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(142, 50);
            label1.Name = "label1";
            label1.Size = new Size(211, 36);
            label1.TabIndex = 2;
            label1.Text = "NOVO PEDIDO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(649, 18);
            label2.Name = "label2";
            label2.Size = new Size(139, 29);
            label2.TabIndex = 3;
            label2.Text = "NÚMERO ";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(649, 50);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(139, 23);
            txtIdPedido.TabIndex = 4;
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 620);
            Controls.Add(txtIdPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label3;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtIdPedido;
        private TextBox textBox2;
        private Label label4;
        private Button btnAbrir;
    }
}