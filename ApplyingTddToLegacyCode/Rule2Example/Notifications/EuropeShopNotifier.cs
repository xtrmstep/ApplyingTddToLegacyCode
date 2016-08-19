using System;

namespace Rule2Example.Notifications
{
    public class EuropeShopNotifier : DefualtNotifier
    {
        public override void Send(Cart cart)
        {
            if (cart.TotalSalePrice <= 1000m) return;
            SendByEmail(cart);
        }

        private void SendByEmail(Cart cart)
        {
            // send cart information via SMPT
        }
    }
}