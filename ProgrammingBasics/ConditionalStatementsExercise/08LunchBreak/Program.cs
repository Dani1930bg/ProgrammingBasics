namespace _08LunchBreak;

class Program
{
    static void Main(string[] args)
    {
        string seriesName = Console.ReadLine();
        int episodeDuration = int.Parse(Console.ReadLine());
        int breakDuration = int.Parse(Console.ReadLine());

        double lunchTime = breakDuration / 8.0;
        double relaxTime = breakDuration / 4.0;
        double timeLeft = breakDuration - lunchTime - relaxTime;

        if (timeLeft >= episodeDuration)
        {
            double freeTime = Math.Ceiling(timeLeft - episodeDuration);
            Console.WriteLine($"You have enough time to watch {seriesName} and left with {freeTime} minutes free time.");
        }
        else
        {
            double neededTime = Math.Ceiling(episodeDuration - timeLeft);
            Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {neededTime} more minutes.");
        }
    }
}