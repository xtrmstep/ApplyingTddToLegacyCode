namespace Rule3Example.Taxes
{
    public class AsiaTaxes : Taxes
    {
        internal override SaleItem ApplyTaxes(Item item)
        {
            var saleItem = new SaleItem(item)
            {
                SalePrice = item.Price*1.1m
            };
            return saleItem;
        }

        internal override void ApplyTaxes(Cart cart)
        {
            if (cart.TotalSalePrice <= 200m) return;
            var exclusion = 10m/cart.SaleItems.Count;
            foreach (var item in cart.SaleItems)
                item.SalePrice -= exclusion;
        }
    }
}