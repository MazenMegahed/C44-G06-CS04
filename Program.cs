using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session4_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // Write a program that takes a number from the user then print yes if that
            //number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("Enter A num ");
            //int num1 = int.Parse(Console.ReadLine());
            //if (num1 % 3 == 0 && num1 % 4 == 0)
            //{ Console.WriteLine("Yes"); }
            //else { Console.WriteLine("no"); }
            #endregion

            #region Q2
            //Write a program that allows the user to insert an integer then print
            //negative if it is negative number otherwise print positive.
            Console.WriteLine("Enter a Num");
            double num2 = double.Parse(Console.ReadLine());
            switch (num2)
            {
                case > 0:
                    Console.WriteLine("It is a Positive Number");
                    break;
                case < 0:
                    Console.WriteLine("It is a Negative  Number");
                    break;
                default:
                    Console.WriteLine("It is azero "); break;
            }


                    #endregion

            }
    }
}
