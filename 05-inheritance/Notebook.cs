using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Notebook : Computer
{
    bool _fingerScan;

    public Notebook(bool fingerScan)
    {
        _fingerScan = fingerScan;
    }

    public void HasFingerScanDevice()
    {
        if (_fingerScan)
        {
            Console.WriteLine("FingerScan installed!");
        }
        else
        {
            Console.WriteLine("FingerScan not installed!");
        }
    }

    public void CloseLid()
    {
        if (powerOn == true)
        {
            Shutdown();
        }
    }
}