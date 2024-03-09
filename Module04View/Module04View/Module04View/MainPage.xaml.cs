using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module04View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void HelpIcon_Clicked(object sender, EventArgs e)
        {
            if (sender == Btn_TextCell)
            {
                await DisplayAlert("Text Cell", "Opens a page containing a ListView with Text Cell.", "Confirm");
            }

            else if (sender == Btn_ImageCell)
            {
                await DisplayAlert("Image Cell", "Opens a page containing a ListView with Image Cell.", "Confirm");
            }

            else if (sender == Btn_SwitchCell)
            {
                await DisplayAlert("Switch Cell", "Opens a page containing a ListView with Switch Cell.", "Confirm");
            }

            else if (sender == Btn_EntryCell)
            {
                await DisplayAlert("Entry Cell", "Opens a page containing a ListView with Entry Cell.", "Confirm");
            }

            else if (sender == Btn_ContentView)
                await DisplayAlert("Content View", "Opens a page containing ContentView.", "Confirm");
        }

        private async void Btn_GoTo_Page (object  sender, EventArgs e)
        {
            if (sender == GoTo_TextCell)
            {
                await Navigation.PushAsync(new TextCell());
            }

            else if (sender == GoTo_ImageCell)
            {
                await Navigation.PushAsync(new ImageCell());
            }

            else if (sender == GoTo_SwitchCell)
            {  
                await Navigation.PushAsync(new SwitchCell());
            }

            else if (sender == GoTo_EntryCell)
            {
                await Navigation.PushAsync(new EntryCell());
            }

            else if (sender == GoTo_CollectionView)
            {
                await Navigation.PushAsync(new CollectionView());
            }
        }
    }
}
