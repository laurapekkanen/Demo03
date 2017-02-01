using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            tv.IsOn = true;
            tv.Channel = 2;
            tv.Volume = 50;
            
            Console.WriteLine("Channel is " + tv.Channel);
            Console.WriteLine("Volume is " + tv.Volume);

            tv.ChangeChannel();
        }
    }
}
