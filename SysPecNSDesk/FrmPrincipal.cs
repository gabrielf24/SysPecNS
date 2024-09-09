using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new();
            //frmLogin.MdiParent = this;
            frmLogin.ShowDialog();
            Text += $" ({Program.UsuarioLogado.Email})";
            toolStripStatusLabel1.Text = $"{Program.UsuarioLogado.Nome} - {Program.UsuarioLogado.Nivel.Nome}";
        }

        private void produtosToolStripMenuItem_Click(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();

            //frmUsuario.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Desejá Sair?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (msg == DialogResult.Yes) Application.Exit();

        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new();
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }

        private void movimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPedidoNovo frmPedidonovo = new();
            frmPedidonovo.MdiParent = this;
            frmPedidonovo.Show();
        }
    }
}
