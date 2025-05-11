namespace YardGreening;

class Program
{
    static void Main(string[] args)
    {
        double plasetogreen = double.Parse(Console.ReadLine());
        double pricefortheyard = plasetogreen * 7.61;
        double discount = 0.18* pricefortheyard;
        double totalprice = pricefortheyard - discount;
        Console.WriteLine($"The final price is: {totalprice} lv.");
        Console.WriteLine($"The discount is: {discount} lv.");
    }
}