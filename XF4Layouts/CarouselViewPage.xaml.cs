
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF4Layouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarouselViewPage : ContentPage
	{
		public CarouselViewPage ()
		{
			BindingContext = new SampleViewModel();
			InitializeComponent ();
		}
	}
}