public static class Exercise04
{
    public static void Run()
    {
        // Bug: Division by zero
        int a = 10;
        int b = 0;
        Console.WriteLine(a / b);
    }
}