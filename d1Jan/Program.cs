using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d1Jan
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNum = 0, secNum = 0, thirNum = 0;
            string input;
            Console.WriteLine("Please input a dollar amount");
            input = Console.ReadLine();
            firstNum = float.Parse(input);
            Console.WriteLine("Please input a different dollar amount");
            input = Console.ReadLine();
            secNum = float.Parse(input);
            Console.WriteLine("Please input a third dollar amount");
            input = Console.ReadLine();
            thirNum = float.Parse(input);
            List<float> values = new List<float>();
            values.Add(firstNum);
            values.Add(secNum);
            values.Add(thirNum);
            values.Sum();
            Console.WriteLine("\nThe total amount is {0}", values.Sum());
            Console.WriteLine("The average amount is {0}", values.Average());
            Console.WriteLine("The smallest amount is {0}", values.Min());
            Console.WriteLine("The largest amount is {0}", values.Max());
            var usInfo = CultureInfo.GetCultureInfo("en-US");
            var sumUS = values.Sum().ToString("c", usInfo);
            Console.WriteLine("\nThe sum in US currency is: " + sumUS);
            var svInfo = CultureInfo.GetCultureInfo("sv");
            var sumSV = values.Sum().ToString("c", svInfo);
            Console.WriteLine("The sum in Swedish currency is: " + sumSV);
            var jaInfo = CultureInfo.GetCultureInfo("ja");
            var sumJA = values.Sum().ToString("c", jaInfo);
            Console.WriteLine("The sum in Japanese currency is: " + sumJA);
            var thInfo = CultureInfo.GetCultureInfo("th-TH");
            var sumTH = values.Sum().ToString("c", thInfo);
            Console.WriteLine("The sum in Thai currency is: " + sumTH);
            Console.ReadLine();
        }
    }
}
