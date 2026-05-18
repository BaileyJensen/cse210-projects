using System.Dynamic;
using System.Runtime.InteropServices;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction (int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;

        
    }

    public Fraction(int top, int bottom)
    {
        _bottom = bottom;
        _top = top;
        
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fullFraction = $"{_top}/{_bottom}";
        return fullFraction;
    }

    public double GetDecimalValue()
    {
        
        return (double)_top / (double)_bottom; ;
    }
}