using System.Runtime.InteropServices;

public class Reference {
    
    private string _book;
    public string getBook() {
        return _book;
    }
    public void setBook(string newBook) {
        _book = newBook;
    }

    private int _chapter;
    public int getChapter() {
        return _chapter;
    }
    public void setChapter(int newChapter) {
        _chapter = newChapter;
    }

    private int _verse;
    public int getVerse() {
        return _verse;
    }
    public void setVerse(int newVerse) {
        _verse = newVerse;
    }

    // Constructor for the Reference class
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public void DisplayReference() {
        Console.WriteLine($"{_book} {_chapter}:{_verse} \n");
    }
}