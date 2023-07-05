using System;

class Program
{
    static void Main(string[] args)
    {
        //create Video and comment objects and add comments to comment list
        List<Comment> vid1Comms = new List<Comment>();
        List<Comment> vid2Comms = new List<Comment>();
        List<Comment> vid3Comms = new List<Comment>();


        Video video1 = new Video("A day at the beach", "Jim Gordon", 300, vid1Comms);
        Comment vid1Comm1 = new Comment("SpaceDig", "Would like to see more astrology in this.");
        Comment vid1Comm2 = new Comment("HelloKitty", "Why are there no cats in this video?");
        Comment vid1Comm3 = new Comment("PocketMan", "Good use of pocket sand.");

        vid1Comms.Add(vid1Comm1);
        vid1Comms.Add(vid1Comm2);
        vid1Comms.Add(vid1Comm3);

        Video video2 = new Video("My Cosmere Theory", "Brando Sando", 1500, vid2Comms);
        Comment vid2Comm1 = new Comment("Kaladin", "I don't think a surge could work that way. It doesn't use the right kind of investiture.");
        Comment vid2Comm2 = new Comment("SwordNimi", "But what happens if an allomancer eats a shardblade?!");
        Comment vid2Comm3 = new Comment("TheSurvivor", "I don't see how this would help me get my body back. 0 stars.");
        Comment vid2Comm4 = new Comment("HarmonyOrDiscord", "From the perspective of a shard, this is all very childish.");

        vid2Comms.Add(vid2Comm1);
        vid2Comms.Add(vid2Comm2);
        vid2Comms.Add(vid2Comm3);
        vid2Comms.Add(vid2Comm4);

        Video video3 = new Video("Brain Surgeon answers Twitter Questions", "Wired", 2467, vid3Comms);
        Comment vid3Comm1 = new Comment("Guy1234", "Still doesn't answer why my head always hurts.");
        Comment vid3Comm2 = new Comment("ScienceGuy28", "Great video! More Please!");
        Comment vid3Comm3 = new Comment("TheInfluencer", "DM me if you want to advertise. $$$$$!!!");

        vid3Comms.Add(vid3Comm1);
        vid3Comms.Add(vid3Comm2);
        vid3Comms.Add(vid3Comm3);

        //Add videos to video list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        //Display video information and comments to console
        Console.Clear();
        int count = 1;
        foreach (Video video in videos) {
            Console.Write($"Video #{count}: ");
            video.DisplayVideo();
            Console.WriteLine();
            count += 1;
        }
        
    }
}