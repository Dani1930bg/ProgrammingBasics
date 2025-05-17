namespace _01ReverseAString;

class Program
{
    static void Main(string[] args)
    {
        string inputTetxToReverse = Console.ReadLine();
        Stack<char> reversingStack = new Stack<char>();
        
        foreach (char symbol in inputTetxToReverse)
        {
            reversingStack.Push(symbol);
        }

        while (reversingStack.Count > 0)
        {
            Console.Write(reversingStack.Pop());
        }
    }
}