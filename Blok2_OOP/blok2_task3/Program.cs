using System;
using System.Collections.Generic;
using System.IO;

namespace blok2_task3
{
    class Video
    {
        public string Name { get; set; }
        public string Сountry { get; set; }
        public int YearEdition { get; set; }
    }

    class Playlist
    {
        public List<Video> videos { get; set; } = new List<Video>();

        public void addPlaylist(string name, string country, int yearEdition)
        {
           
            videos.Add(new Video() {Name=name, Сountry=country, YearEdition=yearEdition });
            
        }

        public void dellPlaylist(int index)
        {
            videos.RemoveAt(index);
        }

        public void savePlaylist(Playlist playlist)
        {
           

            using (StreamWriter f = File.AppendText("C:/Users/Professional/Documents/C#_Testing/Blok2_OOP/blok2_task3/test.txt"))
            {
                foreach (Video video in playlist.videos)
                    f.WriteLine(video.Name + " " + video.Сountry + " " + video.YearEdition);
       
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //object creation
            Playlist playlist = new Playlist();

            playlist.videos.Add(new Video() { Name="sfgsdg", Сountry="sxdfgdsgDF", YearEdition=1324 });
            playlist.videos.Add(new Video() { Name = "RRfgsdg", Сountry = "sxdfgdsgDF", YearEdition = 1324 });
            playlist.videos.Add(new Video() { Name = "YYYysfgsdg", Сountry = "sxdfgdsgDF", YearEdition = 1324 });
            Console.WriteLine("Video content");

            //adding a new item to the list
            Console.WriteLine("Enter a title for the movie");
            string _name = Console.ReadLine();

            Console.WriteLine("Enter the name of the country");
            string _country = Console.ReadLine();

            Console.WriteLine("Enter the year of issue");
            int _yearEdition = int.Parse(Console.ReadLine());

            playlist.addPlaylist(_name, _country, _yearEdition);

            //Displays a list of video files
            Console.WriteLine("List of video files");
            foreach (Video playlist1 in playlist.videos)
                Console.WriteLine(playlist1.Name+" "+playlist1.Сountry+" "+playlist1.YearEdition);

            //remove a movie from its index from the list
            Console.WriteLine("Enter the movie number to delete");
            int index = int.Parse(Console.ReadLine());

            playlist.dellPlaylist(index);

            //Save a list of video files
            playlist.savePlaylist(playlist);

        }
    }
}
