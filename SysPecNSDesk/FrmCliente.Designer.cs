namespace SysPecNSDesk
{
    partial class FrmCliente
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtDataNasCliente = new TextBox();
            txtEmailCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnInserirCliente = new Button();
            txtNomeCliente = new TextBox();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            txtIdCliente = new TextBox();
            label6 = new Label();
            txtCpfCliente = new MaskedTextBox();
            txtTelefoneCliente = new MaskedTextBox();
            btnAlterarCliente = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 36);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 416);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAlterarCliente);
            tabPage1.Controls.Add(txtTelefoneCliente);
            tabPage1.Controls.Add(txtCpfCliente);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtIdCliente);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtDataNasCliente);
            tabPage1.Controls.Add(txtEmailCliente);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnInserirCliente);
            tabPage1.Controls.Add(txtNomeCliente);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 388);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Clientes";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 91);
            label5.Name = "label5";
            label5.Size = new Size(129, 15);
            label5.TabIndex = 10;
            label5.Text = "DATA DE NASCIMENTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 91);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 9;
            label4.Text = "EMAIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 91);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 8;
            label3.Text = "TELEFONE";
            // 
            // txtDataNasCliente
            // 
            txtDataNasCliente.Location = new Point(455, 109);
            txtDataNasCliente.Name = "txtDataNasCliente";
            txtDataNasCliente.Size = new Size(129, 23);
            txtDataNasCliente.TabIndex = 7;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(147, 109);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(279, 23);
            txtEmailCliente.TabIndex = 6;
            txtEmailCliente.Text = "Ex: jose@gmail.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 38);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 38);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "NOME";
            // 
            // btnInserirCliente
            // 
            btnInserirCliente.Location = new Point(20, 157);
            btnInserirCliente.Name = "btnInserirCliente";
            btnInserirCliente.Size = new Size(75, 23);
            btnInserirCliente.TabIndex = 2;
            btnInserirCliente.Text = "&Inserir";
            btnInserirCliente.UseVisualStyleBackColor = true;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(59, 56);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(279, 23);
            txtNomeCliente.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 388);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Enderecos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(790, 156);
            dataGridView1.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(78, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 0;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(20, 56);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.ReadOnly = true;
            txtIdCliente.Size = new Size(33, 23);
            txtIdCliente.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 38);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 12;
            label6.Text = "ID";
            // 
            // txtCpfCliente
            // 
            txtCpfCliente.Location = new Point(383, 56);
            txtCpfCliente.Name = "txtCpfCliente";
            txtCpfCliente.Size = new Size(175, 23);
            txtCpfCliente.TabIndex = 13;
            // 
            // txtTelefoneCliente
            // 
            txtTelefoneCliente.Location = new Point(20, 109);
            txtTelefoneCliente.Name = "txtTelefoneCliente";
            txtTelefoneCliente.Size = new Size(100, 23);
            txtTelefoneCliente.TabIndex = 14;
            // 
            // btnAlterarCliente
            // 
            btnAlterarCliente.Location = new Point(147, 157);
            btnAlterarCliente.Name = "btnAlterarCliente";
            btnAlterarCliente.Size = new Size(75, 23);
            btnAlterarCliente.TabIndex = 15;
            btnAlterarCliente.Text = "&Alterar";
            btnAlterarCliente.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnInserirCliente;
        private TextBox txtNomeCliente;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtDataNasCliente;
        private TextBox txtEmailCliente;
        private Label label6;
        private TextBox txtIdCliente;
        private MaskedTextBox txtTelefoneCliente;
        private MaskedTextBox txtCpfCliente;
        private Button btnAlterarCliente;
    }
}