using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WillDo.Repository.Barrels
{
    public interface IRepository<T>
    {
        /// <summary>
        /// Saves the data to the barrel.
        /// </summary>
        /// <returns>The data.</returns>
        /// <param name="item">Item.</param>
        /// <param name="duration">Duration.</param>
        Task<bool> SaveData(T item, decimal duration = 7);
        /// <summary>
        /// Gets the list data from the barrel
        /// </summary>
        /// <returns>The list data.</returns>
        Task<IEnumerable<T>> GetListData();
        /// <summary>
        /// Gets the item data from the barrel
        /// </summary>
        /// <returns>The item data.</returns>
        /// <param name="id">Identifier.</param>
        Task<T> GetItemData(int id);
        /// <summary>
        /// Removes the item data from the barrel
        /// </summary>
        /// <returns>The item data.</returns>
        /// <param name="items">Items.</param>
        Task<bool> RemoveItemData(IList<T> items);
    }
}
