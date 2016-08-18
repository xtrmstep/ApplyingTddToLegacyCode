using System.Linq;
using Rule3Example.Notifications;
using Rule3Example.Taxes;

namespace Rule3Example.Shop
{
    public class EuropeShop : Shop
    {
        public override void CreateSale()
        {
            // 1) load from DB
            var items = LoadSelectedItemsFromDb();

            // 2) apply taxes
            var taxes = new EuropeTaxes();
            var saleItems = items.Select(item => taxes.ApplyTaxes(item)).ToList();

            // 3) create cart and apply taxes
            var cart = new Cart();
            cart.Add(saleItems);
            taxes.ApplyTaxes(cart);

            new EuropeShopNotifier().Send(cart);

            // 4) store to DB
            SaveToDb(cart);
        }
    }
}