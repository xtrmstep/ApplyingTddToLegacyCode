namespace Rule3Example.Taxes
{
    public class EuropeTaxes : Taxes
    {
        internal override SaleItem ApplyTaxes(Item item)
        {
            var saleItem = new SaleItem(item)
            {
                SalePrice = item.Price*1.2m
            };
            return saleItem;
        }

        internal override void ApplyTaxes(Cart cart)
        {
            if (cart.TotalSalePrice <= 300m) return;
            var exclusion = 30m/cart.SaleItems.Count;
            foreach (var item in cart.SaleItems)
                if (item.SalePrice - exclusion > 100m)
                    item.SalePrice -= exclusion;
        }
    }
}