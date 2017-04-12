using System;

namespace AppCantina.model
{
    public class ItensVenda
    {
        public int ItemId { get; set; }
        public String Produto { get; set; }
        public int Quantidade { get; set; }
        public Decimal ValorUnitario { get; set; }
        public Decimal ValorTotal { get; set; }


        public override bool Equals(object obj)
        {
            var item = (ItensVenda) obj;
            return ItemId.Equals(item.ItemId);
        }


        public override int GetHashCode()
        {
            return ItemId;
        }

    }
}
