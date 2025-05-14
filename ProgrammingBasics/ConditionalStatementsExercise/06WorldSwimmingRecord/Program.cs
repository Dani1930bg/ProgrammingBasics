namespace _06WorldSwimmingRecord;

class Program
{
    static void Main(string[] args)
    {
        double recordInSeconds = double.Parse(Console.ReadLine());
        double distanceInMeters = double.Parse(Console.ReadLine());
        double timePerMeter = double.Parse(Console.ReadLine());

        double swimTime = distanceInMeters * timePerMeter;

        double delay = Math.Floor(distanceInMeters / 15) * 12.5;

        double totalTime = swimTime + delay;

        if (totalTime < recordInSeconds)
        {
            Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
        }
        else
        {
            double difference = totalTime - recordInSeconds;
            Console.WriteLine($"No, he failed! He was {difference:F2} seconds slower.");
        }
    }
}