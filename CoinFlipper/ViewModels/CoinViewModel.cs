using CoinFlipper.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;

namespace CoinFlipper.ViewModels;

public partial class CoinViewModel : ObservableObject
{
    [ObservableProperty]
    private string result;
    [ObservableProperty]
    private string image;
    [ObservableProperty]
    private string choice;

    public ICommand FlipCommand { get; }
    public CoinViewModel()
    {
        FlipCommand = new Command(Flip);
    }

    public void  Flip()
	{
		Coin coin = new Coin();
        coin.Flip();
		Result = Choice == coin.Side ? "You won" : "You lost";
	}


}