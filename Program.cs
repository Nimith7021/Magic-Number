using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    internal class Program
    {
        const float mileToKilometres = 1.61f;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the miles you want to convert:");
            float miles = Convert.ToSingle(Console.ReadLine());
            ConvertionToKilomatres(miles);

        }

        static void ConvertionToKilomatres(float miles)
        {
            Console.WriteLine("The equivalent Kilometres is : " +miles*mileToKilometres);
            /*Here instead of the magic number 1.61 which is the factor , which when 
             * multiplied by miles will give the kilometres is replaced by the variable to improve the performance*/
        }
    }
}
