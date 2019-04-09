using Prism.Commands;
using System.Windows.Input;
using Xamarin.Forms;

namespace XF4Layouts
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			OpenListViewCommand = new DelegateCommand(OpenListView);
			OpenCollectionViewCommand = new DelegateCommand(OpenCollectionView);
			BindingContext = this;
			InitializeComponent();
		}

		public ICommand OpenListViewCommand { get; }

		public ICommand OpenCollectionViewCommand { get; }

		private void OpenListView()
		{
			Navigation.PushAsync(new ListViewPage());
		}

		private void OpenCollectionView()
		{
			Navigation.PushAsync(new CollectionViewPage());
		}

	}
}
