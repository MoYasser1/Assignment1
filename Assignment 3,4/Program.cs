using Assignment_3_4;

class Program
{
    static void Main(string[] args)
    {
        RentalService rentalService = new RentalService();
        rentalService.AddMovie(new Movie("Inception", "Sci-Fi"));
        rentalService.AddMovie(new Movie("The Godfather", "Crime"));
        Customer john = new Customer("John");
        rentalService.AddCustomer(john);
        Movie movieToRent = rentalService.FindMovie("Inception");
        if (movieToRent != null)
        {
            john.RentMovie(movieToRent);
        }
        john.ListRentedMovies();
        john.ReturnMovie(movieToRent);
        john.ListRentedMovies();
    }
}