using System.Collections.Generic;

namespace Rule7Example.Data
{
    public class ItemsRepository : IItemsRepository
    {
        public IList<Item> LoadSelectedItems()
        {
            // reads from DB
            return new List<Item>(new[]
            {
                new Item {Name = "Book", Price = 10},
                new Item {Name = "Book", Price = 10},
                new Item {Name = "Book", Price = 10},
                new Item {Name = "Book", Price = 10},
                new Item {Name = "Book", Price = 10}
            });
        }

        public void Save(Cart cart)
        {
            // store to DB
        }
    }
}