using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("A day at the beach", "Jim Gordon", 300);
        Video video2 = new Video("My Cosmere Theory", "Brando Sando", 1500);
        Video video3 = new Video("Brain Surgeon answers Twitter Questions", "Wired", 2467);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        
    }
}