using System;
using System.IO;

class Journal {
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

    // trying toadd save feature to Journal
    public void Save(string prompt, Entry newEntry) {
        Console.WriteLine("What would you like to call the file?");
        string filename = Console.ReadLine();
                
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        File.AppendAllText(filename, Environment.NewLine);
        File.AppendAllText(filename, $"Date: {date} - {prompt}");
        File.AppendAllText(filename, Environment.NewLine);
        File.AppendAllText(filename, $"{newEntry._writing}");
        File.AppendAllText(filename, Environment.NewLine);
    }
}
