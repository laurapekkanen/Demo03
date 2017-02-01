using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class TV
    {
        public bool IsOn { get; set; }
        public int Channel { get; set; }
        public int Volume { get; set; }

        public void ChangeChannel()
        {
            Console.WriteLine("Change the channel:");
            int kanava = 0;
            string line = Console.ReadLine();
            kanava = int.Parse(line);
            switch (kanava)
            {
                case 1:
                    Console.WriteLine("Oh Ridge, but you are married to my sister!");
                    break;
                case 2:
                    Console.WriteLine("Seppo hei, pistä nuo mursuviikset piiloon ettei me jäädä heti kiinni!");
                    break;
                case 3:
                    Console.WriteLine("Hyvää iltaa. Hyvää iltaa. Tämän illan lottonumerot ovat: ");
                    break;
                default:
                    Console.WriteLine("There is no such channel!");
                    break;
            }
        }

        public void ChangeVolume()
        {

        }
        }
    }
