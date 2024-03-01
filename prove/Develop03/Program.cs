using System;

class Program
{
    static void Main(string[] args)
    {
        string text = "And it shall come to pass, that if the Gentiles shall hearken unto the Lamb of God in that day that he shall manifest himself unto them in word, and also in power, in very deed, unto the taking away of their stumbling blocks-";
        string book = "1 Nephi";
        int chapter = 14;
        int verse = 1;

        Reference reference = new Reference(book, chapter, verse);

        Scripture scripture = new Scripture(text, reference);

        // Print the scripture
        Console.WriteLine(scripture.ScriptureText);
    }
}