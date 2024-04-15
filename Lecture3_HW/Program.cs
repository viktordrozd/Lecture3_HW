using System.ComponentModel;
using System.ComponentModel.Design;

namespace Lecture3_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Sort 3 real numbers in descending order. Use nested if statements.
            Console.WriteLine("Please enter the first real number:");
            double? num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second real number:");
            double? num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the third real number:");
            double? num3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"You've entered numbers: {num1}, {num2}, {num3}");


            if (num1 == num2 && num2 == num3 && num3 == num1)
            {
                Console.WriteLine($"Numbers {num1}, {num2}, {num3} are equal");
            }
            else if (num1 > num2 && num1 > num3)
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"The descending order is: {num1}, {num2}, {num3}");
                }
                else
                {
                    Console.WriteLine($"The descending order is: {num1}, {num3}, {num2}");
                }
            }
            else if (num2 > num1 && num2 > num3)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"The descending order is: {num2}, {num1}, {num3}");
                }
                else
                {
                    Console.WriteLine($"The descending order is: {num2}, {num3}, {num1}");
                }
            }
            else if (num3 > num1 && num3 > num2)
            {
                if (num1 > num2)
                {
                    Console.WriteLine($"The descending order is: {num3}, {num1}, {num2}");
                }
                else
                {
                    Console.WriteLine($"The descending order is: {num3}, {num2}, {num1}");
                }
            }


            // Write a program that asks for a digit (0 - 9), and depending on the input, shows the digit as a word(in English).Use a switch statement.

            Console.WriteLine("Please enter a digit between 0 and 9:");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 0:
                    Console.WriteLine("You've entered: Zero.");
                    break;
                case 1:
                    Console.WriteLine("You've entered: One");
                    break;
                case 2:
                    Console.WriteLine("You've entered: Two");
                    break;
                case 3:
                    Console.WriteLine("You've entered: Three");
                    break;
                case 4:
                    Console.WriteLine("You've entered: Four");
                    break;
                case 5:
                    Console.WriteLine("You've entered: Five");
                    break;
                case 6:
                    Console.WriteLine("You've entered: Six");
                    break;
                case 7:
                    Console.WriteLine("You've entered: Seven");
                    break;
                case 8:
                    Console.WriteLine("You've entered: Eight");
                    break;
                case 9:
                    Console.WriteLine("You've entered: Nine");
                    break;
            }




            // Write a program that finds the greatest of given 5 numbers.

            int? greatest = 0;

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine($"Enter integer:");
                int numNum = int.Parse(Console.ReadLine());

                if (numNum > greatest)
                {
                    greatest = numNum;
                }
            }
            
            Console.WriteLine($"The greatest number is: {greatest}");





            // Write a program that prints on the console the numbers from 1 to N.The number N should be read from the standard input.

            Console.WriteLine("Please enter an integer number: ");

            int digit = int.Parse(Console.ReadLine());


            if (digit > 0)
            {
                for (int i = 1; i <= digit; i++)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                for (int i = 1; i >= digit; i--)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
