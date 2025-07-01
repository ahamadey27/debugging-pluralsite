public static class Exercise09
{
    public static void Run()
    {
        // Bug: Unhandled exception (null array)
        int[] arr = null;
        Console.WriteLine(arr.Length);
    }
}