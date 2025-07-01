using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Select a debugging exercise (1-10):");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1: Exercise01.Run(); break;
                case 2: Exercise02.Run(); break;
                case 3: Exercise03.Run(); break;
                case 4: Exercise04.Run(); break;
                case 5: Exercise05.Run(); break;
                case 6: Exercise06.Run(); break;
                case 7: Exercise07.Run(); break;
                case 8: Exercise08.Run(); break;
                case 9: Exercise09.Run(); break;
                case 10: Exercise10.Run(); break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}
