public static class Exercise05
{
    public static void Run()
    {
        // Bug: Incorrect string comparison
        string input = "Hello";
        if (input == "hello")
        {
            Console.WriteLine("Match!");
        }
        else
        {
            Console.WriteLine("No match.");
        }
    }
}