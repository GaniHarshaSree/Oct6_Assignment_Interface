using System;
using Calculator;

namespace InterfaceDemo
{
    public class Calculate
    {
        static void Main(string[] args)
        {
            Maths calculator = new Maths();

            Console.WriteLine("Choose the Below option");
            Console.WriteLine("1. Addition \n 2. Subtraction \n 3.Multiplication \n 4. Divison \n 5. Divison With Remainder \n 6. Square Root");

            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.WriteLine("You Selected Addition :");
                    Console.WriteLine("Enter Number 1 :");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Number 2 :");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The Addition of {0} and {1} is {2}", n1, n2, calculator.Addition(n1, n2));

                    Console.Read();
                    break;

                case 2:
                    Console.WriteLine("You Selected Subtraction :");
                    Console.WriteLine("Enter Number 1 :");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Number 2 :");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The Subtraction of {0} and {1} is {2}", a, b, calculator.Subtraction(a, b));
                    Console.Read();
                    break;

                case 3:
                    Console.WriteLine("You Selected Multiplication :");
                    Console.WriteLine("Enter Number 1 :");
                    int a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Number 2 :");
                    int b1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The Multiplication of {0} and {1} is {2}", a1, b1, calculator.Multiply(a1, b1));
                    Console.Read();
                    break;

                case 4:
                    Console.WriteLine("You Selected Division :");
                    Console.WriteLine("Enter Number 1 :");
                    int a2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Number 2 :");
                    int b2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The Division of {0} and {1} is {2}", a2, b2, calculator.Division(a2, b2));
                    Console.Read();
                    break;

                case 5:
                    Console.WriteLine("You Selected Division With Remainder :");
                    Console.WriteLine("Enter Number 1 :");
                    int a3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Number 2 :");
                    int b3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The Division With Remainder of {0} and {1} is {2}", a3, b3, calculator.DivisionWithRem(a3, b3));
                    Console.Read();
                    break;

                case 6:
                    Console.WriteLine("You Selected Square Root :");
                    Console.WriteLine("Enter Number for Square Root :");
                    double n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The Square Root of {0} is {1}", n, calculator.SquareRootOfNumber(n));
                    Console.Read();
                    break;

                default:
                    Console.WriteLine("Wrong Choice");
                    Console.Read();
                    break;

            

            }
        }
    }
}
