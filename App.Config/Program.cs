using System.Configuration;

public class Program
{
    static void Main(string[] args)
    {
        int id = int.Parse(ConfigurationManager.AppSettings["id"]);
        string name = ConfigurationManager.AppSettings["name"];
        Console.WriteLine(id);
        Console.WriteLine(name);
    }
}