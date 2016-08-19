using Rule5Example.Data;
using Rule5Example.Notifications;
using Rule5Example.Taxes;

namespace Rule5Example.Shop
{
    public class EuropeShop : Shop
    {
        public override void CreateSale()
        {
            var itemsRepository = new ItemsRepository();
            var items = itemsRepository.LoadSelectedItems();

            var saleItems = items.ConvertToSaleItems();

            var cart = new Cart();
            cart.Add(saleItems);

            new EuropeTaxes().ApplyTaxes(cart);

            new EuropeShopNotifier().Send(cart);

            itemsRepository.Save(cart);
        }
    }
}