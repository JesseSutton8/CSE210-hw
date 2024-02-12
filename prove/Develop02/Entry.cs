using System;
using System.IO;


public class Entry
{
    Journal Journal1 = new Journal();

    public void AddEntry() {
        Journal1._listOfPrompts.Add("Who was the most interesting person I interacted with today? ");
        Journal1._listOfPrompts.Add("What was the best part of my day? ");
        Journal1._listOfPrompts.Add("How did I see the hand of the Lord in my life today? ");
        Journal1._listOfPrompts.Add("What was the strongest emotion I felt today? ");
        Journal1._listOfPrompts.Add("If I had one thing I could do over today, what would it be? ");

        int promptCount = Journal1._listOfPrompts.Count();
        Random random = new Random();
        int randomNumber = random.Next(0, promptCount);

        Console.WriteLine(Journal1._listOfPrompts[randomNumber]);
        string prompt = Journal1._listOfPrompts[randomNumber];

        Console.WriteLine("Please write your entry here: ");
        string userEntry = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Journal1._listOfEntries.Add($"Date: {dateText} - {prompt} - {userEntry} ");
    }

    public void DisplayEntry() {
        foreach (string entry in Journal1._listOfEntries) {
            Console.WriteLine(entry);
        }
    }

    public void LoadFile(string fileName) {

        using (StreamReader reader = new StreamReader(fileName)) {
            string line;
            while ((line = reader.ReadLine()) != null) {
                Journal1._listOfEntries.Add(line);
            }
        }

    }

    public void SaveEntry(string fileName) {

        using (StreamWriter writer = new StreamWriter(fileName)) {

            foreach (string entry in Journal1._listOfEntries) {
                writer.WriteLine(entry);
            }

        }
    }
}