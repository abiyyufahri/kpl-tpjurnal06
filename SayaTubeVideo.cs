using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300121
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Contract.Requires(title.Length <= 200, "Judul video memiliki panjang maksimal 200 karakter.");
            Contract.Requires(title != null, "Judul video tidak berupa null.");

            Random random = new Random();
            this.id = random.Next(10000, 100000);
            this.title = title;
            this.playCount = 0;

            Contract.Ensures(this.playCount == 0);
        }

        public void IncreasePlayCount(int count)
        {
            Contract.Requires(count >= 0 && count <= 25000000,
                "Penambahan play count harus antara 0 hingga 25.000.000.");

            int oldPlayCount = this.playCount;

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Terjadi overflow saat menambah play count: " + e.Message);
            }

            Contract.Ensures(this.playCount >= oldPlayCount);
        }


        public void PrintVideoDetails()
        {
            Console.WriteLine("=== Detail Video ===");
            Console.WriteLine($"ID Video     : {this.id}");
            Console.WriteLine($"Judul Video  : {this.title}");
            Console.WriteLine($"Play Count   : {this.playCount}");
            Console.WriteLine("====================");
        }

        //Getter untuk kebutuhan soal
        public int getPlayCount()
        {
            return this.playCount;
        }

        //Getter untuk kebutuhan soal
        public string getTitle()
        {
            return this.title;
        }
    }
}
