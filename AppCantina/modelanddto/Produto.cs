using System;

namespace AppCantina.model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public String NomeProduto { get; set; }
        public Decimal Preco { get; set; }


        public override bool Equals(object obj)
        {
            var prod = (Produto) obj;
            
            return Codigo.Equals(prod.Codigo);
        }

        public override int GetHashCode()
        {
            return Codigo;
        }


    }
}
