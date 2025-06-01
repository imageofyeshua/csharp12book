using System.Linq.Expressions;

namespace _03_control;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Control!");

        int value = 6;
        int n = value % 3;
        bool result = (n == 0);
        Console.WriteLine(result);

        int number = 24;
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int ctr = 0; ctr < arr.Length; ctr++)
            Console.WriteLine($"{number} can be divided by {arr[ctr]} ? {(number % arr[ctr] == 0 ? "True" : "False")}");

        int m;
        for (m = 1; m <= 9; m++)
        {
            Console.WriteLine(m);
        }

        int k = 1;
        for (; k <= 9; k++)
        {
            Console.WriteLine(k * 2);
        }

        int l = 1;
        for (; ; l++)
        {
            if (l > 20) break;
            Console.WriteLine(l * l);
        }

        int[] arr2 = new int[] { 3, 6, 9, 12, 15, 18 };

        foreach (int elem in arr2)
        {
            Console.Write(elem + ", ");
        }

        int sum = 0;
        int num = 1;

        while (num <= 1000)
        {
            if (num % 2 == 0)
            {
                sum += num;
            }
            num++;
        }
        Console.WriteLine($"\nsum of even numbers: {sum}");

        sum = 0;
        do
        {
            if (num % 3 == 0) sum += num;
        } while (--num >= 0);

        Console.WriteLine($"sum of numbers divisible by 3: {sum}");

        sum = 0;
        num = 1;
        while (num++ <= 1000)
        {
            if (num % 2 != 0) continue;
            if (num % 3 != 0) continue;
            if (num % 5 != 0) continue;

            sum += num;
        }

        Console.WriteLine($"sum of numbers divisible by 2 && 3 && 5: {sum}");

        // goto for double loop exit
        for (int x = 2; x < 10; x++)
        {
            for (int y = 1; y < 10; y++)
            {
                Console.WriteLine($"{x} * {y} = {x * y}");
                if (x == 5 && y == 8) goto LOOP_EXIT;
            }
        }

    LOOP_EXIT:;
    }
}
