﻿using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;
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
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Notes = "test car", Description = "Some description", Color = Color.Black },
				new Car { Abbreviation = "BMW", Make="B.M.W", Name = "X5", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 10)), Color = Color.Purple },
				new Car { Abbreviation = "M", Make="Mercedes", Name = "AMG C Class", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 5)), Color = Color.CornflowerBlue},
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.Brown },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 3)), Color = Color.Orange },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.DarkBlue },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 7)), Color = Color.DarkOrange },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.OrangeRed },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 4)), Color = Color.Violet},
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 2)), Color = Color.DarkSalmon },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.Green },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 6)), Color = Color.GreenYellow},
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 3)), Color = Color.LawnGreen},
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = "Some description", Color = Color.SkyBlue },
				new Car { Abbreviation = "VW", Make="VolksWagen", Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 5)), Color = Color.LightCyan },
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
