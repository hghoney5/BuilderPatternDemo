namespace ConsoleApp1;

public class Boeing747 : IAircraft
{
    public string Engine { get; set; }
    public string Wings { get; set; }
    public string Cockpit { get; set; }
    public string Bathrooms { get; set; }
    
    public string GetAircraftType()
    {
        return nameof(Boeing747);
    }

    public void StartEngine()
    {
        Console.WriteLine("Starting engine: " + Engine);
    }

    public void StopEngine()
    {
        Console.WriteLine("Stoping engine: " + Engine);
    }
}