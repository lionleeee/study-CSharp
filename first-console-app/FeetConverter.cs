namespace first_console_app;


public static class FeetConverter
{
    public static readonly double Ratio = 0.3048;

    public static double FormMeter(double meter)
    {
        return meter / Ratio;
    }

    public static double ToMeter(double feet)
    {
        return feet * Ratio;
    }
    
}