public static class Exercise08
{
    public static void Run()
    {
        // Bug: Incorrect calculation (integer division)
        int x = 5;
        int y = 2;
        double result = x / y;
        Console.WriteLine($"5 / 2 = {result}");
    }
}