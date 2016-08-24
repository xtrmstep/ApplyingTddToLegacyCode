﻿using Rule8Example.Data;
using Rule8Example.Taxes;

namespace Rule8Example.Shop
{
    public class AsiaShop : Shop
    {
        private readonly IItemsRepository _itemsRepository;
        private readonly Taxes.Taxes _asiaTaxes;

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