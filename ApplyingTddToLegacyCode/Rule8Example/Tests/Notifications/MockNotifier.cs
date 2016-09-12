using Rule8Example.Notifications;

namespace Rule8Example.Tests.Notifications
{
    internal class MockNotifier : INotifier
    {
        public bool IsNotified { get; protected set; } = false;
        public void Send(Cart cart)
        {
            IsNotified = true;
        }
    }
}