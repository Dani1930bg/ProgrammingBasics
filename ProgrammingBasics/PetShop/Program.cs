namespace PetShop;

class Program
{
    static void Main(string[] args)
    {
        int dogfoodcount = int.Parse(Console.ReadLine());
        int catfoodcount = int.Parse(Console.ReadLine());
        double dogfoodprice = dogfoodcount * 2.50;
        int catfoodprice = catfoodcount * 4;
        double totalprice = dogfoodprice + catfoodprice;
        Console.WriteLine($"{totalprice} lv.");
        
    }
}