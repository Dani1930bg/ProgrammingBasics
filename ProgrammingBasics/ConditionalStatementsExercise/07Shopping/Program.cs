namespace _07Shopping;

class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int videoCards = int.Parse(Console.ReadLine());
        int processors = int.Parse(Console.ReadLine());
        int ram = int.Parse(Console.ReadLine());

        double videoCardPrice = 250;
        double totalVideoCardPrice = videoCards * videoCardPrice;

        double processorPrice = totalVideoCardPrice * 0.35;
        double totalProcessorPrice = processors * processorPrice;

        double ramPrice = totalVideoCardPrice * 0.10;
        double totalRamPrice = ram * ramPrice;

        double totalSum = totalVideoCardPrice + totalProcessorPrice + totalRamPrice;

        if (videoCards > processors)
        {
            totalSum *= 0.85;
        }

        if (budget >= totalSum)
        {
            double leftMoney = budget - totalSum;
            Console.WriteLine($"You have {leftMoney:F2} leva left!");
        }
        else
        {
            double neededMoney = totalSum - budget;
            Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva more!");
        }
    }
}