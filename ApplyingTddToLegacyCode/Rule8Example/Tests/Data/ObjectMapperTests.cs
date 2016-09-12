using System.Collections.Generic;
using System.Linq;
using Rule8Example.Data;
using Xunit;

namespace Rule8Example.Tests.Data
{
    public class ObjectMapperTests
    {
        [Fact]
        public void Should_return_null_for_null()
        {
            IList<Item> list = null;
            Assert.Null(list.ConvertToSaleItems());
        }

        [Fact]
        public void Should_return_empty_for_empty()
        {
            var items = new List<Item>();
            var actual = items.ConvertToSaleItems();
            var expected = new List<SaleItem>();
            
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void Should_convert_items()
        {
            var items = new List<Item>(new[]
            {
                new Item {Name = "name1", Price = 100m},
                new Item {Name = "name2", Price = 200m}
            });
            var actual = items.ConvertToSaleItems();
            var expected = new List<SaleItem>(new[]
            {
                new SaleItem(new Item {Name = "name1", Price = 100m}),
                new SaleItem(new Item {Name = "name2", Price = 200m})
            });

            Assert.Equal(expected.Count, actual.Count);

            Assert.Equal(expected[0].Name, actual[0].Name);
            Assert.Equal(expected[0].Price, actual[0].Price);
            Assert.Equal(expected[0].SalePrice, actual[0].SalePrice);

            Assert.Equal(expected[1].Name, actual[1].Name);
            Assert.Equal(expected[1].Price, actual[1].Price);
            Assert.Equal(expected[1].SalePrice, actual[1].SalePrice);
        }
    }
}
