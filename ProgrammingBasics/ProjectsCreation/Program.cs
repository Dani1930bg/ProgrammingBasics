namespace ProjectsCreation;

class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int projectscount = int.Parse(Console.ReadLine());
        int projectstime = projectscount * 3;
        Console.WriteLine($"The architect {name} will need {projectstime} hours to complete {projectscount} project/s.");
    }
}