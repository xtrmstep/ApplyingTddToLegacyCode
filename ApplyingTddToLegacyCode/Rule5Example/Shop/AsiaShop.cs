using Rule5Example.Data;
using Rule5Example.Taxes;

namespace Rule5Example.Shop
{
    public class AsiaShop : Shop
    {
        private readonly ItemsRepository _itemsRepository;
        private readonly AsiaTaxes _asiaTaxes;

        public AsiaShop()
        {
            _itemsRepository = new ItemsRepository();
            _asiaTaxes = new AsiaTaxes();
        }

        public override void CreateSale()
        {
            var items = _itemsRepository.LoadSelectedItems();

            var saleItems = items.ConvertToSaleItems();
            var cart = new Cart();
            cart.Add(saleItems);

            _asiaTaxes.ApplyTaxes(cart);

            _itemsRepository.Save(cart);
        }
    }
}