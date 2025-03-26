using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300121
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string Username;

        public SayaTubeUser(string Username)
        {
            Random random = new Random();
            this.id = random.Next(10000, 100000);
            this.Username = Username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int count = 0;

            foreach (var video in uploadedVideos)
            {
                count += video.getPlayCount();
            }

            return count;
        }

        public void AddVideo(SayaTubeVideo video)
        { 
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User: {Username}");
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].getTitle()}");
            }
        }

    }
}
