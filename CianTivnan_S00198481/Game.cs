using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CianTivnan_S00198481
{
    public class Game
    {
        //properties
        [Key]
        public string Name { get; set; }
        public int CriticScore { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public decimal Price { get; set; }
        public string GameImage { get; set; }

        //constructors
        public Game() { }

        public Game(decimal price)
        {
            Price = price;
        }

        public Game(string name, int score, string desc, string platform, decimal price, string img)
        {
            Name = name;
            CriticScore = score;
            Description = desc;
            Platform = platform;
            Price = price;
            GameImage = img;
        }

        //decrease price method
        public decimal DecreasePrice(decimal change)
        {
            Price = Price - change;

            return this.Price;
        }
    }

    public class GameData:DbContext
    {
        public GameData() : base("ExamGameData") { }

        public DbSet<Game> Games { get; set; }
    }
}
