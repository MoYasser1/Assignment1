using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_4
{
    public class RentalService
    {
        private List<Movie> movies;
        private List<Customer> customers;

        public RentalService()
        {
            movies = new List<Movie>();
            customers = new List<Customer>();
        }
        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public Movie FindMovie(string title)
        {
            return movies.Find(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
        public Customer FindCustomer(string name)
        {
            return customers.Find(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }

}
