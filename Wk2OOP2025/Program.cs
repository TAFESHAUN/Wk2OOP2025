namespace Wk2OOP2025
{
    internal class Program
    {
        //Let make a small console application that:
        static void Main(string[] args)
        {
            //●	Asks for the users first name and stores it
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            //●	Asks for the users last name and stores it
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            //●	Concatenates both the first and last name into a full name variable
            string fullName = firstName + " " + lastName;
            //firstName = "John";
            string fullName2 = $"{firstName} {lastName}";

            //●	Asks the user for their age and converts the user input string into an int
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine()); //Convert.ToInt32(Console.ReadLine());

            //●	Declares a const variable with the current year
            const int currentYear = 2025;
            var currentYear2 = DateTime.Now.Year;

            //●	Prints these details back to the user
            Console.WriteLine($"Your full name is {fullName}. The year is {currentYear}");
            Console.WriteLine($"Your full name2 is {fullName2}. The year2 is {currentYear2}");
            //●	This project refers to everything you have learned thus far
            
            //END OF PROGRAM
            Console.ReadKey();  
        }
    }
}
