namespace ConsoleApp1;

public class AircraftDirector
{
    private AircraftBuilder aircraftBuilder;

    public AircraftDirector(AircraftBuilder aircraftBuilder)
    {
        this.aircraftBuilder = aircraftBuilder;
    }

    public void ConstructAircraft(bool isPassesngerAircraft)
    {
        aircraftBuilder.buildEngine();
        aircraftBuilder.buildCockpit();
        aircraftBuilder.buildWings();
        
        if(isPassesngerAircraft)
            aircraftBuilder.buildBathrooms();
    }
}