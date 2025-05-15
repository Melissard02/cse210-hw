using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    //Makin a list to hold our entry objects
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        Entry newEntry = new Entry();
        newEntry.CreateEntry();
        _entries.Add(newEntry);
    }




    //display all the journal entries so far to the terminal
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }

    }

    // //Create a function that saves the journal entries to a text file
    public void SaveJournal(string filename)
    {
        using (StreamWriter transcribe = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                transcribe.WriteLine(entry);
            }
        }
    }

    // //Create a function that selects the text file that will be manipulated
    public void LoadJournal(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(" - ");


                    Entry entry = new Entry();
                    entry.Date = DateTime.Parse(parts[0]);
                    entry.Prompt = parts[1];

                    string response = reader.ReadLine();
                    entry.Response = response;
                    _entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }

    public void SearchDate(string search)
    {
        if (DateTime.TryParse(search, out DateTime sDate))
        {
            bool found = false;
            foreach (Entry entry in _entries)
            {
                if (entry.Date.Date == sDate.Date)
                {
                    Console.WriteLine(entry);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No journal entry was found for this date");
            }
        }
        else
        {
            Console.WriteLine("Invalid date format. Use mm/dd/yyyy");
        }
        
        
    }

}