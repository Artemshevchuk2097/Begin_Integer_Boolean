using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInteger
{
    class Program
    {
        public static double EnterValue()
        {
            Console.WriteLine("Enter temperature in Celsium:");
            string value = Console.ReadLine();
            double t_cels = double.Parse(value);
            return t_cels;
        }
        public static double  Temperature_conversion(double t_cels)
        {
            double t_far = (t_cels * (5 / 9)) + 32;
            return t_far;
        }

        public static void Print(double t_far)
        {
            Console.WriteLine("t_far = " + t_far);
        }
        static void Main(string[] args)
        {
            double t_cels = EnterValue();
            double t_far = Temperature_conversion(t_cels);
            Print(t_far);

        }
    }
}
