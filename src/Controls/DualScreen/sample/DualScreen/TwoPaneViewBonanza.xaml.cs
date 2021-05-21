using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.DualScreen;
using Microsoft.Maui.Controls.Xaml;

namespace DualScreen
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TwoPaneViewBonanza : ContentPage
	{
		public TwoPaneViewBonanza()
		{
			InitializeComponent();
			cvData.Scrolled += OnCVDataScrolled;
		}

		private void OnCVDataScrolled(object sender, ItemsViewScrolledEventArgs e)
		{
			foreach(var element in cvData.LogicalChildren.OfType<StackLayout>())
				element.Children[1].InvalidateMeasureNonVirtual(Microsoft.Maui.Controls.Internals.InvalidationTrigger.MeasureChanged);
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			cvData.ItemsSource =
				Enumerable.Range(0, 1000).ToList();
		}

		private void OnResetCollectionView(object sender, EventArgs e)
		{
			cvData.ItemsSource =
				Enumerable.Range(0, 1000).ToList();
		}
	}
}