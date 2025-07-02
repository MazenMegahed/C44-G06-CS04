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
            Console.WriteLine("Enter A num ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 % 3 == 0 && num1 % 4 == 0)
            { Console.WriteLine("Yes"); }
            else { Console.WriteLine("no"); }
            #endregion

        }
    }
}
