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
    public partial class ImageCell : ContentPage
    {
        public ImageCell()
        {
            InitializeComponent();

            listview_imagecell_data.ItemsSource = DataModel.PeopleCollection;
        }
    }
}