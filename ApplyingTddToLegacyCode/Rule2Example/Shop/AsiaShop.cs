﻿using System.Linq;
using Rule2Example.Taxes;

namespace Rule2Example.Shop
{
    public class AsiaShop : Shop
    {
        public override void CreateSale()
        {
            var taxes = new AsiaTaxes();
            var items = LoadSelectedItemsFromDb();
            var saleItems = items.Select(item => taxes.ApplyTaxes(item)).ToList();
            var cart = new Cart();
            cart.Add(saleItems);
            taxes.ApplyTaxes(cart);
            SaveToDb(cart);
        }
    }
}