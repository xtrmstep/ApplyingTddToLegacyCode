using System.Collections.Generic;

namespace Rule5Example.Data
{
    public class ItemsRepository
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

        internal void Save(Cart cart)
        {
            // store to DB
        }
    }
}