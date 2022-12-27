internal class Program
{
    private static void Main(string[] args)
    {
        RecursiveMethod(2);
    }

    public static void RecursiveMethod(int value)
    {
        if (value == 1)
        {
            Console.WriteLine(value);
            return;
        }
        else if (value < 1)
        {
            Console.WriteLine("error");
            return;
        }

        Console.WriteLine(value);
        RecursiveMethod(value - 1);
    }
}