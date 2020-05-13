using System;
public class Epson : IPrinterWindows
{
    public override void show()
    {
        Console.WriteLine("Epson Display dimension : 10*11");
    }

    public override void print()
    {
        Console.WriteLine("Epson printer printing ...");
    }
}