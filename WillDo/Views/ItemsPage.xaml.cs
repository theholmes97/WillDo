using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WillDo.Repository.Models;
using WillDo.ViewModels;

using Xamarin.Forms;

namespace WillDo
{
    public partial class ItemsPage : ContentPage
    {
        GoalsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new GoalsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Goal;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new GoalDetailViewModel(item)));

            // Manually deselect item
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewItemPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

                if (viewModel.Goals.Count == 0)
                    viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
