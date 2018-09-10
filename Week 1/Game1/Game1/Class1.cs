using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class game
    {
        public string name;
        public int rating;
        private List<int> Ratings;

        public double price;
        public string desc;
        public string genre;

        public game(string name, double price, string desc, string genre)
        {
            this.name = name;
            this.price = price;
            this.desc = desc;
            this.genre = genre;
            this.Ratings = new List<int>();
        }

        void reviewgame(int Rating)
        {
            Ratings.Add(Rating);
            rating = Convert.ToInt32(Ratings.Average()); 

        }

    }
}
