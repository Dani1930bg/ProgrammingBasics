namespace _06Repainting;

class Program
{
    static void Main(string[] args)
    {
        int nylon = int.Parse(Console.ReadLine());
        int paint = int.Parse(Console.ReadLine());
        int thinner = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());

        double nylonPricePerSqM = 1.50;
        double paintPricePerL = 14.50;
        double thinnerPricePerL = 5.00;
        double bagPrice = 0.40;

        double totalNylon = (nylon + 2) * nylonPricePerSqM;
        double totalPaint = (paint * 1.10) * paintPricePerL; 
        double totalThinner = thinner * thinnerPricePerL;

        double materialsCost = totalNylon + totalPaint + totalThinner + bagPrice;

        double workersCost = (materialsCost * 0.30) * hours;

        double totalCost = materialsCost + workersCost;

        Console.WriteLine(totalCost);
    }
}