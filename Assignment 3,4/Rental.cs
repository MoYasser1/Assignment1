using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_4
{
    public class Rental
    {
        private Customer customer;
        private Movie movie;
        private DateTime rentalDate;
        public Rental(Customer customer, Movie movie)
        {
            this.customer = customer;
            this.movie = movie;
            this.rentalDate = DateTime.Now;
        }
        public void DisplayRentalInfo()
        {
            Console.WriteLine($"Rental Info: {customer.Name} rented {movie.Title} on {rentalDate}");
        }
    }
}
