using System.Linq;
using Rule1Example.Taxes;

namespace Rule1Example.Shop
{
    public class AsiaShop : Shop
    {
        public override void CreateSale()
        {
            var items = LoadSelectedItemsFromDb();
            var taxes = new AsiaTaxes();
            var saleItems = items.Select(item => taxes.ApplyTaxes(item)).ToList();
            var cart = new Cart();
            cart.Add(saleItems);
            taxes.ApplyTaxes(cart);
            SaveToDb(cart);
        }
    }
}