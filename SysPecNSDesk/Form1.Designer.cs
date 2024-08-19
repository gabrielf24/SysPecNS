
namespace SysPecNSDesk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfirma = new Button();
            lstResultado = new ListBox();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            cmbOperacao = new ComboBox();
            SuspendLayout();
            // 
            // btnConfirma
            // 
            btnConfirma.Enabled = false;
            btnConfirma.Location = new Point(422, 63);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(75, 24);
            btnConfirma.TabIndex = 0;
            btnConfirma.Text = "&Confirma";
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(83, 92);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(206, 184);
            lstResultado.TabIndex = 1;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(210, 63);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 3;
            txtNumero1.TextChanged += txtNumero1_TextChanged;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(316, 63);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 4;
            txtNumero2.TextChanged += txtNumero2_TextChanged;
            // 
            // cmbOperacao
            // 
            cmbOperacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacao.FormattingEnabled = true;
            cmbOperacao.Items.AddRange(new object[] { "Multiplicação", "Divisão ", "Adição", "Subtração", "Exponenciação", "Radiciação", "Logaritimos" });
            cmbOperacao.Location = new Point(83, 63);
            cmbOperacao.Name = "cmbOperacao";
            cmbOperacao.Size = new Size(121, 23);
            cmbOperacao.TabIndex = 5;
            cmbOperacao.SelectedIndexChanged += cmbOperacao_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbOperacao);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lstResultado);
            Controls.Add(btnConfirma);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtnumero;
        private ListBox lstresultado;
        private Button btnConfirma;
        private ListBox lstResultado;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private ComboBox cmbOperacao;
       
    }
}
