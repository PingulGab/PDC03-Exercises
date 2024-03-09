using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryCell : ContentPage
    {
        public EntryCell()
        {
            InitializeComponent();

            tableview_entrycell_data.BindingContext = DataModel.PeopleCollection;
        }

        private async void Btn_Submit_Clicked (object sender, EventArgs e)
        {
            string UserFName = user_FName.Text;
            string UserAge = user_Age.Text;
            string UserFavorite = user_Favorite.Text;

            bool result = await DisplayAlert("Entered Values", $"First Name: {UserFName} \nAge: {UserAge} \nFavorite Korean Entertainer: {UserFavorite} \n\nAre you sure you want to submit?", "Confirm", "Cancel");

            if (result == true)
            {
                await DisplayAlert("Notification", "Submitted Successfully!", "Confirm");
            }
            else
            {
                await DisplayAlert("Notification", "Submission was cancelled!", "Confirm");
            }
        }
    }
}