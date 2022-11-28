namespace TddWorkshopCSharp;

public static class RockPaperScissors
{
    public static string Play(string gesture1, string gesture2)
    {
        return (gesture1, gesture2) switch
        {
            ("Paper", "Rock") or ("Scissors", "Paper") or ("Rock", "Scissors") => $"{gesture1} beats {gesture2}",
            ("Rock", "Paper") or ("Paper", "Scissors") or ("Scissors", "Rock") => $"{gesture2} beats {gesture1}",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}