using System.Linq;
using Rule2Example.Notifications;
using Rule2Example.Taxes;

namespace Rule2Example.Shop
{
    public class EuropeShop : Shop
    {
        public override void CreateSale()
        {
            var taxes = new EuropeTaxes();
            var items = LoadSelectedItemsFromDb();
            var saleItems = items.Select(item => taxes.ApplyTaxes(item)).ToList();
            var cart = new Cart();
            cart.Add(saleItems);
            taxes.ApplyTaxes(cart);

            // NEW FEATURE that could be tested with unit tests
            new EuropeNotifier().Send(cart);

            SaveToDb(cart);
        }
    }
}