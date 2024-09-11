using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace SysPecNSDesk
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnInserirCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(
                txtNomeCliente.Text,
                mxtCpfCliente.Text,
                mxtTelefoneCliente.Text,
                txtEmailCliente.Text,
                Convert.ToDateTime(dtpDataNasCliente.Text),
                Convert.ToBoolean(chkAtivo.Text)
                );
            mxtCpfCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mxtTelefoneCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                txtIdCliente.Text = cliente.Id.ToString();
                MessageBox.Show($"O cliente {cliente.Nome}, " +
                    $"foi inserido com sucesso, com o ID {cliente.Id}");
                txtIdCliente.Clear();
                txtNomeCliente.Clear();
                mxtCpfCliente.Clear();
                mxtTelefoneCliente.Clear();
                txtEmailCliente.Clear();
                txtNomeCliente.Focus();
                FrmCliente_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao gravar o cliente!");
            }

        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
