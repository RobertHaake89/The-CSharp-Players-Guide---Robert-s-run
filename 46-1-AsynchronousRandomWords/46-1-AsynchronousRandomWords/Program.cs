using System;

namespace AsynchronousRandomWords;

class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.Write("\nEnter a random word: ");
        string? inputWord = Console.ReadLine();

        Methods.RandomlyRecreate(inputWord!, out string guessedWord, out int count);

        Console.WriteLine($"\n\nThis took {count} attempt!");
        Console.WriteLine($"The guessed word is: {guessedWord}");
    }
}