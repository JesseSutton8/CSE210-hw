using System;

public class Fraction {

    private int _top;
    private int _bottom;

    public int GetTop() {
        return _top;
    }
    public void SetTop(int newTop) {
        _top = newTop;
    }
    public void SetBottom(int newBottom) {
        _bottom = newBottom;
    }
    public int GetBottom() {
        return _bottom;
    }

    public Fraction() {
        SetTop(1);
        SetBottom(1);
    }

    public Fraction(int wholeNumber) {
        SetTop(wholeNumber);
        SetBottom(1);
    }

    public Fraction(int top, int buttom) {
        SetTop(top);
        SetBottom(buttom);
    }

    public string GetFractionString() {
        return $"{GetTop()}/{GetBottom()}";
    }

    public double GetDecimalValue() {
        return (double)GetTop() / (double)GetBottom();
    }

}