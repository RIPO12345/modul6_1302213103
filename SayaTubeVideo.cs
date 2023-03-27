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
            playCount = 0;

            if (videoTitle == null || videoTitle.Length > 200)
            {
                throw new ArgumentException("Judul video harus berisi antara 1-200 karakter");
            }
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 25000000)
            {
                throw new ArgumentException("jumlah penambahan play count harus di antara 0-25000000");
            }
            try
            {
                playCount = checked(playCount + count);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
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
}
