using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Washer washer = new Washer();
            washer.IsOn = true;
            washer.WaterTemperature = 40;
            washer.Rpm = 900;
            washer.Rinsing = false;
            washer.Wash();
            Console.WriteLine("Water Temperature is: " + washer.WaterTemperature);
            Console.WriteLine("Rounds per minute is: " + washer.Rpm);
            Console.WriteLine("Rinsing is: " + washer.Rinsing);

        }
    }
}
