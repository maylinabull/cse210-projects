using System;

public class Fractions

{
    private int _top;
    private int _bottom;
    
    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fractions(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // instructions said to create setters and getters for top and bottom but the sample doesn't have them?
    // were we supposed to delete them because the methods below work? 

    public string GetFractionString()
    {
        string fraction = ($"{_top}/{_bottom}");
        return fraction;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}

