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
    public partial class SwitchCell : ContentPage
    {
        public SwitchCell()
        {
            InitializeComponent();
            listview_switchcell_data.ItemsSource = DataModel.PeopleCollection;
        }

        private void SwitchToggled(object sender, ToggledEventArgs e)
        {
            bool isToggledOn = e.Value;

            if (isToggledOn)
            {
                DisplayAlert("Switch Toggled On", "The switch is now turned on.", "Confirm");
            }

            else
            {
                DisplayAlert("Switch Toggled Off", "The switch is now turned off.", "Confirm");
            }
        }
    }
}