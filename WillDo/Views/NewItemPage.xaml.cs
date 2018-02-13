using System;
using WillDo.Repository.Models;
using Xamarin.Forms;

namespace WillDo
{
    public partial class NewItemPage : ContentPage
    {
        public Goal Goal { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Goal = new Goal
            {
                Title = "Goal name",
                Description = "This is a goal description."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Goal);
            await Navigation.PopToRootAsync();
        }
    }
}
