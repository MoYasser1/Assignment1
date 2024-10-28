using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_4
{
    public class Movie
    {
        private string title;
        private string genre;
        private bool isAvailable;
        public string Title
        {
            get { return title; }
        }
        public string Genre
        {
            get { return genre; }
        }
        public bool IsAvailable
        {
            get { return isAvailable; }
        }
        public Movie(string title, string genre)
        {
            this.title = title;
            this.genre = genre;
            this.isAvailable = true; 
        }
        public void Rent()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"{title} has been rented.");
            }
            else
            {
                Console.WriteLine($"{title} is already rented.");
            }

        }

        internal void Return()
        {
            throw new NotImplementedException();
        }
    }
}
