class Program
{
    static void Main(string[] args)
    {
        Notebook nb1 = new Notebook(fingerScan: true);
        Desktop dt1 = new Desktop(hasODD: false);
        nb1.HasFingerScanDevice();
        dt1.HasODDDevice();

        DeviceManager manager = new DeviceManager();
        manager.TurnOff(nb1);
        manager.TurnOff(dt1);

        Computer[] machines = new Computer[] { new Notebook(true), new Desktop(true) };

        foreach (Computer device in machines)
        {
            Console.Write(device.GetType().FullName + " ");
            manager.TurnOff(device);
        }

        Type type = typeof(double);
        Console.WriteLine(type.FullName);
        Console.WriteLine(typeof(System.Int64).FullName);

        int n = 5;
        Console.WriteLine(n.Equals(5));

        Notebook nb2 = new Notebook(true);
        Notebook nb3 = new Notebook(true);
        Console.WriteLine(nb2.Equals(nb3));

        string txt1 = new string(new char[] { 'Y', 'e', 's', 'h', 'u', 'a' });
        string txt2 = new string(new char[] { 'Y', 'e', 's', 'h', 'u', 'a' });
        Console.WriteLine(txt1.Equals(txt2));

        short sn1 = 256;
        short sn2 = 256;
        short sn3 = 32750;

        Console.WriteLine(sn1.GetHashCode());
        Console.WriteLine(sn2.GetHashCode());
        Console.WriteLine(sn3.GetHashCode());

        Console.WriteLine(nb2.GetHashCode());
        Console.WriteLine(nb3.GetHashCode());
    }
}
