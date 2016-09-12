namespace Rule8Example.Notifications
{
    public class EuropeShopNotifier : DefaultNotifier
    {
        private readonly INotifier _emailSender;
        public EuropeShopNotifier(INotifier notifier)
        {
            _emailSender = notifier;
        }
        public override void Send(Cart cart)
        {
            if (cart.TotalSalePrice <= 1000m) return;
            _emailSender.Send(cart);
        }
    }
}