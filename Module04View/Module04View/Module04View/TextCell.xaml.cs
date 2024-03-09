using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextCell : ContentPage
    {

        public TextCell()
        {
            InitializeComponent();
            listview_textcell_data.ItemsSource = DataModel.PeopleCollection;

        }

        private void Context_More_Clicked (object sender, EventArgs e)
        {
            DisplayAlert("Details", "There are no additional details for this selection.", "Confirm");
        }
    }
}