using System;
using Moq;
using Rule8Example.Notifications;
using Xunit;

namespace Rule8Example.Tests.Notifications
{
    public class EuropeShopNotifierTests
    {
        [Fact]
        public void Should_not_send_when_less_or_equals_to_1000()
        {
            // arrange
            var cart = new Cart();
            var fakeNotifier = new MockNotifier();
            var shopNotifier = new EuropeShopNotifier(fakeNotifier);

            // act
            shopNotifier.Send(cart);

            // assert
            Assert.False(fakeNotifier.IsNotified);
        }

        [Fact]
        public void Should_send_when_greater_than_1000()
        {
            // arrange
            var cart = new Cart();
            cart.Add(new[] {new SaleItem(new Item {Name = "Item 1", Price = 1001m})});
            var mockNotifier = new MockNotifier();
            var shopNotifier = new EuropeShopNotifier(mockNotifier);

            // act
            shopNotifier.Send(cart);

            // assert
            Assert.True(mockNotifier.IsNotified);
        }

        [Fact]
        public void Should_send_when_greater_than_1000_mocks()
        {
            // arrange
            var cart = new Cart();
            cart.Add(new[] { new SaleItem(new Item { Name = "Item 1", Price = 1001m }) });
            var mockNotifier = new Mock<INotifier>();
            var shopNotifier = new EuropeShopNotifier(mockNotifier.Object);

            // act
            shopNotifier.Send(cart);

            // assert
            mockNotifier.Verify(m => m.Send(It.IsAny<Cart>()), Times.Once());
        }

        public void Should_raise_exception_when_cannot_send()
        {
            
        }
    }
}
