public class Word {
    private string wordText;
    public string WordText {
        get {return wordText;}
        set {wordText = value;}
    }
    private bool hidden;
    public bool Hidden {
        get {return hidden;}
        set {hidden = value;}
    }

    public Word(string text)
    {
        wordText = text;
        hidden = false;
    }
}