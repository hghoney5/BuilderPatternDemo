namespace ConsoleApp1;

public class F16Builder : AircraftBuilder
{
    private F16 f16 = new F16();

    public override void buildEngine()
    {
        f16.Engine = "F16 Engine v1";
    }

    public override void buildCockpit()
    {
        f16.Cockpit = "F16 Cockpit v1";
    }

    public override void buildWings()
    {
        f16.Wings = "F16 Wings v1";
    }

    public override IAircraft getAircraft()
    {
        return f16;
    }
}