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
            grbIdentificacao = new GroupBox();
            txtCliente = new TextBox();
            btnInserePedido = new Button();
            label4 = new Label();
            txtIdCliente = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            grbItens = new GroupBox();
            btnAddIten = new Button();
            txtTotal = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtDesconto = new TextBox();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            txtCodBar = new TextBox();
            txtDescricao = new TextBox();
            dgvItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtIdPedido = new TextBox();
            btnFechar = new Button();
            textBox2 = new TextBox();
            txtDescontoIten = new TextBox();
            txtDescontoItens = new TextBox();
            txtSubTotal = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            grbIdentificacao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIdentificacao
            // 
            grbIdentificacao.BackColor = SystemColors.Control;
            grbIdentificacao.Controls.Add(txtCliente);
            grbIdentificacao.Controls.Add(btnInserePedido);
            grbIdentificacao.Controls.Add(label4);
            grbIdentificacao.Controls.Add(txtIdCliente);
            grbIdentificacao.Controls.Add(label3);
            grbIdentificacao.Controls.Add(txtUsuario);
            grbIdentificacao.Location = new Point(46, 87);
            grbIdentificacao.Name = "grbIdentificacao";
            grbIdentificacao.Size = new Size(522, 124);
            grbIdentificacao.TabIndex = 0;
            grbIdentificacao.TabStop = false;
            grbIdentificacao.Text = "Identificação";
            grbIdentificacao.Enter += grbIdentificacao_Enter;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(124, 89);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(236, 23);
            txtCliente.TabIndex = 5;
            // 
            // btnInserePedido
            // 
            btnInserePedido.Location = new Point(383, 54);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(86, 53);
            btnInserePedido.TabIndex = 4;
            btnInserePedido.Text = "&Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
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
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(71, 89);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(47, 23);
            txtIdCliente.TabIndex = 2;
            txtIdCliente.TextChanged += txtIdCliente_TextChanged;
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
            // grbItens
            // 
            grbItens.Controls.Add(radioButton2);
            grbItens.Controls.Add(radioButton1);
            grbItens.Controls.Add(btnAddIten);
            grbItens.Controls.Add(txtTotal);
            grbItens.Controls.Add(label10);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(label5);
            grbItens.Controls.Add(txtDesconto);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(txtCodBar);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Location = new Point(46, 237);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(650, 371);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens do Pedido";
            grbItens.Enter += grbItens_Enter;
            // 
            // btnAddIten
            // 
            btnAddIten.Location = new Point(563, 22);
            btnAddIten.Name = "btnAddIten";
            btnAddIten.Size = new Size(75, 50);
            btnAddIten.TabIndex = 13;
            btnAddIten.Text = "A&dicionar";
            btnAddIten.UseVisualStyleBackColor = true;
            btnAddIten.Click += btnAddIten_Click;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.ForeColor = Color.DarkGreen;
            txtTotal.Location = new Point(535, 323);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(105, 33);
            txtTotal.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(461, 326);
            label10.Name = "label10";
            label10.Size = new Size(81, 25);
            label10.TabIndex = 5;
            label10.Text = "Total R$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(521, 219);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 11;
            label9.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(429, 30);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 10;
            label8.Text = "Quant";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(366, 30);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 9;
            label7.Text = "Valor Unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 30);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 8;
            label6.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 30);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 7;
            label5.Text = "Código de Barras";
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(475, 48);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.RightToLeft = RightToLeft.Yes;
            txtDesconto.Size = new Size(67, 23);
            txtDesconto.TabIndex = 6;
            txtDesconto.Text = "0";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(429, 48);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.RightToLeft = RightToLeft.Yes;
            txtQuantidade.Size = new Size(40, 23);
            txtQuantidade.TabIndex = 5;
            txtQuantidade.Text = "1";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(366, 48);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(57, 23);
            txtValorUnit.TabIndex = 4;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(21, 49);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(101, 23);
            txtCodBar.TabIndex = 3;
            txtCodBar.Leave += txtCodBar_Leave;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(128, 48);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(232, 23);
            txtDescricao.TabIndex = 2;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnValorUnit, clnQuantidade, clnDesconto, clnTotalItem });
            dgvItensPedido.Location = new Point(21, 77);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.Size = new Size(615, 234);
            dgvItensPedido.TabIndex = 0;
            dgvItensPedido.CellContentClick += dgvItensPedido_CellContentClick;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 90;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descricão";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 90;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 70;
            // 
            // clnDesconto
            // 
            clnDesconto.Frozen = true;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 70;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
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
            // btnFechar
            // 
            btnFechar.Location = new Point(709, 560);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(81, 43);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(702, 525);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(98, 23);
            textBox2.TabIndex = 5;
            // 
            // txtDescontoIten
            // 
            txtDescontoIten.Location = new Point(702, 452);
            txtDescontoIten.Name = "txtDescontoIten";
            txtDescontoIten.Size = new Size(98, 23);
            txtDescontoIten.TabIndex = 6;
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(702, 406);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.ReadOnly = true;
            txtDescontoItens.Size = new Size(98, 23);
            txtDescontoItens.TabIndex = 7;
            txtDescontoItens.TextChanged += txtDescontoItens_TextChanged;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(702, 362);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(98, 23);
            txtSubTotal.TabIndex = 8;
            txtSubTotal.TextChanged += textBox5_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(702, 344);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 9;
            label11.Text = "Sub Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(702, 388);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 10;
            label12.Text = "Desconto Itens ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(702, 434);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 11;
            label13.Text = "Desconto";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(702, 501);
            label14.Name = "label14";
            label14.Size = new Size(45, 21);
            label14.TabIndex = 12;
            label14.Text = "Total";
            label14.Click += label14_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(461, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(463, 30);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 620);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtSubTotal);
            Controls.Add(label9);
            Controls.Add(txtDescontoItens);
            Controls.Add(txtDescontoIten);
            Controls.Add(textBox2);
            Controls.Add(txtIdPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grbItens);
            Controls.Add(grbIdentificacao);
            Controls.Add(btnFechar);
            Name = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            grbIdentificacao.ResumeLayout(false);
            grbIdentificacao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIdentificacao;
        private GroupBox grbItens;
        private Label label1;
        private Label label3;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtIdPedido;
        private TextBox txtIdCliente;
        private Label label4;
        private Button btnInserePedido;
        private Button btnFechar;
        private DataGridView dgvItensPedido;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtDesconto;
        private TextBox txtQuantidade;
        private TextBox txtValorUnit;
        private TextBox txtCodBar;
        private TextBox txtDescricao;
        private TextBox txtTotal;
        private Label label10;
        private TextBox textBox2;
        private TextBox txtDescontoIten;
        private TextBox txtDescontoItens;
        private TextBox txtSubTotal;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button btnAddIten;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnTotalItem;
        private TextBox txtCliente;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}