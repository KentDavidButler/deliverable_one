using System;
using System.Globalization;

namespace Deliverable_One
{
    class Program
    {
        static void Main(string[] args)
        {
            double average, total;
            double[] arrayValues = new double[3];
            String strTotal;

            arrayValues[0] = ValidDollarAmmount();
            arrayValues[1] = ValidDollarAmmount();
            arrayValues[2] = ValidDollarAmmount();

            Array.Sort(arrayValues);
            total = Math.Round((arrayValues[0] + arrayValues[1] + arrayValues[2]),2);
            average = Math.Round((total/3.0), 2);
            strTotal = total.ToString();

            Console.WriteLine("The Average is $" + average);
            Console.WriteLine("The Smallest Amount is $" + arrayValues[0]);
            Console.WriteLine("The Largest Amount is $" + arrayValues[2]);
            Console.WriteLine(" ");
            Console.WriteLine("So "+total+" would turn into the following:");
            Console.WriteLine("\t US: " + total.ToString("C0"));
            Console.WriteLine("\t Swedish: " + total.ToString("C2", new CultureInfo("sv-SE")));
            Console.WriteLine("\t Japanese: " + total.ToString("C0", new CultureInfo("ja-JP")));
            Console.WriteLine("\t Thai: " + total.ToString("C0", new CultureInfo("th-TH")));

            Console.Read();
        }
        private static double ValidDollarAmmount()
        {
            string dollars;
            Console.WriteLine("Please type in a Dollar Ammount");
            dollars = Console.ReadLine();
            bool validInput = true;

            //check that all characters are digits
            foreach (char c in dollars)
            {
                if (c == '.')
                {
                    validInput = true;
                }
                else if(!char.IsDigit(c) )
                {
                    validInput = false;
                    break;
                }
                else
                {
                    validInput = true;
                }
            }

            if (dollars == String.Empty)
            {
                Console.WriteLine("Thank you for typing nothing your ammount is set to $0.00");
                return 0.00;
            }
            else if (!validInput) 
            {
                Console.WriteLine("Thank you for typing nothing your ammount is set to $0.00");
                return 0.00;
            }
            else
            {
                Console.WriteLine("Thank you for typing in $" + Math.Round(Double.Parse(dollars), 2));
                return Math.Round(Double.Parse(dollars), 2);
            }
        }
    }
}
