namespace Rule8Example.Taxes
{
    public class EuropeTaxes : Taxes
    {
        public override void ApplyTaxes(Cart cart)
        {
            ApplyToItems(cart);
            ApplyToCart(cart);
        }

        private void ApplyToItems(Cart cart)
        {
            foreach (var item in cart.SaleItems)
                item.SalePrice = item.Price*1.2m;
        }

        private void ApplyToCart(Cart cart)
        {
            if (cart.TotalSalePrice <= 300m) return;
            var exclusion = 30m / cart.SaleItems.Count;
            foreach (var item in cart.SaleItems)
                if (item.SalePrice - exclusion > 100m)
                    item.SalePrice -= exclusion;
        }
    }
}