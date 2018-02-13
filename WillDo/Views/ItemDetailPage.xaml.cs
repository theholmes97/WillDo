using System;
using WillDo.Repository.Models;
using WillDo.ViewModels;
using Xamarin.Forms;

namespace WillDo
{
    public partial class ItemDetailPage : ContentPage
    {
        GoalDetailViewModel viewModel;

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Goal
            {
                Title = "New Goal",
                Description = "This is a goal description."
            };

            viewModel = new GoalDetailViewModel(item);
            BindingContext = viewModel;
        }

        public ItemDetailPage(GoalDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
    }
}
