using System;
using System.IO;

public class Journal {
    private string fileName;
    public string[] entries;

    public Journal(string fileName) {
        this.fileName = fileName;
    }

    public void Load() {
        entries = File.ReadAllLines(fileName);
        
    }

    public void Display() {
        foreach (string entry in entries) {
            Console.WriteLine(entry);
        }
    }

    // trying to add save feature to Journal
    //public void Save(string prompt, Entry newEntry) {
    public void Save(List<string> entryList) {
        Console.WriteLine("What would you like to call the file?");
        string filename = Console.ReadLine();
                
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        File.AppendAllText(filename, Environment.NewLine);
        File.AppendAllText(filename, $"Date: {date} - ");
        foreach (string ent in entryList)
        {
            File.AppendAllText(filename, $"{ent}");
        }
    }
}
