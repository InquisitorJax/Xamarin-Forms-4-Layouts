using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XF4Layouts
{
	public class Car : BindableBase
	{
		private string _abbreviation;

		public string Abbreviation
		{
			get { return _abbreviation; }
			set { SetProperty(ref _abbreviation, value); }
		}

		private string _make;

		public string Make
		{
			get { return _make; }
			set { SetProperty(ref _make, value); }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { SetProperty(ref _name, value); }
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set { SetProperty(ref _description, value); }
		}

		private Color _color;

		public Color Color
		{
			get { return _color; }
			set { SetProperty(ref _color, value); }
		}

	}
}
