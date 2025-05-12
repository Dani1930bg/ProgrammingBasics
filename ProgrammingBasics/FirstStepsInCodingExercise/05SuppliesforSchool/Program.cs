namespace _05SuppliesforSchool;

class Program
{
    static void Main(string[] args)
    {
        int penPacks = int.Parse(Console.ReadLine());
        int markerPacks = int.Parse(Console.ReadLine());
        int boardCleanerLiters = int.Parse(Console.ReadLine());
        double discountPercent = double.Parse(Console.ReadLine()) / 100;

        double totalPrice = (penPacks * 5.80) + (markerPacks * 7.20) + (boardCleanerLiters * 1.20);

        double discountedPrice = totalPrice - (totalPrice * discountPercent);

        Console.WriteLine(discountedPrice);
    }
}