namespace Rule2Example.Notifications
{
    public class EmailNotifier : INotifier
    {
        public void Send(Cart cart)
        {
            // send cart information via SMPT
        }
    }
}