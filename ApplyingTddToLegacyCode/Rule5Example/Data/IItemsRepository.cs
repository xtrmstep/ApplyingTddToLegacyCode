using System.Collections.Generic;

namespace Rule5Example.Data
{
    public interface IItemsRepository
    {
        IList<Item> LoadSelectedItems();
        void Save(Cart cart);
    }
}