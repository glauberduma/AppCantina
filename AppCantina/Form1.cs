using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using AppCantina.Impressao;
using AppCantina.model;
using AppCantina.services;
using ExemploFiscal;

namespace AppCantina
{
    public partial class FormPrincipal : Form
    {

        private CantinaService service;
        private List<ItensVenda> itensVenda;
        private int registroEdicao = 0;
        private IImpressora print;

        

        public FormPrincipal()
        {
            InitializeComponent();
            service = new CantinaService();
            itensVenda = new List<ItensVenda>();

            InicializaImpressoras();

            PopularGrid();

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            service.CarregarProduto(ConfigurationManager.AppSettings["PRODUTOS"]);
        }



        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    btnNovaVenda_Click(sender, e);
                    break;
                case Keys.F5:
                    btnVenderItem_Click(sender, e);
                    break;
                case Keys.Delete:
                    btnDelete_Click(sender, e);
                    break;
                case Keys.F10:
                    btnEncerrarVenda_Click(sender, e);
                    break;

            }

        }

        #region Ações dos botões

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            if (itensVenda.Count > 0)
            {
                var confirm = MessageBox.Show("Iniciar uma nova venda e abandonar a venda atual ? ", "Nova venda", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes)
                {
                    return;
                }
            }
            NovaVenda();
        }


        private void btnVenderItem_Click(object sender, EventArgs e)
        {
            var form = new FormItem();

            form.injetarLista(itensVenda);
            form.ShowDialog();

            PopularGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ApagaItem(registroEdicao);
        }        




        private void gridItensVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            registroEdicao = int.Parse(gridItensVenda.Rows[e.RowIndex].Cells[0].Value.ToString());
        }


        private void btnEncerrarVenda_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Encerrando Venda:");

            var MyDLG = new FormDialog();
            MyDLG.Text = "Fechamento de Venda";
            MyDLG.LabelEditCaption.Text = "Valor Recebido R$";
            if ((MyDLG.ShowDialog(this) == DialogResult.OK) && (MyDLG.textBoxRetorno.Text != ""))
            {
                var valorRecebido = MyDLG.textBoxRetorno.Text + (!MyDLG.textBoxRetorno.Text.Contains(",") ? ",00" : "");

                decimal totalCompra;
                decimal vlRecebido;

                decimal.TryParse(txtTotal.Text, out totalCompra);
                decimal.TryParse(valorRecebido, out vlRecebido);

                decimal troco = vlRecebido - totalCompra;

                if (troco < 0)
                {
                    MessageBox.Show("ATENÇÃO:\nO valor recebido não pode ser menor que o valor da compra.");
                    return;
                }
                if (troco > 0)
                {
                    MessageBox.Show("ATENÇÃO:\nDevolver troco de R$" + troco.ToString("####.00"));
                }


                print.Imprimir(ConfigurationManager.AppSettings["IMPRESSORA"], itensVenda, valorRecebido);
                NovaVenda();
            }
        }


        #endregion

        #region Metodos auxiliares

        private void ApagaItem(int produto)
        {
            
            var query = from item in itensVenda where item.ItemId == produto select item;
            var itemVenda = query.FirstOrDefault();

            if (itemVenda == null)
            {
                return;
            }

            var confirm = MessageBox.Show("Apagar o item " + itemVenda.Produto + " ?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
            {
                return;
            }
            itensVenda.Remove(itemVenda);
            PopularGrid();
        }


        private void PopularGrid()
        {
            gridItensVenda.DataSource = null; //Limpa o grid;
            gridItensVenda.DataSource = service.ToDataTableFromItensVenda(itensVenda);
            gridItensVenda.Refresh();
            Totalizar();

            if (itensVenda.Count > 0)
            {
                registroEdicao = itensVenda[0].ItemId;
            }

        }


        private void Totalizar()
        {
            var query = from iten in itensVenda select iten.ValorTotal;
            var total = query.Sum();
            txtTotal.Text = total.ToString("####.00");
        }


        private void NovaVenda()
        {
            itensVenda = new List<ItensVenda>();
            PopularGrid();
        }


        private void InicializaImpressoras()
        {
            print = new Impressora();
            print.Registrar("bematec", new BematecPrint());
            print.Registrar("texto", new TextPrint());
        }

        #endregion

    }
}
