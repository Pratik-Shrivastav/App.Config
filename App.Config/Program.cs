using System.Configuration;

public class Program
{
    static void Main(string[] args)
    {
        int id = int.Parse(ConfigurationManager.AppSettings["id"]);
        string name = ConfigurationManager.AppSettings["name"];
        Console.WriteLine(id);
        Console.WriteLine(name);

        string path = ConfigurationManager.AppSettings["filepathtext"];
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine("Hello using App Config");
        }

    }
}