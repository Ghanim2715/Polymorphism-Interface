using System;
public class LaserJet : IPrinterWindows
{
    public override void show()
    {
        Console.WriteLine("Laserjet Display dimension : 12*12");
    }

    public override void print()
    {
        Console.WriteLine("LaserJet printer printing ...");
    }
}