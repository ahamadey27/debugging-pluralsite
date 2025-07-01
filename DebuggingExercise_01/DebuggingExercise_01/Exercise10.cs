public static class Exercise10
{
    public static void Run()
    {
        // Bug: Invalid date parsing
        DateTime dt = DateTime.Parse("2025-02-30");
        Console.WriteLine(dt);
    }
}