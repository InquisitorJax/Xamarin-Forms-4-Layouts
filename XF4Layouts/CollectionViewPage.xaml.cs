
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF4Layouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CollectionViewPage : ContentPage
	{
		public CollectionViewPage ()
		{
			BindingContext = new SampleViewModel();
			InitializeComponent ();
		}
	}
}