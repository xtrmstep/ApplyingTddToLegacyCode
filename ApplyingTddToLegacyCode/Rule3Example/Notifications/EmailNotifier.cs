using System;

namespace Rule3Example.Notifications
{
    public class EmailNotifier : INotifier
    {
        public void Send(Cart cart)
        {
            var message = CreateMessage(cart);
            SendMessage(message);
        }

        private void SendMessage(string message)
        {
            // send via SMPT
        }

        private string CreateMessage(Cart cart)
        {
            return "Information about cart";
        }
    }
}