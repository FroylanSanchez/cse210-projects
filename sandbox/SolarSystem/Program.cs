class Program
{

    static void Main()
    {
        // Console.WriteLine("Bonjour tout le monde");
        Planet mercury = new Planet();
        mercury._name = "Mercury";
        mercury._diameter = 1234.343;

        //mercury.DisplayPlanetInformation();

        Planet venus = new Planet();
        venus._name = "Venus";
        venus._diameter = 12353.234;

        //venus.DisplayPlanetInformation();


        Planet earth = new Planet();
        earth._name = "Earth";
        earth._diameter = 15353.234;

        SolarSystem  SolarSystem = new SolarSystem();
        SolarSystem._solarSystem.Add(mercury);
        SolarSystem._solarSystem.Add(venus);
        SolarSystem._solarSystem.Add(earth);
        SolarSystem.DisplaySolarSystem();
    }

}