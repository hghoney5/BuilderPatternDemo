namespace ConsoleApp1;

public abstract class AircraftBuilder
{
    public virtual void buildEngine()
    {
        
    }

    public virtual void buildWings()
    {
        
    }

    public virtual void buildCockpit()
    {
        
    }

    public virtual void buildBathrooms()
    {
        
    }

    abstract public IAircraft getAircraft();
}