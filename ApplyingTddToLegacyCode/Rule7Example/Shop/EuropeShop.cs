﻿using Rule7Example.Data;
using Rule7Example.Notifications;
using Rule7Example.Taxes;

namespace Rule7Example.Shop
{
    public class EuropeShop : Shop
    {
        private readonly IItemsRepository _itemsRepository;
        private readonly Taxes.Taxes _europeTaxes;
        private readonly INotifier _europeShopNotifier;

        public EuropeShop()
        {
            _itemsRepository = new ItemsRepository();
            _europeTaxes = new EuropeTaxes();
            _europeShopNotifier = new EuropeShopNotifier();
        }

        public override void CreateSale()
        {
            var items = _itemsRepository.LoadSelectedItems();
            var saleItems = items.ConvertToSaleItems();

            var cart = new Cart();
            cart.Add(saleItems);

            _europeTaxes.ApplyTaxes(cart);
            _europeShopNotifier.Send(cart);
            _itemsRepository.Save(cart);
        }
    }
}