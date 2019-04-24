﻿
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF4Layouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FlexLayoutPage : ContentPage
	{
		public FlexLayoutPage ()
		{
			BindingContext = new SampleViewModel();
			InitializeComponent ();
		}
	}
}