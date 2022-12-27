internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(AckermannMethod(3, 2));
    }

    public static int AckermannMethod(int n, int m)
    {
        if (n == 0)
            return m + 1;
        else
        if ((n != 0) && (m == 0))
            return AckermannMethod(n - 1, 1);
        else
            return AckermannMethod(n - 1, AckermannMethod(n, m - 1));
    }
}