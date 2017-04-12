using System;
using System.Collections.Generic;
using AppCantina.model;

namespace AppCantina.Impressao
{
    public interface IPrint
    {
        void AbreCupom();
        void VendeItens(IList<ItensVenda> itens);
        void FechaCupom(String totalRecebido);
    }
}
