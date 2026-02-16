using System;

class Song
{
    public string title;
    public string artist;
    public double duration;

    public Song()
    {
        title = "Unknown";
        artist = "Unknown";
        duration = 0;
    }

    public Song(string title, string artist)
    {
        this.title = title;
        this.artist = artist;
        this.duration = 0;
    }

    public Song(string title, string artist, double duration)
    {
        this.title = title;
        this.artist = artist;
        this.duration = duration;
    }

    public void DisplaySong()
    {
        Console.WriteLine($"{title,-20} {artist,-15} {duration:F2}");
    }

}

class Program
{
    static void Main()
    {
        Console.Write("Songs to add: ");
        int numSongs = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Song[] playlist = new Song[numSongs];

        for (int i = 0; i < numSongs; i++)
        {
            Console.WriteLine($"Song #{i + 1}");

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Artist: ");
            string artist = Console.ReadLine();

            Console.Write("Duration (minutes): ");
            double duration = double.Parse(Console.ReadLine());

            Console.WriteLine();

            playlist[i] = new Song(title, artist, duration);
        }

        Console.WriteLine("=== || MY PLAYLIST || ===");
        Console.WriteLine($"{"Title",-20} {"Artist",-15} {"Time"}");
        Console.WriteLine("------------------------------------------");

        double totalDuration = 0;

        foreach (Song song in playlist)
        {
            song.DisplaySong();
            totalDuration += song.duration;
        }

        double averageDuration = totalDuration / numSongs;

        Console.WriteLine();
        Console.WriteLine($"Total Duration: {totalDuration:F2} mins");
        Console.WriteLine($"Average Duration: {averageDuration:F2} mins");
    }
}
