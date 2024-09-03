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
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }
        private void npEstoqueMinimo(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            //carregando o combobox de categoria 
            var categorias = Categoria.ObterLista();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DisplayMember = "Nome";

            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int count = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[count].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[count].Cells[1].Value = produto.CodBar;
                dgvProdutos.Rows[count].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[count].Cells[3].Value = produto.Valor_unit;
                dgvProdutos.Rows[count].Cells[4].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[count].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[count].Cells[6].Value = produto.EstoqueMinimo;
                dgvProdutos.Rows[count].Cells[7].Value = produto.ClasseDesconto;
                dgvProdutos.Rows[count].Cells[8].Value = produto.DataCad;

                count++;

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new(txtCodBar.Text,txtDescricao.Text,
                double.Parse(txtValorunit.Text), txtUnidadeVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (int)npEstoqueMinimo.Value,double.Parse(txtDesconto.Text)
                );

            produto.Inserir();
            if (produto.Id > 0)
            {
                MessageBox.Show($"Produto gravado com sucesso com o ID {produto.Id}");
                FrmProduto_Load(sender, e);
            }

        }

        
    }
}
