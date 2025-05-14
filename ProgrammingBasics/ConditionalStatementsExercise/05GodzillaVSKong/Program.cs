namespace _05GodzillaVSKong;

class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int statists = int.Parse(Console.ReadLine());
        double clothingPricePerStatist = double.Parse(Console.ReadLine());

        double decorCost = budget * 0.10;

        double clothingCost = statists * clothingPricePerStatist;

        if (statists > 150)
        {
            clothingCost *= 0.90; 
        }

        double totalCost = decorCost + clothingCost;

        if (totalCost > budget)
        {
            double needed = totalCost - budget;
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {needed:F2} leva more.");
        }
        else
        {
            double left = budget - totalCost;
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {left:F2} leva left.");
        }
        
    }
}