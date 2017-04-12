using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using AppCantina.model;

namespace AppCantina.services
{
    public class CantinaService
    {
        private static IList<Produto> _lista;
        
        
        public CantinaService()
        {
            if (_lista == null)
            {
                _lista = new Collection<Produto>();
            }
        }
        
        public static IList<Produto> getProdutos()
        {
            return _lista;
        }
        

        public void CarregarProduto(String arquivo)
        {
            var arquivoCarga = String.IsNullOrEmpty(arquivo) ? "produto.xml" : arquivo;
            var reader = new XmlTextReader(new StreamReader(arquivoCarga, Encoding.GetEncoding("utf-8")));
            var xml = XElement.Load(reader);
            foreach (XElement x in xml.Elements())
            {
                Decimal preco;
                Decimal.TryParse(x.Attribute("preco").Value, out preco);

                var objProduto = new Produto
                    {
                        Codigo = int.Parse(x.Attribute("codigo").Value),
                        NomeProduto = x.Attribute("nomeproduto").Value,
                        Preco = preco
                    };
                _lista.Add(objProduto);

                _lista = _lista.OrderBy(p => p.NomeProduto).ToList();
            }
            
        }

        public Produto GetProduto(int codigo)
        {
            var query = from prod in _lista where prod.Codigo == codigo  select prod;
            return query.FirstOrDefault();
        }

        public Produto GetProduto(String produto)
        {
            var query = from prod in _lista where prod.NomeProduto.ToLower() == produto.ToLower() select prod;
            return query.FirstOrDefault();
        }



        public DataTable ToDataTableFromItensVenda(List<ItensVenda> itensvenda)
        {
            var tabela = new DataTable {TableName = "ItensVenda"};

            var propriedades = typeof(ItensVenda).GetProperties();

            tabela.Columns.AddRange(
                propriedades.Select(p => new DataColumn(p.Name, (p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) 
                                                                                                                                           ? Nullable.GetUnderlyingType(p.PropertyType) 
                                                                                                                                           : p.PropertyType))).ToArray()
                );

            itensvenda.ForEach(venda => tabela.Rows.Add(venda.ItemId, venda.Produto, venda.Quantidade, venda.ValorUnitario, venda.ValorTotal));

            return tabela;
        }


    }
}
