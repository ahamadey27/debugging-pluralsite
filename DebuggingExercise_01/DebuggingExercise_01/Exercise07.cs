public static class Exercise07
{
    public static void Run()
    {
        // Bug: Logic error in condition
        int age = 20;
        if (age > 18 && age < 18)
        {
            Console.WriteLine("You are 18.");
        }
        else
        {
            Console.WriteLine("You are not 18.");
        }
    }
}