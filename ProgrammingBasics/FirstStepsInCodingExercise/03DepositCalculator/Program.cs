namespace _03DepositCalculator;

class Program
{
    static void Main(string[] args)
    {
        double depositedAmount = double.Parse(Console.ReadLine());
        int months = int.Parse(Console.ReadLine());
        double annualInterestRate = double.Parse(Console.ReadLine());

        double interestForOneYear = depositedAmount * (annualInterestRate / 100);
        double interestPerMonth = interestForOneYear / 12;

        double totalAmount = depositedAmount + months * interestPerMonth;

        Console.WriteLine(totalAmount);
    }
}