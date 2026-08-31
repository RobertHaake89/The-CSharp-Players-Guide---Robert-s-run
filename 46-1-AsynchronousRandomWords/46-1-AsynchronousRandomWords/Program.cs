using System;

namespace AsynchronousRandomWords;

class Program
{
    public static async Task Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Console.Write("\nEnter a random word: ");
        string? inputWord = Console.ReadLine()!.ToLower();

        float currentProgress = 0;
        var progress = new Progress<float>(value =>
        {
            currentProgress = value;
        });

        using var cts = new CancellationTokenSource();
        Task loadingTask = Methods.LoadingSpinner(cts.Token,() => currentProgress);

        await Methods.RandomlyRecreate(inputWord, progress);

        cts.Cancel();
        await loadingTask;
    }
}