namespace Rule3Example.Notifications
{
    public class EuropeShopNotifier : DefaultNotifier
    {
        public override void Send(Cart cart)
        {
            if (cart.TotalSalePrice <= 1000m) return;
            var emailSender = new EmailNotifier();
            emailSender.Send(cart);
        }
    }
}