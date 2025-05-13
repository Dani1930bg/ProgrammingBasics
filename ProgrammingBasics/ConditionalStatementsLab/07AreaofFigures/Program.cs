namespace _07AreaofFigures;

class Program
{
    static void Main(string[] args)
    {
        string figure = Console.ReadLine();

        if (figure == "square")
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            Console.WriteLine($"{area:F3}");
        }
        else if (figure == "rectangle")
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = length * width;
            Console.WriteLine($"{area:F3}");
        }
        else if (figure == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine($"{area:F3}");
        }
        else if (figure == "triangle")
        {
            double baseLength = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = (baseLength * height) / 2;
            Console.WriteLine($"{area:F3}");
        }
    }
}