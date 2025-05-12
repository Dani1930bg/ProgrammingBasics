namespace _04VacationBooksList;

class Program
{
    static void Main(string[] args)
    {
        int totalPages = int.Parse(Console.ReadLine());
        int pagesPerHour = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());

        int totalHours = totalPages / pagesPerHour;

        int hoursPerDay = totalHours / days;

        Console.WriteLine(hoursPerDay);
    }
}