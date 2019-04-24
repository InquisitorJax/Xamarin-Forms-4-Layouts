
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF4Layouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PagedCollectionPage : ContentPage
	{
		public PagedCollectionPage ()
		{
			BindingContext = new SampleViewModel();
			InitializeComponent ();
		}
	}
}