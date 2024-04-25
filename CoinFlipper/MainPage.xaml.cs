namespace CoinFlipper
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

        }

        private void OnFlipClicked(object sender, EventArgs e)
        {
            int selectedIndex = Convert.ToInt32(PickerCoin.SelectedIndex);
            string selected = PickerCoin.Items[selectedIndex];
            Random rand = new Random();
            string[] options = ["Heads", "Tails"];
            int optionsIndex = rand.Next(options.Length);
            string last = options[optionsIndex];

            string source = last.ToLower() + ".png";
            ImgCoin.Source = source;

            if (selected == last)
            {
                WrongRight.Text = "You won";
            }
            else
            {
                WrongRight.Text = "You lost";
            }
        }
    }

}
