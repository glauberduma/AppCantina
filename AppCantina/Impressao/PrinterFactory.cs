using System;
using System.Collections;
using System.Collections.Generic;
using AppCantina.model;

namespace AppCantina.Impressao
{
    public abstract class PrinterFactory
    {
        private Hashtable  impressoras;

        protected PrinterFactory()
        {
            impressoras = new Hashtable();
        }

        protected void RegistrarImpressora(String impressora, IPrint objeto)
        {
            impressoras.Add(impressora.ToLower(),objeto);
        }

        protected void ImprimirCupon(String impressora, IList<ItensVenda> itens, String totalRecebido)
        {
            try
            {
                var print = (IPrint)impressoras[impressora.ToLower()];

                print.AbreCupom();
                print.VendeItens(itens);
                print.FechaCupom(totalRecebido);

            }
            catch (NullReferenceException ex)
            {
                
                throw new Exception("Impressora não registrada.");
            }

        }



    }
}
