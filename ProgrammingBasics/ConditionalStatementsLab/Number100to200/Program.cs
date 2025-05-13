using System.ComponentModel.Design;

namespace Number100to200;

class Program
{
    static void Main(string[] args)
    {
       int number1 = int.Parse(Console.ReadLine());
       int number2 = 100;
       int number3 = 200;

       if (number1 >= number2 && number1 <= number3)
       {
           Console.WriteLine("Between 100 and 200");
       }
      else if (number1 < number2)
      {
          Console.WriteLine("Less than 100");
      }
       else if (number1 > number3)
       {
           Console.WriteLine("Greater than 200");
       }
       
       
    }
}