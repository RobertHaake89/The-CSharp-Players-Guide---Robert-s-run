using System;
using System.Diagnostics;

namespace AsynchronousRandomWords;

public static class Methods
{
    public static async Task RandomlyRecreate(string inputWord, IProgress<float> progress)
    {
        char[] guessArray = new char[inputWord.Length];
        string guessedWord;
        float progressValue;
        int i = 0;
        int c = 0;
        
        Stopwatch counter = Stopwatch.StartNew();

        while (true)
        {
            await Task.Delay(40);
            char guessLetter = (char)Random.Shared.Next('A','z' + 1);

            if (inputWord.ToArray()[i] == guessLetter)
            {
                guessArray[i] = guessLetter;

                if (i < guessArray.Length) i++;
            }
            progressValue = (float)i / inputWord.Length;
            progress.Report(progressValue);
            c++;

            if (new string(guessArray) == inputWord)
            {
                guessedWord = new string(guessArray);
                counter.Stop();
                break;
            }
        }
        Console.Clear();

        Console.WriteLine($"\nThis took {c} attempts in {counter.Elapsed.TotalSeconds:F2} seconds!");
        Console.WriteLine($"The guessed word is: {guessedWord}\n");
    }

    public static async Task LoadingSpinner(CancellationToken token, Func<float> getProgress)
    {
        Console.CursorVisible = false;
        string[] spinnerArray = {"▀ ", " ▀", " ▄", "▄ "};
        int i = 0;

        while (!token.IsCancellationRequested)
        {
            Console.Clear();

            string progressMessage;
            if (getProgress() < 0.5f) progressMessage = "Thinking..";
            else if (getProgress() < 0.7f) progressMessage = "Getting closer..";
            else if (getProgress() < 0.85f) progressMessage = "That looks good..";
            else progressMessage = "Yep, thats it!";

            Console.WriteLine(progressMessage);
            Console.WriteLine(spinnerArray[i]);

            await Task.Delay(150);

            i = (i < spinnerArray.Length - 1)
                ? ++i
                : 0;
        }
        Console.CursorVisible = true;
    }
}