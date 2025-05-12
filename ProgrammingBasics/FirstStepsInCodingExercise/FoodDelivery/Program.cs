namespace _06Repainting;

class Program
{
    static void Main(string[] args)
    {
        int chickenMenus = int.Parse(Console.ReadLine());
        int fishMenus = int.Parse(Console.ReadLine());
        int vegetarianMenus = int.Parse(Console.ReadLine());

        double chickenMenuPrice = 10.35;
        double fishMenuPrice = 12.40;
        double vegetarianMenuPrice = 8.15;

        double totalMenuPrice = (chickenMenus * chickenMenuPrice) + (fishMenus * fishMenuPrice) + (vegetarianMenus * vegetarianMenuPrice);

        double dessertPrice = totalMenuPrice * 0.20;

        double deliveryFee = 2.50;

        double totalPrice = totalMenuPrice + dessertPrice + deliveryFee;

        Console.WriteLine(totalPrice);
        
    }
}