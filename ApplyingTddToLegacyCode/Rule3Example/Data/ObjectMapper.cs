using System.Collections.Generic;
using System.Linq;

namespace Rule3Example.Data
{
    public static class ObjectMapper
    {
        public static IList<SaleItem> ConvertToSaleItems(this IList<Item> items)
        {
            return items.Select(i => new SaleItem(i)).ToList();
        }
    }
}