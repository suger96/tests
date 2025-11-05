namespace HR;

internal abstract class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int number = 10;
        var bytes = BitConverter.GetBytes(number);
        foreach (var item in bytes)
        {
            var binary = Convert.ToString(item, 2).PadLeft(8, '0');
            Console.WriteLine(binary);
            
        }
        //hiii
        //allawi

        Console.ReadKey();
    }
}
