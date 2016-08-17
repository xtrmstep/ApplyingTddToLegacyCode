namespace Rule3Example.Taxes
{
    public abstract class Taxes
    {
        internal abstract SaleItem ApplyTaxes(Item item);
        internal abstract void ApplyTaxes(Cart cart);
    }
}