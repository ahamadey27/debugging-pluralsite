public static class Exercise02
{
    public static void Run()
    {
        // Bug: Null reference
        string message = null;
        Console.WriteLine(message.ToUpper());
    }
}