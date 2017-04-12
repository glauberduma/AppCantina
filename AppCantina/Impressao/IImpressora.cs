using System;
using System.Collections.Generic;
using AppCantina.model;

namespace AppCantina.Impressao
{
    public interface IImpressora
    {
        void Registrar(String impressora, IPrint objeto);
        void Imprimir(String impressora, IList<ItensVenda> itens, String totalRecebido);
    }
}
