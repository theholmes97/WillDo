using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Realms;
using WillDo.Repository.Models;
using Xamarin.Forms;

namespace WillDo.ViewModels
{
    public class GoalsViewModel : BaseViewModel
    {
        public ObservableCollection<Goal> Goals { get; set; }
        public Command LoadItemsCommand { get; set; }

        private Realm _realm;

        public  GoalsViewModel()
        {
            _realm = Realm.GetInstance();
            Title = "Browse";
            Goals = new ObservableCollection<Goal>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Goal>(this, "AddItem", async (obj, item) =>
            {
                var _goal = item as Goal;
                Goals.Add(_goal);
                await DataStore.AddItemAsync(_goal);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Goals.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Goals.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;  
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
