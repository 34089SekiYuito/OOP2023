using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Song[] songs = new Song[2];
            songs[0] = new Song("ナンセンス文学", "Eve", 270);
            songs[1] = new Song("不法侵入", "ずっと真夜中でいいのに", 267);

            foreach (var song in songs) {
                Console.WriteLine("{0}  {1}  {2}:{3}", song.Title, song.ArtistName, song.Length / 60, song.Length % 60);
            }
        }
    }
}
