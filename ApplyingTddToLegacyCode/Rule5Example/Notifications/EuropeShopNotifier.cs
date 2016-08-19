namespace Rule5Example.Notifications
{
    public class EuropeShopNotifier : DefualtNotifier
    {
        public override void Send(Cart cart)
        {
            if (cart.TotalSalePrice <= 1000m) return;
            var emailSender = new EmailNotifier();
            emailSender.Send(cart);
        }
    }
}