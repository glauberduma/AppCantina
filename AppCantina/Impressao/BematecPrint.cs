using AppCantina.model;
using FiscalPrinterBematech;
using System;
using System.Collections.Generic;

namespace AppCantina.Impressao
{
    public class BematecPrint : IPrint
    {
        private int _retorno;

        
        public void AbreCupom()
        {
            _retorno = BemaFI32.Bematech_FI_AbreCupom("");
            BemaFI32.Analisa_iRetorno(_retorno);
        }


        public void VendeItens(IList<ItensVenda> itens)
        {
            foreach (var iten in itens)
            {
                _retorno = BemaFI32.Bematech_FI_VendeItem(iten.ItemId.ToString(), iten.Produto, "FF", "I", iten.Quantidade.ToString(), 2, iten.ValorUnitario.ToString("####.00"), "%", "0");
                BemaFI32.Analisa_iRetorno(_retorno);
            }
        }

        public void FechaCupom(String totalRecebido)
        {
            _retorno = BemaFI32.Bematech_FI_IniciaFechamentoCupom("A", "%", "0");
            BemaFI32.Analisa_iRetorno(_retorno);
            _retorno = BemaFI32.Bematech_FI_EfetuaFormaPagamento("Dinheiro", totalRecebido);
            BemaFI32.Analisa_iRetorno(_retorno);
            _retorno = BemaFI32.Bematech_FI_TerminaFechamentoCupom("Parorquia NS das Dores");
            BemaFI32.Analisa_iRetorno(_retorno);

            
        }


    }
}
