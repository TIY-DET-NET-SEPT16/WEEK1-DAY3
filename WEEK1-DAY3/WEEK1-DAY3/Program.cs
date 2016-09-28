using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK1_DAY3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //bool keepLooping = true;
            //while (keepLooping)
            //{
            //    Console.WriteLine("I'm looping");
            //    Console.WriteLine("Loop again? (y/n)");
            //    string answer = Console.ReadLine();
            //    if (answer.Substring(0, 1).ToLower() == "n")
            //        keepLooping = false;
            //}

            //string answer = Console.ReadLine();
            //switch (answer)
            //{
            //    case "a":
            //        Console.WriteLine("You choose a");
            //        break;
            //    case "b":
            //        Console.WriteLine("you choose b");
            //        break;
            //    default:
            //        Console.WriteLine("you didn't choose a or b");
            //        break;
            //}

            //string[,] myMultiArray = new string[3, 2];

            //string t = myMultiArray[3, 2];

            #endregion

            for (int i = 0; i < 10; i++)
            {
                MyMethod(string.Format("Some string with a number {0}", i));
            }

            for (int i = 0; i < 10; i++)
            {
                int newNum = Square(i);
                Console.WriteLine(newNum);
            }

            int product = Multiply(5, 4);
            product = Multiply(2, 3);
            product = Multiply(2, 1);
            product = Multiply(2, 4);
            product = Multiply(2, 7);

            Console.ReadLine();
        }

        static void MyMethod(string stuff)
        {
            Console.WriteLine(stuff);
            Console.WriteLine("I'm inside MyMethod");
        }

        static int Square(int insideMethodVar)
        {
            int sq = insideMethodVar * insideMethodVar;
            return sq;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static string StringMethod()
        {
            Console.WriteLine("Hey there");
            return "I'm Done";
        }
    }
}
