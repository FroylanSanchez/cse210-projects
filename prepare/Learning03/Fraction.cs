class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int topNumber)
    {
        _top = topNumber;
        _bottom = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }
    public string FractionPrint()
    {
        string FractionPrinted = ($"{_top}/{_bottom}");
        return FractionPrinted;
    }
    public double FractionDecimal()
    {
        return (double)_top / (double)_bottom;
    }

}