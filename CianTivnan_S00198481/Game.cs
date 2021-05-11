using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CianTivnan_S00198481
{
    public class Game
    {
        //properties
        public string Name { get; set; }
        public int CriticScore { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public int Price { get; set; }
        public string GameImage { get; set; }

        //constructors
        public Game() { }

        public Game(int price)
        {
            Price = price;
        }

        public Game(string name, int score, string desc, string platform, int price, string img)
        {
            Name = name;
            CriticScore = score;
            Description = desc;
            Platform = platform;
            Price = price;
            GameImage = img;
        }

        //decrease price method
        public int DecreasePrice(int change)
        {
            Price = Price - change;

            return this.Price;
        }
    }
}
