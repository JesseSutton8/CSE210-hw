using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.CompilerServices;

public class Scripture {
    // member variable; AKA property or attribute.
    // private member variables are inaccessible to outside classes;
    // alternatively, public varibles are accessible to every class.
    private Reference reference; // real value
    
    // another member variable
    private string scriptureText;

    // list of words; declaration
    List<Word> words;

    public Scripture(string scripture, Reference reference) {
        this.reference = reference;
        this.scriptureText = scripture;

        // initialize list of words and separate scripture 
        words = new List<Word>();
        string[] split = this.scriptureText.Split(" "); // split up string by whitespace 
        // and make a list of strings
        // create a new word object for each string in the list
        foreach (string word in split)
        {
            Word wordObj = new Word(word);
            words.Add(wordObj); // append new word object to the list of word objects
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine(this.scriptureText);
    }

    public void HideWord()
    {
        Random random = new Random();
        int i = random.Next(words.Count);
        words[i].Hidden = true;
    }
}