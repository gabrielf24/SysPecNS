using NcMaster;
using Org.BouncyCastle.Ocsp;
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
                dtpDataNasCliente.Value,
                dtpDataCadastro.Value
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
                txtIdClienteEndereco.Text = cliente.Id.ToString();
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

        private void mxtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtIdCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserirEnderecoCli_Click(object sender, EventArgs e)
        {
            Endereco endereco = new(
                mxtCep.Text,
                txtLogradouro.Text,
                txtNumero.Text,
                txtComplemento.Text,
                txtBairro.Text,
                txtCidade.Text,
                txtUf.Text,
                cmbTipoEndereco.Text
                );
            string tipo = cmbTipoEndereco.Text;
            string sigla = tipo.Substring(0, 3);
            mxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mxtCep.Text.Length == 8)
            {
                WebCEP webCEP = new(mxtCep.Text);
                txtLogradouro.Text = $"{webCEP.TipoLagradouro} {webCEP.Lagradouro}";
                txtBairro.Text = webCEP.Bairro;
                txtCidade.Text = webCEP.Cidade;
                txtUf.Text = webCEP.UF;
                txtNumero.Focus();
                endereco.Inserir();

             }
            if (endereco.Id > 0)
            {
                txtIdEndereco.Text = endereco.Id.ToString();
                MessageBox.Show($"O endereço foi inserido com sucesso, com o ID {endereco.Id}");
                txtIdEndereco.Clear();
                txtIdClienteEndereco.Clear();
                mxtCep.Clear();
                txtLogradouro.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtUf.Clear();
                txtNumero.Clear();
                FrmCliente_Load(sender, e);
            }

            else
            {
                MessageBox.Show("Falha ao gravar o endereço!");
            }
        
            







        }

        private void dtpDataCadastro_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
