using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Security.Cryptography;
using System.Xml.Linq;
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
            //Console.WriteLine("Enter a Num");
            //double num2 = double.Parse(Console.ReadLine());
            //switch (num2)
            //{
            //    case > 0:
            //        Console.WriteLine("It is a Positive Number");
            //        break;
            //    case < 0:
            //        Console.WriteLine("It is a Negative  Number");
            //        break;
            //    default:
            //        Console.WriteLine("It is azero "); break;
            //}


            #endregion

            #region Q3
            //Write a program that takes 3 integers from the user then prints the max
            //element and the min element.
            //double[] array1 =new double[3];
            //double max = 0; double min = 0; 
            //for (int i = 0; i < array1.Length; i++) 
            //{ 
            //    Console.WriteLine("Enter Num "+(i+1));
            //    array1[i] = double.Parse(Console.ReadLine());
            //    if (i == 0) { max = min = array1[i]; }
            //    if (array1[i] >= max) { max = array1[i]; }
            //    else if(array1[i] <= min) { min = array1[i]; }
            //}
            //Console.WriteLine("Maximum = "+max);
            //Console.WriteLine("Minmum = " + min);

            #endregion

            #region Q4
            // Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("Enter a Num");
            //int num4=int.Parse(Console.ReadLine());


            //string result = (num4%2 ==0) switch
            //{
            //    true => "It is an Even Num",
            //    false => "It is an Odd Num"
            //};
            //Console.WriteLine(result);

            #endregion

            #region Q5
            //Write a program that takes character from the user then if it is a vowel
            //chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            //char[] vowel = new Char[] { 'a', 'e', 'i', 'o', 'u' };
            //Console.WriteLine("Enter a letter");
            //char c = char.Parse(Console.ReadLine());
            //if (vowel.Contains(c)) { Console.WriteLine("vowel"); }
            //else { Console.WriteLine("consonant"); }

            #endregion

            #region Q6
            // Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            Console.WriteLine("enter a positive num :");
            int target = int.Parse(Console.ReadLine());
            for (int i = 2; i < target; i++) 
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}
