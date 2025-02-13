using System;

class Program
{
    static void Main(string[] args)
    {
        // Bob's program to manage information about cars
        string carBrand = "Toyota"; // Added missing semicolon

        Console.WriteLine("Enter the model of your car:");
        string carModel = Console.ReadLine();

        Console.WriteLine("Enter the year of manufacture of your car:");

        // Ensuring valid integer input
        int carYear;
        while (!int.TryParse(Console.ReadLine(), out carYear) || carYear > DateTime.Now.Year || carYear < 1886)
        {
            Console.WriteLine("Invalid input. Please enter a valid year:"); // Prevents unrealistic years
        }

        int carAge = DateTime.Now.Year - carYear; // Corrected calculation, ensuring valid subtraction

        // Displaying car information
        Console.WriteLine("\nCar Information:");
        Console.WriteLine("Car Brand: " + carBrand);
        Console.WriteLine("Car Model: " + carModel);
        Console.WriteLine("Car Age: " + carAge + " years old");

        // Example method to get a list of cars
        GetListOfCars();
    }

    static void GetListOfCars()
    {
        Console.WriteLine("\nList of Example Cars:");
        Console.WriteLine("1. Toyota Camry");
        Console.WriteLine("2. Honda Accord");
        Console.WriteLine("3. Ford Mustang");
    }
}
