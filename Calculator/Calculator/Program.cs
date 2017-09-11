using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math;

namespace Calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                Program.CalculationOutput();
            } while (Program.CalculationOutput());
        }

        public static bool CalculationOutput()
        {
            Console.Clear();
            Calc obj = new Calc();
            Console.WriteLine("Please select the operation\n1:Add\n2:Diff\n3:Divide\n4:Multiply");
            int x = 0;
            var y = Console.ReadLine();
            int.TryParse(y.ToString(), out x);
            switch (x)
            {
                case 0:
                    Console.WriteLine("Enter a numeric value");
                    break;

                case 1:
                    Console.WriteLine("Enter the numbers");
                    try
                    {
                        Console.WriteLine("The sum is " + obj.Add(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    { }
                    break;

                case 2:
                    Console.WriteLine("Enter the numbers");
                    try
                    {
                        Console.WriteLine("The Diff is " + obj.Diff(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    { }
                    break;

                case 3:
                    Console.WriteLine("Enter the numbers");
                    try
                    {
                        if (obj.Divide(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())) == -1)
                            Console.WriteLine("Cannot divide a number by zero");
                        else
                        {
                            Console.WriteLine("Result of division is " + obj.Divide(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    { }
                    break;

                case 4:
                    Console.WriteLine("Enter the numbers");
                    try
                    {
                        Console.WriteLine("The product is " + obj.Multiply(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    { }
                    break;
            }
            Console.WriteLine("Do you wish to perform any other operation?Yes:1\nNo:2");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}