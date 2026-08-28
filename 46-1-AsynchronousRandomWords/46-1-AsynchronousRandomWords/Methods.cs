using System;

namespace AsynchronousRandomWords;

public static class Methods
{
    public static void RandomlyRecreate(string inputWord, out string guessedWord, out int c)
    {
        char[] guessArray = new char[inputWord.Length + 1];
        int i = 0;
        c = 0;
        

        while (true)
        {
            char guessLetter = (char)Random.Shared.Next('a','z');

            Console.Write($"{guessLetter} ");

            if (inputWord.ToArray()[i] == guessLetter)
            {
                i++;
                guessArray[i - 1] = guessLetter;
            }
            c++;

            Console.Write($"c={c} ");
            Console.WriteLine($"i={i} ");

            if (guessArray[0..inputWord.Length].ToString() == inputWord)
            {
                guessedWord = new string(guessArray);
                break;
            }
        }
    }
}