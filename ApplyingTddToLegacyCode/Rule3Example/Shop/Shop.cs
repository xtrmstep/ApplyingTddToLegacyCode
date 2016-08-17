using System;
using System.Collections.Generic;

namespace Rule3Example.Shop
{
    public class Shop
    {
        public virtual void CreateSale()
        {
            throw new NotImplementedException();
        }

        protected IList<Item> LoadSelectedItemsFromDb()
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

        protected virtual void SaveToDb(Cart cart)
        {
            // store to DB
        }
    }
}