using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaTryCatchTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool formatValidCheck = false; // -> Key of loop
            while (!formatValidCheck) 
            {
                try
                {
                    Console.Write("Your number:");
                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Math.Pow(userNumber, 2)); // -> Taking square of number
                    formatValidCheck = true; // -> Open the key
                }
                catch (FormatException) // -> Format exception control
                {
                    Console.WriteLine("Wrong format. Please go for number!");

                }

                catch (Exception ex) // -> Any exception control
                {
                    Console.WriteLine("Wrong input process." + ex.Message);

                }
            }
        }
    }
}
