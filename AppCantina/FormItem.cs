using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppCantina.model;
using AppCantina.services;

namespace AppCantina
{
    public partial class FormItem : Form
    {
        public CantinaService servicosCantina;
        
        private IList<ItensVenda> itensVenda;

        public FormItem()
        {
            InitializeComponent();
            servicosCantina = new CantinaService();
        }

        public void injetarLista(IList<ItensVenda> lista)
        {
            itensVenda = lista;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            decimal vrUnit = 0;
            var selecionado = cmbProdutos.SelectedItem.ToString();
            
            var produto = servicosCantina.GetProduto(selecionado);
            if (produto != null)
            {
                vrUnit = produto.Preco;
            }

            var qtd = numericUpDown1.Value.ToString();
            var total = vrUnit * decimal.Parse(qtd);
            
            txtTotalItem.Text = total.ToString("####.00");
        }

        private void FormItem_Load(object sender, EventArgs e)
        {

            cmbProdutos.Items.Clear();

            foreach (var produto in CantinaService.getProdutos())
            {
                cmbProdutos.Items.Add(produto.NomeProduto);
            }

        }

        private void cmbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selecionado = cmbProdutos.SelectedItem.ToString();
            

            var produto = servicosCantina.GetProduto(selecionado);

            if (produto != null)
            {
                txtTotalItem.Text = produto.Preco.ToString("####.00");
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var selecionado = cmbProdutos.SelectedItem.ToString();

            var produto = servicosCantina.GetProduto(selecionado);

            decimal vrtotalitem;
            decimal.TryParse(txtTotalItem.Text, out vrtotalitem);
            

            var novoItem = new ItensVenda
                {
                    ItemId = produto.Codigo,
                    Produto = produto.NomeProduto,
                    Quantidade = (int)numericUpDown1.Value,
                    ValorUnitario = produto.Preco,
                    ValorTotal = vrtotalitem
                };

            var query = from item in itensVenda where item.ItemId == produto.Codigo select item;
            var result = query.FirstOrDefault();

            if (result != null)
            {
                itensVenda.Remove(novoItem);
            }
            itensVenda.Add(novoItem);
            Close();

        }

        private void FormItem_KeyDown(object sender, KeyEventArgs e)
        {
/*
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnOk_Click(sender, e);
                    break;
                case Keys.Escape:
                    btnCancelar_Click(sender, e);
                    break;
            }
 */ 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }




        

        

    }
}
