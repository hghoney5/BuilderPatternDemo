namespace ConsoleApp1;

public class F16 : IAircraft
{
    public string Engine { get; set; }
    public string Wings { get; set; }
    public string Cockpit { get; set; }
    
    public string GetAircraftType()
    {
        return nameof(F16);
    }

    public void StartEngine()
    {
        Console.WriteLine("Starting Engine: " + Engine);
    }

    public void StopEngine()
    {
        Console.WriteLine("Stopping Engine: " + Engine);
    }
}