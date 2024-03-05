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
    List<Word> words = new List<Word>();


    public Scripture(string scripture, Reference reference) {
        this.reference = reference;
        this.scriptureText = scripture;

        // We need to split up our big long string into individual words
        // which are treated separately from each other. 

        // initialize list of words and separate scripture 
        string[] stringsArray = this.scriptureText.Split(" "); // split up string by whitespace 
        
        // and make a list of strings
        // create a new word object for each string in the list
        foreach (string word in stringsArray)
        {
            Word wordObj = new Word(word);
            words.Add(wordObj); // append new word object to the list of word objects
        }
    }

    // Go through each word one by one and check if it's hidden. display 
    // accordingly.
    public void DisplayScripture()
    {
        reference.DisplayReference();

        foreach (Word word in words)
        {
           if (word.GetHidden() == false) // the word is not hidden
           {
                Console.Write(word.GetWord()); // in this case, print
                // the word text as normal.
           }
           else
           {
                // print one underscore for each letter in the word
                foreach (char letter in word.GetWord())
                {
                    Console.Write("_");
                }
           }
           Console.Write(" "); // put a whitespace between words
        }
    }

    public void HideWord()
    {
        int numWordsNotHidden = 0;

        // Count how many words are not hidden
        foreach (Word word in words)
        {
            if (word.GetHidden() == false)
            {
                numWordsNotHidden ++; // increment, or +1
            }
        }

        if (numWordsNotHidden >= 3)
        {
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                
                int wordIndex = 0;

                wordIndex = random.Next(0, words.Count);
                while (words[wordIndex].GetHidden() == true) {
                    wordIndex = random.Next(0, words.Count);
                }
                words[wordIndex].SetHidden(true);
            }
        }
        else {
            for (int i = 0; i < numWordsNotHidden; i++)
            {
                Random random = new Random();
                
                int wordIndex = 0;

                wordIndex = random.Next(0, words.Count);
                while (words[wordIndex].GetHidden() == true) {
                    wordIndex = random.Next(0, words.Count);
                }
                words[wordIndex].SetHidden(true);
            }
        }
    }
}