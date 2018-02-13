using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WillDo.Repository;

namespace WillDo.Services
{
    public class LocalDataStore : IDataStore<Item>
    {
        public LocalDataStore()
        {
        }

        public Task<bool> AddItemAsync(Item item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Item> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
