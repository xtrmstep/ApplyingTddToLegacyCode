using System.Collections.Generic;

namespace Rule8Example.Data
{
    public interface IItemsRepository
    {
        IList<Item> LoadSelectedItems();
        void Save(Cart cart);
    }
}