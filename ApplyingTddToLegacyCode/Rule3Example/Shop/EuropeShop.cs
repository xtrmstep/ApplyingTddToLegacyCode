using System.Collections.Generic;
using System.Linq;
using Rule3Example.Data;
using Rule3Example.Notifications;
using Rule3Example.Taxes;

namespace Rule3Example.Shop
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