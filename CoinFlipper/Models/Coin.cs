using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipper.Models
{
    public class Coin
    {
        public string Side { get; set; }

        public void Flip()
        {
            Random rand = new Random();
            string[] options = ["Heads", "Tails"];
            int optionsIndex = rand.Next(options.Length);
            Side = options[optionsIndex];
        }
    }
}
