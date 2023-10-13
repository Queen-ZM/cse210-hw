using System;
using System.Runtime.CompilerServices;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        //this is to get the fraction 
        _top = 1;
        _bottom = 1;
    } 

    public Fraction(int wholeNumber)
    {
        // This is to get a wholeNumber
        _top = wholeNumber;
        _bottom = 1; 
    }

    public Fraction(int  top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}


