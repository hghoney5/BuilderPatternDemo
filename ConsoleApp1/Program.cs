// See https://aka.ms/new-console-template for more information


using ConsoleApp1;

Console.WriteLine("Hello, World!");

AircraftBuilder boeing747Builder = new Boeing747Builder();
IAircraft boeing747Aircraft = boeing747Builder.getAircraft();

Console.WriteLine(boeing747Aircraft.GetAircraftType());
boeing747Aircraft.StartEngine(); 
boeing747Aircraft.StopEngine();


F16Builder f16Builder = new F16Builder();
AircraftDirector director = new AircraftDirector(f16Builder);
director.ConstructAircraft(false);

IAircraft f16 = f16Builder.getAircraft();

Console.WriteLine(f16.GetAircraftType());