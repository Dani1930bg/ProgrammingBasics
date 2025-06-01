namespace _03NewHouse;

class Program
{
    static void Main(string[] args)
    {
        string flowerType = Console.ReadLine();
        int flowerCount = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());

        double pricePerFlower = 0;

        switch (flowerType)
        {
            case "Roses":
                pricePerFlower = 5.00;
                break;
            case "Dahlias":
                pricePerFlower = 3.80;
                break;
            case "Tulips":
                pricePerFlower = 2.80;
                break;
            case "Narcissus":
                pricePerFlower = 3.00;
                break;
            case "Gladiolus":
                pricePerFlower = 2.50;
                break;
        }

        double totalPrice = flowerCount * pricePerFlower;

        // Прилагане на отстъпки или оскъпяване
        if (flowerType == "Roses" && flowerCount > 80)
        {
            totalPrice *= 0.90;
        }
        else if (flowerType == "Dahlias" && flowerCount > 90)
        {
            totalPrice *= 0.85;
        }
        else if (flowerType == "Tulips" && flowerCount > 80)
        {
            totalPrice *= 0.85;
        }
        else if (flowerType == "Narcissus" && flowerCount < 120)
        {
            totalPrice *= 1.15;
        }
        else if (flowerType == "Gladiolus" && flowerCount < 80)
        {
            totalPrice *= 1.20;
        }

        double difference = Math.Abs(budget - totalPrice);

        if (budget >= totalPrice)
        {
            Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {difference:f2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
        }
    }
}