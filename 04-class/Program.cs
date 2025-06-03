namespace _04_class;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Class!");
        // Person.President.DisplayName();
        Person.OutputCount();

        Person person1 = new Person("");
        Console.WriteLine("----------------");
        Person person2 = new Person("");

        Person.OutputCount();

        Circle c1 = new Circle();
        c1.Print(34);
        c1.PI = 3.14159;
        double piValue = c1.PI;
        Console.WriteLine($"New PI value: {piValue}");
    }
}
