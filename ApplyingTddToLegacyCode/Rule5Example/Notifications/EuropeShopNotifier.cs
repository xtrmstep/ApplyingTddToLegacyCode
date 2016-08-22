namespace Rule5Example.Notifications
{
    public class EuropeShopNotifier : DefualtNotifier
    {
        private readonly EmailNotifier _emailSender;
        public EuropeShopNotifier()
        {
            _emailSender = new EmailNotifier();
        }
        public override void Send(Cart cart)
        {
            if (cart.TotalSalePrice <= 1000m) return;
            _emailSender.Send(cart);
        }
    }
}