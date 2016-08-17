namespace Rule3Example.Notifications
{
    public class EuropeNotifier : DefualtNotifier
    {
        public override void Send(Cart cart)
        {
            if (cart.TotalSalePrice <= 1000m) return;
            var emailSender = new EmailNotifier();
            emailSender.Send(cart);
        }
    }
}