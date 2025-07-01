public static class Exercise06
{
    public static void Run()
    {
        // Bug: Infinite loop
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            // Missing increment
        }
    }
}