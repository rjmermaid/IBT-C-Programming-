using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FinalExamPracticeTest
{
    class Program
    {
        static void FindMax()
        {
            Console.WriteLine("Enter 3 numbers");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double result = Math.Max(Math.Max(a, b), c);
            Console.WriteLine("The greatest is " + result.ToString(CultureInfo.InvariantCulture));
        }

        static void GetGrade()
        {
            Console.Write("\n");
            Console.WriteLine("Enter the grades");
            int quiz = int.Parse(Console.ReadLine());
            int midterm = int.Parse(Console.ReadLine());
            int final = int.Parse(Console.ReadLine());
            int avg = (quiz + midterm + final) / 3;

            if (avg >= 90) { Console.WriteLine("Your mark is A"); }
            else if (avg >= 70) { Console.WriteLine("Your mark is B"); }
            else if (avg >= 50) { Console.WriteLine("Your mark is C"); }
            else Console.WriteLine("Your mark is F");
        }

        static void GetDigitNum()
        {
            Console.Write("\n");
            Console.WriteLine("Enter a number");
            string num = Console.ReadLine();
            Console.WriteLine("It has " + num.Length.ToString() + " digits");
        }

        static void PrintAscii()
        {
            Console.Write("\n");
            for (int i = 1; i <= 122; i++)
            {
                Console.Write(" " + (char)i);
                if(i % 10 == 0)
                {
                    Console.Write("\n");
                }
            }
        }

        static void GetSpaceNum()
        {
            Console.Write("\n");
            Console.Write("\n");
            Console.WriteLine("Enter your text");
            string input = Console.ReadLine();
            int cnt = 0;
            string space;
            for(int i = 0; i < input.Length; i++)
            {
                space = input.Substring(i, 1);
                if(space == " ")
                {
                    cnt++;
                }
            }
            Console.WriteLine("It has " + cnt + " spaces in it");
        }


        static void Main(string[] args)
        {
            FindMax();
            GetGrade();
            GetDigitNum();
            PrintAscii();
            GetSpaceNum();
            Console.ReadKey();
        }
    }
}
