using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Washer
    {
        public bool IsOn { get; set; }
        public int WaterTemperature { get; set; }
        public int Rpm { get; set; }
        public int WashTime { get; set; }
        public bool Rinsing { get; set; }

        public void Wash()
        {
            Console.WriteLine("Sur rur rur rur..");
        }
    }
}
