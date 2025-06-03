using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_class;

public class Person
{
    static public Person President;
    static private int CountOfInstance;
    string _name;

    public Person(string name)
    {
        CountOfInstance++;
        _name = name;
        Console.WriteLine("ctor executed");
    }

    static Person()
    {
        President = new Person("Lucifer");
        Console.WriteLine("cctor executed");
    }

    static public void OutputCount()
    {
        Console.WriteLine(CountOfInstance);
    }

    public void DisplayName()
    {
        Console.WriteLine(_name);
    }
}