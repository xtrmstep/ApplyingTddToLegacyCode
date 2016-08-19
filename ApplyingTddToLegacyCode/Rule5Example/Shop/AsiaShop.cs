using Rule5Example.Data;
using Rule5Example.Taxes;

namespace Rule5Example.Shop
{
    public class AsiaShop : Shop
    {
        public override void CreateSale()
        {
            var itemsRepository = new ItemsRepository();

            var items = itemsRepository.LoadSelectedItems();

            var saleItems = items.ConvertToSaleItems();
            var cart = new Cart();
            cart.Add(saleItems);

            new AsiaTaxes().ApplyTaxes(cart);

            itemsRepository.Save(cart);
        }
    }
}