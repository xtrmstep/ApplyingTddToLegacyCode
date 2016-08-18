using System.Linq;
using Rule2Example.Notifications;
using Rule2Example.Taxes;

namespace Rule2Example.Shop
{
    public class EuropeShop : Shop
    {
        public override void CreateSale()
        {
            var items = LoadSelectedItemsFromDb();
            var taxes = new EuropeTaxes();
            var saleItems = items.Select(item => taxes.ApplyTaxes(item)).ToList();
            var cart = new Cart();
            cart.Add(saleItems);
            taxes.ApplyTaxes(cart);

            // NEW FEATURE that could be tested with unit tests
            new EuropeShopNotifier().Send(cart);

            SaveToDb(cart);
        }
    }
}