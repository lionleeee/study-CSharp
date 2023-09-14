// See https://aka.ms/new-console-template for more information

using first_console_app;


PrintFeetToMeterList(1,10);
PrintMeterToFeetList(1,10);

static void PrintFeetToMeterList(int start, int stop)
{
    for (int feet = start; feet <= stop; feet++)
    {
        double meter = FeetConverter.ToMeter(feet);
        Console.WriteLine("{0}  ft = {1:0.0000} m ", feet, meter);
    }
}

static void PrintMeterToFeetList(int start, int stop)
{
    for (int  meter= start; meter <= stop; meter++)
    {
        double feet = FeetConverter.FormMeter(meter);
        Console.WriteLine("{0}  ft = {1:0.0000} m ", meter, feet);
    } 
}


