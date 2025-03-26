using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            Contract.Requires(Username.Length <= 100, "Nama username memiliki panjang maksimal 100 karakter.");
            Contract.Requires(Username != null, "Nama username tidak berupa null.");

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
            Contract.Requires(video != null, "Video yang ditambahkan tidak berupa null.");
            Contract.Requires(video.getPlayCount() < int.MaxValue, "Video yang ditambahkan punya playCount yang kurang dari bilangan integer maksimum.");
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User: {Username}");
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].getTitle()}");
                Contract.Ensures(i <= 7);
            }
        }

    }
}
