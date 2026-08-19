namespace TheLongGame;

class Methods
{
    public static void CheckScore(string name, out int score)
    {
        string[] lines = File.Exists("score.txt")
            ? File.ReadAllLines("score.txt")
            : [];

            score = 0;

        foreach (string line in lines)
        {
            string[] parts = line.Split(';');

            if (parts[0].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                score = int.Parse(parts[1]);
                break;
            }
        }
    }

    public static void AddToFile(string name, int score)
    {
        string[] lines
            = File.Exists("score.txt")
                ? File.ReadAllLines("score.txt")
                : [];

        int index = Array.FindIndex(lines, line =>
            line.Split(';')[0].Equals(name, StringComparison.OrdinalIgnoreCase));
        
        if (index >= 0)
        {
            lines[index] = $"{name};{score}";
            File.WriteAllLines("score.txt", lines);
        }
        else
        {
            lines = lines.Append($"{name};{score}").ToArray();
        }

        File.WriteAllLines("score.txt", lines);
    }
}