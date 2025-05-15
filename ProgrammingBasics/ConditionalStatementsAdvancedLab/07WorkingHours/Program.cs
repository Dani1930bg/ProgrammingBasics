namespace _07WorkingHours;

class Program
{
    static void Main(string[] args)
    {
        int hour = int.Parse(Console.ReadLine());
        string day = Console.ReadLine();

        bool isWorkingDay = day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday";

        if (hour >= 10 && hour <= 18 && isWorkingDay)
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }
    }
}