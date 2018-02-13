using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using WillDo.Repository.Models;
using Realms;

namespace WillDo.Services
{
    public class RealmDataStore : IDataStore<Goal>
    {
        Realm _realm;

        public RealmDataStore()
        {
            _realm = Realm.GetInstance();
        }

        public async Task<bool> AddItemAsync(Goal item)
        {
            try{
                await _realm.WriteAsync((Realm obj) => obj.Add(item));
                return true;
            }
            catch{
                return false;
            }
        }

        public async Task<bool> DeleteItemAsync(Goal item)
        {
            try
            {
                await _realm.WriteAsync((Realm obj) => obj.Remove(item));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<Goal> GetItemAsync(string id)
        {
            return await Task.FromResult(_realm.Find<Goal>(id));
        }

        public async Task<System.Collections.Generic.IEnumerable<Goal>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_realm.All<Goal>());
        }

        public async Task<bool> UpdateItemAsync(Goal item)
        {
            try
            {
                await _realm.WriteAsync((Realm obj) => obj.Add(item, true));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
