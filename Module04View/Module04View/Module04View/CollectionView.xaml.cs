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
	public partial class CollectionView : ContentPage
	{
		public CollectionView ()
		{
			InitializeComponent ();
			collectionview_data.ItemsSource = DataModel.PeopleCollection;
		}
	}
}