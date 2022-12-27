internal class Program
{
    private static void Main(string[] args)
    {
        SummMethod(4, 8);
    }

    public static void SummMethod(int m, int n)
    {
        Console.WriteLine((n*(n+1))/2 - (m*(m-1))/2);
    }
}