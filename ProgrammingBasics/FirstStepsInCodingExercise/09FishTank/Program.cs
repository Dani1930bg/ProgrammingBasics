namespace _09FishTank;

class Program
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        double percent = double.Parse(Console.ReadLine());

        double volumeCm3 = length * width * height;
        double volumeLitres = volumeCm3 / 1000; 

        double occupiedSpace = percent / 100;
        double neededLitres = volumeLitres * (1 - occupiedSpace);

        Console.WriteLine(neededLitres);
    }
}