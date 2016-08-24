using System.Collections.Generic;
using Rule7Example.Data;
using Rule7Example.Taxes;
using Xunit;

namespace Rule7Example.Tests.Taxes
{
    public class EuropeTaxesTests
    {
        public void Should_not_fail_for_null()
        {
            
        }

        public void Should_apply_taxes_to_items()
        {
            
        }

        public void Should_apply_taxes_to_whole_cart()
        {
            
        }

        public void Should_apply_taxes_to_whole_cart_and_change_items()
        {

        }

        [Fact]
        public void Should_apply_taxes_to_cart_greater_300()
        {
            #region arrange
            // list of items which will create a cart greater 300
            var saleItems = new List<Item>(new[]{new Item {Price = 83.34m},
                new Item {Price = 83.34m},new Item {Price = 83.34m}})
                .ConvertToSaleItems();
            var cart = new Cart();
            cart.Add(saleItems);

            const decimal expected = 83.34m*3*1.2m;
            #endregion

            // act
            new EuropeTaxes().ApplyTaxes(cart);

            // assert
            Assert.Equal(expected, cart.TotalSalePrice);
        }
    }
}
