using CoinFlipper.ViewModels;

namespace CoinFlipper.View;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
		BindingContext = new CoinViewModel();
	}
}