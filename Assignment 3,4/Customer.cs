using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_4
{
    public class Customer
    {
        private string name;
        private List<Movie> rentedMovies;
        public string Name
        {
            get { return name; }
        }
        public Customer(string name)
        {
            this.name = name;
            this.rentedMovies = new List<Movie>();
        }
        public void RentMovie(Movie movie)
        {
            if (movie.IsAvailable)
            {
                movie.Rent();
                rentedMovies.Add(movie);
            }
            else
            {
                Console.WriteLine($"{movie.Title} is not available.");
            }
        }
        public void ReturnMovie(Movie movie)
        {
            if (rentedMovies.Contains(movie))
            {
                movie.Return();
                rentedMovies.Remove(movie);
            }
            else
            {
                Console.WriteLine($"{Name} did not rent {movie.Title}.");
            }
        }

        // Method to list rented movies
        public void ListRentedMovies()
        {
            Console.WriteLine($"{Name}'s Rented Movies:");
            foreach (var movie in rentedMovies)
            {
                Console.WriteLine($"- {movie.Title} ({movie.Genre})");
            }
        }


    }
}
