using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_class;

public class Circle
{
    double pi = 3.14;

    public double PI
    {
        get { return pi; }
        set { pi = value; }
    }

    double GetArea(double radius)
    {
        return radius * radius * pi;
    }

    public void Print(double value)
    {
        Console.WriteLine(GetArea(value));
    }
}