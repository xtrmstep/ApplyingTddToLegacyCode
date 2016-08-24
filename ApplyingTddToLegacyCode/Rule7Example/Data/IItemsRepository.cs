using System.Collections.Generic;

namespace Rule7Example.Data
{
    public interface IItemsRepository
    {
        IList<Item> LoadSelectedItems();
        void Save(Cart cart);
    }
}