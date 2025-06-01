namespace _01Cinema;

class Program
{
    static void Main(string[] args)
    {
        string projectionType = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        int totalSeats = rows * columns;
        double pricePerTicket = 0.0;

        if (projectionType == "Premiere")
        {
            pricePerTicket = 12.00;
        }
        else if (projectionType == "Normal")
        {
            pricePerTicket = 7.50;
        }
        else if (projectionType == "Discount")
        {
            pricePerTicket = 5.00;
        }

        double totalIncome = totalSeats * pricePerTicket;
        Console.WriteLine("{0:f2} leva", totalIncome);
    }
}