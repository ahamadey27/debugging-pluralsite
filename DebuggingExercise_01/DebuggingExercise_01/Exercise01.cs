public static class Exercise01
{
    public static void Run()
    {
        // Bug: Off-by-one error in loop
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Sum from 1 to 10 is: {sum}"); // Should be 55
    }
}