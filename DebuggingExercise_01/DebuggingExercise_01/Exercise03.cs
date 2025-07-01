public static class Exercise03
{
    public static void Run()
    {
        // Bug: Array index out of bounds
        int[] numbers = { 1, 2, 3 };
        for (int i = 0; i <= numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}