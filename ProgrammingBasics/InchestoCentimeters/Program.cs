namespace InchestoCentimeters;

class Program
{
    static void Main(string[] args)
    {
        int inches = int.Parse(Console.ReadLine());
        double sentimeters = inches * 2.54;
        Console.WriteLine(sentimeters);
        
    }
}