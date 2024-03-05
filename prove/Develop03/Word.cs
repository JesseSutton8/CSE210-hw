public class Word {

    private string _word;
    public string GetWord() {
        return _word;
    }
    public void SetWord(string newWord) {
        _word = newWord;
    }

    private bool _hidden;
    public bool GetHidden() {
        return _hidden;
    }
    public void SetHidden(bool newHidden) {
        _hidden = newHidden;
    }

    public Word(string text)
    {
        _word = text;
        _hidden = false;
    }
}