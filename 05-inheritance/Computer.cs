using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Computer
{
    protected bool powerOn;
    public void Boot()
    {
        Console.WriteLine("Booting...");
    }
    public void Shutdown()
    {
        Console.WriteLine("Shutting down...");
    }
    public void Reset()
    {
        Console.WriteLine("Resetting...");
    }
}