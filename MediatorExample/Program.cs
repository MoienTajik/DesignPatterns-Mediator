using MediatorExample.Contracts;
using MediatorExample.Implementations.Airplanes;
using MediatorExample.Mediators;
using System;
using System.Threading.Tasks;

namespace MediatorExample
{
    internal static class Program
    {
        static async Task Main()
        {
            IAirTrafficControl mehrabadAirTrafficControl = new MehrabadAirTrafficControl();

            AirplaneBase airbusAirplane = new AirbusAirplane(mehrabadAirTrafficControl);
            AirplaneBase boeingAirplane = new BoeingAirplane(mehrabadAirTrafficControl);

            mehrabadAirTrafficControl.AddAirplanes(airbusAirplane, boeingAirplane);

            airbusAirplane.Send("Can we land right now ?");
            Console.WriteLine("----------");

            boeingAirplane.Send("No! We're landing, wait ...");
            Console.WriteLine("----------");

            // Demonstrate landing ...
            Console.WriteLine("Boeing is landing ...");
            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("----------");

            boeingAirplane.Send("We landed.");
            Console.WriteLine("----------");

            airbusAirplane.Send("OK, We're going to land ...");
            Console.WriteLine("----------");

            boeingAirplane.Send("Good luck.");

            Console.ReadKey();
        }
    }
}