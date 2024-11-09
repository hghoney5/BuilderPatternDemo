namespace ConsoleApp1;

public class Boeing747Builder : AircraftBuilder
{
    Boeing747 boeing747 = new Boeing747();

    public override void buildEngine()
    {
        boeing747.Engine = "Boeing747 Engine v1";
    }

    public override void buildBathrooms()
    {
        boeing747.Bathrooms = "Boeing747 4 Bathrooms set";
    }

    public override void buildCockpit()
    {
        boeing747.Cockpit = "Boeing747 Cockpit v1";
    }

    public override void buildWings()
    {
        boeing747.Wings = "Boeing747 Wings v1";
    }

    public override IAircraft getAircraft()
    {
        return boeing747;
    }
}