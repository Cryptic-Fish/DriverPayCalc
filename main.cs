using System;


    public class Program
    {
        // Declare variables
        public int Miles { get; set; }
        public int Stores { get; set; }
        public int Rework { get; set; }
        public double Pay { get; set; }
        public double Calcpay { get; set; }
        public double CentsMile { get; set; }
        public int StopPay { get; set; }

        // Method to display the welcome message
        static void Entry()
        {
            Console.WriteLine("Welcome to the Pay Calculator!");
            Console.WriteLine("Please enter the following information:");
            Console.WriteLine("----------------------------------------");
        }
        
        // Method to get the pay rate per mile from the user
        static double PayRate()
        {
            Console.WriteLine("What is your cents per mile?");
            double CentsMile = Convert.ToDouble(Console.ReadLine());
        
            return CentsMile;
            
        }
        // Method to get the pay rate per stop from the user
        static int GetStopPay()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("What is your pay per stop?");
            int StopPay = Convert.ToInt32(Console.ReadLine());
            return StopPay;
        }
        
        
        // Method to get the number of miles run by the user
        static int GetMiles()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("How many miles did you run this week?");
            int miles = Convert.ToInt32(Console.ReadLine());
            return miles;
        }

        // Method to get the number of stops by the user
        static int GetStops()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("How many stops did you have this week?");
            int stores = Convert.ToInt32(Console.ReadLine());
            return stores;
        }

        // Method to get the number of reworked stops by the user
        static int GetRework()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Did you have to rework any of your stops?");
            Console.WriteLine("Type yes or no");
            string input = Console.ReadLine(); // Store user's input

            if (input.ToLower() == "yes") 
            {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("How many stops did you have to rework?");
                int rework = Convert.ToInt32(Console.ReadLine());
                return rework; // Return the calculated rework value 
            } else {
                return 0; // Return 0 if no rework
            }
        }
       
        
        // Method to calculate the pay for the week using user input
        static double CalcPay(int miles, int stores, int rework, double Pay, double CentsMile, int StopPay)
        {
        return Pay = (miles * CentsMile) + (stores * StopPay) + (rework * 25);
        }

        // Method to display the pay for the  from user input
        static double DisplayPay(int miles, int stores, int rework,double Pay, double CentsMile, int StopPay)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Your pay for this week is: $" + Pay);
            Console.WriteLine("Thank you for using the Pay Calculator!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            return Pay;
        }

        
// Main method to run the program        
public static void Main(string[] args)
{
    // Create an instance of the Program class
    Program payCalculator = new Program();

    Program.Entry(); // Welcome message

    // Assign returned values from methods
    payCalculator.CentsMile = Program.PayRate();
    payCalculator.StopPay = Program.GetStopPay();
    payCalculator.Miles = Program.GetMiles();
    payCalculator.Stores = Program.GetStops();
    payCalculator.Rework = Program.GetRework();

    // Calculate pay and store it
    payCalculator.Pay = Program.CalcPay(payCalculator.Miles, payCalculator.Stores, payCalculator.Rework, payCalculator.Pay, payCalculator.CentsMile, payCalculator.StopPay);

    // Display the final pay amount
    Program.DisplayPay(payCalculator.Miles, payCalculator.Stores, payCalculator.Rework, payCalculator.Pay, payCalculator.CentsMile, payCalculator.StopPay);
}
        }