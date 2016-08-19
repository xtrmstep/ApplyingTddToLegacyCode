namespace Rule5Example.Taxes
{
    public class AsiaTaxes : Taxes
    {
        internal override void ApplyTaxes(Cart cart)
        {
            if (cart.TotalSalePrice <= 200m) return;
            var exclusion = 10m/cart.SaleItems.Count;
            foreach (var item in cart.SaleItems)
                item.SalePrice -= exclusion;
        }
    }
}