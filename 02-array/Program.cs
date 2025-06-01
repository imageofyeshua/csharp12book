namespace _02_array;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Array!");

        // 1-dimension
        int[] arr1 = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        int upper = arr1.GetUpperBound(0);
        int lower = arr1.GetLowerBound(0);
        System.Console.WriteLine($"Elements from index {lower} to {upper}");
        for (int ctr = lower; ctr <= upper; ctr++)
            Console.Write($"{(ctr == lower ?"   " : "")}{arr1[ctr]}" +
                      $"{(ctr < upper ? ", " : Environment.NewLine)}");


        // 2-dimension
        int[,] arr2 = new int[3, 4]
        {
            {2, 4, 8, 16},
            {3, 6, 12, 24},
            {4, 8, 16, 32}
        };
        int rank = arr2.Rank;
        Console.WriteLine($"Number of dimensions[2d-array]: {rank}");
        for (int ctr = 0; ctr < rank; ctr++)
            Console.WriteLine($"   Dimension {ctr}: " +
            $"from {arr2.GetLowerBound(ctr)} to {arr2.GetUpperBound(ctr)}");

        Console.WriteLine("   Values of 2d array elements:");
        for (int outer = arr2.GetLowerBound(0); outer <= arr2.GetUpperBound(0); outer++)
            for (int inner = arr2.GetLowerBound(1); inner <= arr2.GetUpperBound(1); inner++)
                Console.WriteLine($"      {'\u007b'}{outer}, {inner}{'\u007d'} = " +
                                  $"{arr2.GetValue(outer, inner)}");

        // 3-dimension
            int[,,] arr3 = new int[2, 3, 4]
        {
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            },
            {
                {13, 14, 15, 16},
                {17, 18, 19, 20},
                {21, 22, 23, 24}
            },
        };
        int rank2 = arr3.Rank;
        Console.WriteLine($"Number of dimensions[3d-array]: {rank2}");
        for (int ctr = 0; ctr < rank2; ctr++)
            Console.WriteLine($"   Dimension {ctr}: " +
            $"from {arr3.GetLowerBound(ctr)} to {arr3.GetUpperBound(ctr)}");

        Console.WriteLine("   Values of 3d array elements:");
        for (int outer = arr3.GetLowerBound(0); outer <= arr3.GetUpperBound(0); outer++)
            for (int inner = arr3.GetLowerBound(1); inner <= arr3.GetUpperBound(1); inner++)
                for (int core = arr3.GetLowerBound(2); core <= arr3.GetUpperBound(2); core++)
                Console.WriteLine($"      {'\u007b'}{outer}, {inner}, {core}{'\u007d'} = " +
                                  $"{arr3.GetValue(outer, inner, core)}");

        // jagged-array
        int[][] arr4 = new int[5][];
        arr4[0] = new int[10];
        arr4[1] = new int[9];
        arr4[2] = new int[8];
        arr4[3] = new int[6];
        arr4[4] = new int[3];
        int rank3 = arr4.Rank;
        Console.WriteLine($"Number of dimensions[jagged-array]: {rank3}");
        for (int ctr = 0; ctr < rank3; ctr++)
            Console.WriteLine($"   Dimension {ctr}: " +
            $"from {arr4.GetLowerBound(ctr)} to {arr4.GetUpperBound(ctr)}");
    }
}
