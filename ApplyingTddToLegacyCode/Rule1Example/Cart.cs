using System.Collections.Generic;
using System.Linq;

namespace Rule1Example
{
    public class Cart
    {
        public List<SaleItem> SaleItems { get; } = new List<SaleItem>();

        public decimal TotalSalePrice
        {
            get { return SaleItems.Sum(i => i.SalePrice); }
        }

        internal void Add(IList<SaleItem> saleItems)
        {
            SaleItems.Clear();
            SaleItems.AddRange(saleItems);
        }
    }
}