﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.CustomerDataSource
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class CustomerDataSource { }
#else

	public class CustomerDataSource : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public CustomerDataSource()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/DataBindingToSampleCode;component/SampleData/CustomerDataSource/CustomerDataSource.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private Customers _Customers = new Customers();

		public Customers Customers
		{
			get
			{
				return this._Customers;
			}
		}
	}

	public class CustomersItem : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Name = string.Empty;

		public string Name
		{
			get
			{
				return this._Name;
			}

			set
			{
				if (this._Name != value)
				{
					this._Name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}

		private string _Company = string.Empty;

		public string Company
		{
			get
			{
				return this._Company;
			}

			set
			{
				if (this._Company != value)
				{
					this._Company = value;
					this.OnPropertyChanged("Company");
				}
			}
		}

		private string _Phone = string.Empty;

		public string Phone
		{
			get
			{
				return this._Phone;
			}

			set
			{
				if (this._Phone != value)
				{
					this._Phone = value;
					this.OnPropertyChanged("Phone");
				}
			}
		}

		private double _Rating = 0;

		public double Rating
		{
			get
			{
				return this._Rating;
			}

			set
			{
				if (this._Rating != value)
				{
					this._Rating = value;
					this.OnPropertyChanged("Rating");
				}
			}
		}

		private System.Windows.Media.ImageSource _Picture = null;

		public System.Windows.Media.ImageSource Picture
		{
			get
			{
				return this._Picture;
			}

			set
			{
				if (this._Picture != value)
				{
					this._Picture = value;
					this.OnPropertyChanged("Picture");
				}
			}
		}
	}

	public class Customers : System.Collections.ObjectModel.ObservableCollection<CustomersItem>
	{ 
	}
#endif
}