using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorV3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool moreCalc = true;
            while (moreCalc)
            {
                PrintCalc PC = new PrintCalc();
                int ch, i = 1;
                while (i == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\n *************************");
                    Console.WriteLine("\n   SIMPLE CALCULATOR.");
                    Console.WriteLine("\n *************************");
                    Console.WriteLine("\n 1-----> ADDITION");
                    Console.WriteLine("\n 2-----> SUBTRACTION");
                    Console.WriteLine("\n 3-----> MULTIPLICATION");
                    Console.WriteLine("\n 4-----> DIVISION");
                    Console.WriteLine("\n 5-----> EXIT");
                    Console.WriteLine("\n *************************");
                    Console.Write("\n\n Enter your choice: ");
                    ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            PC.read();
                            PC.add();
                            break;
                        case 2:
                            PC.read();
                            PC.subtract();
                            break;
                        case 3:
                            PC.read();
                            PC.multiply();
                            break;
                        case 4:
                            PC.read();
                            PC.divide();
                            break;
                        case 5:
                            Environment.Exit(-1);
                            break;
                        default:
                            Console.WriteLine(" Sorry !!! Wrong  choice.");
                            break;
                    }
                    Console.Write("\n Press ENTER to Continue. ");
                    Console.ReadLine();
                }
                Console.WriteLine("\n Cannot continue... Bye");
            }
        }
        public class PrintCalc
        {
            double num1, num2;
            public void read()
            {
                Console.WriteLine("\n Enter any two numbers:");
                Console.Write("\n Number1 : ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("\n Number2 : ");
                num2 = double.Parse(Console.ReadLine());
            }
            public void add()
            {
                double sum = num1 + num2;
                Console.WriteLine("\n Result : ({0}) + ({1}) = {2}", num1, num2, sum);
            }
            public void subtract()
            {
                double diff = num1 - num2;
                Console.WriteLine("\n Result : ({0}) - ({1}) = {2}", num1, num2, diff);
            }
            public void multiply()
            {
                double prod = num1 * num2;
                Console.WriteLine("\n Result : ({0}) X ({1}) = {2}", num1, num2, prod);
            }
            public void divide()
            {
                double qt = num1 / num2;
                Console.WriteLine("\n Result : ({0}) / ({1}) = {2}", num1, num2, qt);
            }
        }
    }
}
