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
            chkAtivo = new CheckBox();
            dtpDataNasCliente = new DateTimePicker();
            mxtTelefoneCliente = new MaskedTextBox();
            mxtCpfCliente = new MaskedTextBox();
            btnAlterarCliente = new Button();
            label6 = new Label();
            txtIdCliente = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtEmailCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnInserirCliente = new Button();
            txtNomeCliente = new TextBox();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            txtIdEndereco = new TextBox();
            label7 = new Label();
            txtIdCli = new TextBox();
            label8 = new Label();
            mxtCep = new MaskedTextBox();
            label9 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            textBox2 = new TextBox();
            label11 = new Label();
            textBox3 = new TextBox();
            label12 = new Label();
            textBox4 = new TextBox();
            label13 = new Label();
            textBox5 = new TextBox();
            label14 = new Label();
            comboBox1 = new ComboBox();
            label15 = new Label();
            label16 = new Label();
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
            tabPage1.Controls.Add(chkAtivo);
            tabPage1.Controls.Add(dtpDataNasCliente);
            tabPage1.Controls.Add(mxtTelefoneCliente);
            tabPage1.Controls.Add(mxtCpfCliente);
            tabPage1.Controls.Add(btnAlterarCliente);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtIdCliente);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
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
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(513, 56);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 19;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // dtpDataNasCliente
            // 
            dtpDataNasCliente.Format = DateTimePickerFormat.Short;
            dtpDataNasCliente.Location = new Point(455, 109);
            dtpDataNasCliente.Name = "dtpDataNasCliente";
            dtpDataNasCliente.Size = new Size(200, 23);
            dtpDataNasCliente.TabIndex = 18;
            // 
            // mxtTelefoneCliente
            // 
            mxtTelefoneCliente.Location = new Point(20, 109);
            mxtTelefoneCliente.Mask = "(00)0000-0000";
            mxtTelefoneCliente.Name = "mxtTelefoneCliente";
            mxtTelefoneCliente.Size = new Size(100, 23);
            mxtTelefoneCliente.TabIndex = 17;
            // 
            // mxtCpfCliente
            // 
            mxtCpfCliente.Location = new Point(383, 56);
            mxtCpfCliente.Mask = "000.000.000-00";
            mxtCpfCliente.Name = "mxtCpfCliente";
            mxtCpfCliente.Size = new Size(100, 23);
            mxtCpfCliente.TabIndex = 16;
            // 
            // btnAlterarCliente
            // 
            btnAlterarCliente.Location = new Point(147, 157);
            btnAlterarCliente.Name = "btnAlterarCliente";
            btnAlterarCliente.Size = new Size(75, 23);
            btnAlterarCliente.TabIndex = 15;
            btnAlterarCliente.Text = "&Alterar";
            btnAlterarCliente.UseVisualStyleBackColor = true;
            btnAlterarCliente.Click += btnAlterarCliente_Click;
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
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(20, 56);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.ReadOnly = true;
            txtIdCliente.Size = new Size(33, 23);
            txtIdCliente.TabIndex = 11;
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
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(147, 109);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(279, 23);
            txtEmailCliente.TabIndex = 6;
            txtEmailCliente.Text = "\r\n";
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
            btnInserirCliente.Click += btnInserirCliente_Click;
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
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(mxtCep);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtIdCli);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtIdEndereco);
            tabPage2.Controls.Add(dataGridView1);
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
            // txtIdEndereco
            // 
            txtIdEndereco.Location = new Point(28, 31);
            txtIdEndereco.Name = "txtIdEndereco";
            txtIdEndereco.ReadOnly = true;
            txtIdEndereco.Size = new Size(46, 23);
            txtIdEndereco.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 13);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 3;
            label7.Text = "ID";
            // 
            // txtIdCli
            // 
            txtIdCli.Location = new Point(93, 31);
            txtIdCli.Name = "txtIdCli";
            txtIdCli.Size = new Size(100, 23);
            txtIdCli.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(93, 13);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 5;
            label8.Text = "ID CLIENTE";
            // 
            // mxtCep
            // 
            mxtCep.Location = new Point(199, 31);
            mxtCep.Mask = "00000-00";
            mxtCep.Name = "mxtCep";
            mxtCep.Size = new Size(100, 23);
            mxtCep.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(199, 13);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 0;
            label9.Text = "CEP";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(415, 23);
            textBox1.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(305, 13);
            label10.Name = "label10";
            label10.Size = new Size(86, 15);
            label10.TabIndex = 8;
            label10.Text = "LOGRADOURO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(57, 23);
            textBox2.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 68);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 10;
            label11.Text = "NÚMERO";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(91, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 23);
            textBox3.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(91, 68);
            label12.Name = "label12";
            label12.Size = new Size(94, 15);
            label12.TabIndex = 12;
            label12.Text = "COMPLEMENTO";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(359, 86);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(359, 68);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 14;
            label13.Text = "BAIRRO";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(502, 86);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 15;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(502, 68);
            label14.Name = "label14";
            label14.Size = new Size(48, 15);
            label14.TabIndex = 16;
            label14.Text = "CIDADE";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBox1.Location = new Point(619, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(33, 23);
            comboBox1.TabIndex = 17;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(619, 68);
            label15.Name = "label15";
            label15.Size = new Size(21, 15);
            label15.TabIndex = 18;
            label15.Text = "UF";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(658, 68);
            label16.Name = "label16";
            label16.Size = new Size(94, 15);
            label16.TabIndex = 20;
            label16.Text = "TIPO ENDEREÇO";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
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
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtEmailCliente;
        private Label label6;
        private TextBox txtIdCliente;
        private Button btnAlterarCliente;
        private MaskedTextBox mxtTelefoneCliente;
        private MaskedTextBox mxtCpfCliente;
        private DateTimePicker dtpDataNasCliente;
        private CheckBox chkAtivo;
        private TextBox txtIdEndereco;
        private Label label7;
        private Label label8;
        private TextBox txtIdCli;
        private MaskedTextBox mxtCep;
        private Label label9;
        private TextBox textBox1;
        private Label label10;
        private Label label11;
        private TextBox textBox2;
        private Label label12;
        private TextBox textBox3;
        private Label label13;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label14;
        private ComboBox comboBox1;
        private Label label15;
        private Label label16;
    }
}