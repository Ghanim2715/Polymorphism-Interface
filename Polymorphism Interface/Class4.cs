using System;
public class Canon : IPrinterWindows
{
    public override void show()
    {
        Console.WriteLine("Canon Display dimension : 9.5*12");
    }

    public override void print()
    {
        Console.WriteLine("Canon printer printing ...");
    }
}