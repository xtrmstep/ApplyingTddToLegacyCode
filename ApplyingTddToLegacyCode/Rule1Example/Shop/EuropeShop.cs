using System.Linq;
using Rule1Example.Taxes;

namespace Rule1Example.Shop
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

            // TODO > NEW FEATURE > Send notification to accounting if cart total amount exceeds 1000
            // 1) how to test this new feature?
            // 2) how to add new code?

            SaveToDb(cart);
        }
    }
}