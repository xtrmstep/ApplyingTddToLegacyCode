using System.Linq;
using Rule1Example.Taxes;

namespace Rule1Example.Shop
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
            SaveToDb(cart);
        }
    }

    // TODO > NEW FEATURE > Send notification to accounting if cart total amount exceeds 1000
}