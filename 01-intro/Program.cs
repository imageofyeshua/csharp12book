namespace _01_intro;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduction : Data Types");

        int n1 = 50;
        int n2;
        n2 = 100;

        long sum = n1 + n2;
        Console.WriteLine(sum);

        System.SByte s1 = 12;
        System.Byte b1 = 125;
        System.Int16 i16 = 12500;
        System.UInt16 ui16 = 24000;
        System.Int32 i32 = 2500000;
        System.UInt32 ui32 = 12500000;

        long total = s1 + b1 + i16 + ui16 + i32 + ui32;
        Console.WriteLine(total);

        float f = 5.2f;
        double d = 10.5;
        decimal money = 200.099m;
        Console.WriteLine(f);
        Console.WriteLine(d);
        Console.WriteLine(money);

        System.Char ch = 'A';
        Console.WriteLine(ch);

        char ch1 = '\t';
        char ch2 = 'T';
        char ch3 = '\n';
        char ch4 = 'o';
        char ch5 = '\\';
        Console.Write(ch1);
        Console.Write(ch2);
        Console.Write(ch3);
        Console.WriteLine(ch4);
        Console.WriteLine(ch5);

        string text = "Hello Daniel";
        Console.WriteLine(text);

        string literal = @"\tHello\nDaniel";
        Console.WriteLine(literal);

        string h = "Hello";
        Console.WriteLine(h + " " + "Jason");

        System.Boolean isNumeric = false;
        Console.WriteLine(isNumeric);
    }
}
