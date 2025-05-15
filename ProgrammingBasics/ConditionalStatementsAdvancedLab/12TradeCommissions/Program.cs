namespace _12TradeCommissions;

class Program
{
    static void Main(string[] args)
    {
        string city = Console.ReadLine();
        double sales = double.Parse(Console.ReadLine());

        if (sales < 0)
        {
            Console.WriteLine("error");
            return;
        }

        double commission = -1;

        switch (city)
        {
            case "Sofia":
                if (sales >= 0 && sales <= 500)
                    commission = 0.05;
                else if (sales <= 1000)
                    commission = 0.07;
                else if (sales <= 10000)
                    commission = 0.08;
                else
                    commission = 0.12;
                break;

            case "Varna":
                if (sales >= 0 && sales <= 500)
                    commission = 0.045;
                else if (sales <= 1000)
                    commission = 0.075;
                else if (sales <= 10000)
                    commission = 0.10;
                else
                    commission = 0.13;
                break;

            case "Plovdiv":
                if (sales >= 0 && sales <= 500)
                    commission = 0.055;
                else if (sales <= 1000)
                    commission = 0.08;
                else if (sales <= 10000)
                    commission = 0.12;
                else
                    commission = 0.145;
                break;

            default:
                Console.WriteLine("error");
                return;
        }

        if (commission < 0)
        {
            Console.WriteLine("error");
            return;
        }

        double result = sales * commission;
        Console.WriteLine($"{result:F2}");
    }
}