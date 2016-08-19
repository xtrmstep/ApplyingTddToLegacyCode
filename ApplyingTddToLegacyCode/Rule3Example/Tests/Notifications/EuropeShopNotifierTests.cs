using Rule3Example.Notifications;

namespace Rule3Example.Tests.Notifications
{
    public class EuropeShopNotifierTests
    {
        public void Should_not_send_when_less_or_equals_to_1000()
        {
            // arrange
            var cart = new Cart();
            var notifier = new EuropeShopNotifier();
            // add items to cart

            // act
            notifier.Send(cart);

            // assert
            // PROBLEM: how to verify if we don't have access to the object?
        }

        public void Should_send_when_greater_than_1000()
        {

        }

        public void Should_raise_exception_when_cannot_send()
        {
            
        }
    }
}
