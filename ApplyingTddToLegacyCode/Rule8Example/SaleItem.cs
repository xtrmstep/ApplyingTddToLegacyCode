namespace Rule8Example
{
    public class SaleItem : Item
    {
        private Item _item;

        public SaleItem(Item item)
        {
            _item = item;
        }

        public decimal SalePrice { get; set; }
    }
}