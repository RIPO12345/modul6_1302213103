using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213103
{
    internal class SayaTubeUser
    {
        private int id;
        private string title;
        private List<SayaTubeVideo>uploadVideos;
        public string Username;
        private int playCount;
        private SayaTubeVideo newVideo;

        public SayaTubeUser(string username)
        {
            this.Username= username;
            this.uploadVideos = new List<SayaTubeVideo>();

        }

        public int GetTotalVideoPlayCount()
        {
            return playCount;
        }

        public void AddVideo(SayaTubeVideo)
        {
            uploadVideos.Add(newVideo);
        }

        public void PrintAllVideoPlaycount(SayaTubeVideo video)
        {
            Console.WriteLine("User : " + id);
            Console.WriteLine("Video 1 judul : " + title);
            Console.WriteLine("Video 2 judul : " + title);
           
        }
    }
}
