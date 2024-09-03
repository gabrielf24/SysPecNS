namespace SysPecNSDesk
{
    partial class FrmProduto
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            txtDesconto = new TextBox();
            cmbCategoria = new ComboBox();
            txtDescricao = new TextBox();
            nudEstoqueMinimo = new NumericUpDown();
            txtUnidadeVenda = new TextBox();
            txtValorunit = new TextBox();
            txtCodBar = new TextBox();
            txtId = new TextBox();
            dgvProdutos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Stout", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 40);
            label1.TabIndex = 0;
            label1.Text = "PRODUTOS";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txtDesconto);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(nudEstoqueMinimo);
            groupBox1.Controls.Add(txtUnidadeVenda);
            groupBox1.Controls.Add(txtValorunit);
            groupBox1.Controls.Add(txtCodBar);
            groupBox1.Controls.Add(txtId);
            groupBox1.Location = new Point(58, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(702, 237);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 164);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 18;
            label9.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(135, 113);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 17;
            label8.Text = "Categoria ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 113);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 16;
            label7.Text = "Descrição";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(383, 71);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 15;
            label6.Text = "Estoque Mínimo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(260, 71);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 14;
            label5.Text = "Unidade de Venda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 71);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 13;
            label4.Text = "Valor Unitário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 71);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 12;
            label3.Text = "Código de barras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 24);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(383, 181);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 10;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(260, 181);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(135, 182);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(6, 182);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(100, 23);
            txtDesconto.TabIndex = 7;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(135, 131);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(352, 23);
            cmbCategoria.TabIndex = 6;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(6, 131);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(100, 23);
            txtDescricao.TabIndex = 5;
            // 
            // nudEstoqueMinimo
            // 
            nudEstoqueMinimo.Location = new Point(383, 89);
            nudEstoqueMinimo.Name = "nudEstoqueMinimo";
            nudEstoqueMinimo.Size = new Size(32, 23);
            nudEstoqueMinimo.TabIndex = 4;
            nudEstoqueMinimo.ValueChanged += npEstoqueMinimo;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(260, 88);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.Size = new Size(100, 23);
            txtUnidadeVenda.TabIndex = 3;
            // 
            // txtValorunit
            // 
            txtValorunit.Location = new Point(135, 88);
            txtValorunit.Name = "txtValorunit";
            txtValorunit.Size = new Size(100, 23);
            txtValorunit.TabIndex = 2;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(6, 88);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(100, 23);
            txtCodBar.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(6, 42);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.BackgroundColor = SystemColors.ControlDarkDark;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dgvProdutos.Location = new Point(58, 291);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.Size = new Size(702, 150);
            dgvProdutos.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Código de Barras";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Descrição";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.Frozen = true;
            Column4.HeaderText = "Valor Unitário";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.Frozen = true;
            Column5.HeaderText = "Unidade de Venda";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.Frozen = true;
            Column6.HeaderText = "Categoria";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.Frozen = true;
            Column7.HeaderText = "Estoque Minimo";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.Frozen = true;
            Column8.HeaderText = "Desconto";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.Frozen = true;
            Column9.HeaderText = "Data Cadastro";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProdutos);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnAdicionar;
        private TextBox txtDesconto;
        private ComboBox cmbCategoria;
        private TextBox txtDescricao;
        private NumericUpDown nudEstoqueMinimo;
        private TextBox txtUnidadeVenda;
        private TextBox txtValorunit;
        private TextBox txtCodBar;
        private TextBox txtId;
        private DataGridView dgvProdutos;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}