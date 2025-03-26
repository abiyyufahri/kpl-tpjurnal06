using modul6_103022300121;

SayaTubeUser sayaTubeUser = new SayaTubeUser("Abiyyu");
string nama = "Abiyyu";


SayaTubeVideo[] video = new SayaTubeVideo[10];

video = [
            new SayaTubeVideo($"Review Film Avengers Endgame oleh {nama}"),
            new SayaTubeVideo($"Review Film Avengers Infinity War oleh {nama}"),
            new SayaTubeVideo($"Review Film Dark oleh {nama}"),
            new SayaTubeVideo($"Review Film Avatar oleh {nama}"),
            new SayaTubeVideo($"Review Film Spiderman No Way Home oleh {nama}"),
            new SayaTubeVideo($"Review Film Guardian Of The Galaxy oleh {nama}"),
            new SayaTubeVideo($"Review Film Dune Part 1 oleh {nama}"),
            new SayaTubeVideo($"Review Film Dune Part 2 oleh {nama}"),
            new SayaTubeVideo($"Review Film Invincible oleh {nama}"),
            new SayaTubeVideo($"Review Film The Boys oleh {nama}"),
        ];

foreach (var vid in video)
{
    sayaTubeUser.AddVideo(vid);
}

sayaTubeUser.PrintAllVideoPlaycount();

