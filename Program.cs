using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace MathCase7
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = Math.Pow(9,17);
            decimal deResult = DecimalPower(9, 17);
            Console.WriteLine(result);
            Console.WriteLine(deResult);
        }
        
        static decimal DecimalPower(decimal a, decimal b)
        {
            decimal sum = a;
            for(decimal x = 1; x<b; x++){
                sum = sum * a;
            }
            return sum;
        }
    }
}