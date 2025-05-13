namespace _04PasswordGuess;

class Program
{
    static void Main(string[] args)
    {
       string triedpassword = Console.ReadLine();
       string password = "s3cr3t!P@ssw0rd";
       if (triedpassword == password)
       {
           Console.WriteLine("Welcome");
       }
       else
       {
           Console.WriteLine("Wrong password!");
       }
    } 
}