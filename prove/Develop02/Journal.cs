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
}
