namespace _04ToyShop;

class Program
{
    static void Main(string[] args)
    {
        double tripPrice = double.Parse(Console.ReadLine());
        int puzzles = int.Parse(Console.ReadLine());
        int dolls = int.Parse(Console.ReadLine());
        int bears = int.Parse(Console.ReadLine());
        int minions = int.Parse(Console.ReadLine());
        int trucks = int.Parse(Console.ReadLine());

        double puzzlePrice = 2.60;
        double dollPrice = 3.00;
        double bearPrice = 4.10;
        double minionPrice = 8.20;
        double truckPrice = 2.00;

    
        int totalToys = puzzles + dolls + bears + minions + trucks;

       
        double totalPrice = (puzzles * puzzlePrice) + (dolls * dollPrice) + (bears * bearPrice) + (minions * minionPrice) + (trucks * truckPrice);

        if (totalToys >= 50)
        {
            totalPrice *= 0.75; 
        }

        double rent = totalPrice * 0.10;

        double profit = totalPrice - rent;

        if (profit >= tripPrice)
        {
            Console.WriteLine($"Yes! {(profit - tripPrice):F2} lv left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! {(tripPrice - profit):F2} lv needed.");
        }  
    }
}