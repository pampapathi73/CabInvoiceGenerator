using System;


namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to cabInvoie generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            InvoiceGenerator invoiceGenerator1 = new InvoiceGenerator(RideType.PREMIUM);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            double fare1 = invoiceGenerator1.CalculateFare(5.0, 10);
            Console.WriteLine("Enter your choice[Normal/Premium]:\n");
            while (true)
            {
                Console.WriteLine("1.Total Fare for Normal\n2.Total Fare for Premium\n3.Exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine($"Total Fare: {fare}");
                        break;
                    case 2:
                        Console.WriteLine($"Total Fare: {fare1}");
                        break;
                    case 3:
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice! Please Enter the Correct Choice....");
                        break;
                }

            }

        }
    }
    
}