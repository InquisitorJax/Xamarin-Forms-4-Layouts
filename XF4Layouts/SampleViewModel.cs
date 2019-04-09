using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace XF4Layouts
{
	public class SampleViewModel : BindableBase
	{
		public SampleViewModel()
		{
			BuildCars();
		}

		private void BuildCars()
		{
			Cars = new ObservableCollection<Car>
			{
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.White },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 5)), Color = Color.AntiqueWhite },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.AliceBlue},
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.Beige },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.Orange },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.DarkBlue },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.DarkOrange },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.OrangeRed },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.Violet},
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.DarkSalmon },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.Green },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.GreenYellow},
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.LawnGreen},
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.SkyBlue },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.LightCyan },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.PaleTurquoise },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.Purple },

			};
		}

		private ObservableCollection<Car> _cars;

		public ObservableCollection<Car> Cars
		{
			get { return _cars; }
			set { SetProperty(ref _cars, value); }
		}

	}
}
