using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppCantina.model;

namespace AppCantina.Impressao
{
    public class Impressora : PrinterFactory, IImpressora
    {
        public void Registrar(String impressora, IPrint objeto)
        {
            RegistrarImpressora(impressora,objeto);
        }

        public void Imprimir(String impressora, IList<ItensVenda> itens, String totalRecebido)
        {
            ImprimirCupon(impressora,itens,totalRecebido);
        }

    }
}
