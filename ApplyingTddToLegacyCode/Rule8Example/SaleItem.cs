namespace Rule7Example
{
    public class SaleItem : Item
    {
        public SaleItem(Item item)
        {
            Name = item.Name;
            Price = item.Price;
            SalePrice = item.Price;
        }

        public decimal SalePrice { get; set; }
    }
}