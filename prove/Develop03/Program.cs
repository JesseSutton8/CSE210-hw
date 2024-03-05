using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string scripture = "And it shall come to pass, that if the Gentiles shall hearken unto the Lamb of God in that day that he shall manifest himself unto them in word, and also in power, in very deed, unto the taking away of their stumbling blocks-";
        string book = "1 Nephi";
        int chapter = 14;
        int verse = 1;

        Reference reference = new Reference(book, chapter, verse);

        Scripture scriptureObj = new Scripture(scripture, reference);

        // Create a loop to continue hiding words until the user types "Quit"
        string input = "";
        while (input != "quit")
        {
            Console.Clear();
            // Print the scripture
            
            scriptureObj.DisplayScripture();

            Console.WriteLine("\n\nPress any key to continue or type 'quit' to finish: ");

            input = Console.ReadLine();
            
            // Now, check if the user pressed 'enter'
            if (input != "quit")
            {
                scriptureObj.HideWord();
            }
        }
    }
}