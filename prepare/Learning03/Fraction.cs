public class Fraction
{
    // create attributes
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // Initialize number to 1/1
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        // 1 parameter for numerator
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        // 2 parameters for numerator an denominator
        _top = numerator;
        _bottom = denominator;
    }

    public string GetFractionString()
    {
        // create fraction getter 
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // create decimal getter
        return (double)_top / (double)_bottom;
    }
}