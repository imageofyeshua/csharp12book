using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Desktop : Computer
{
    bool _hasODD;
    bool _hasGC;

    public Desktop(bool hasODD)
    {
        _hasODD = hasODD;
    }

    public void HasODDDevice()
    {
        if (_hasODD)
        {
            Console.WriteLine("ODD installed!");
        }
        else
        {
            Console.WriteLine("ODD not installed!");
        }
    }

}