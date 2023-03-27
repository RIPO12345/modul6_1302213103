using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213103
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string videoTitle)
        {
            Random rand = new Random();
            id = rand.Next(10000, 99999);

            title = videoTitle;
            playCount= 0;
        }

        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("=========== Video Detail ========");
            Console.WriteLine("ID           : " + id);
            Console.WriteLine("Title        : " + title);
            Console.WriteLine("Play Count   : " + playCount);
        }
    }
}
