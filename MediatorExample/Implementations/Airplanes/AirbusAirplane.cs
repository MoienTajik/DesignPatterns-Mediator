using MediatorExample.Contracts;
using System;

namespace MediatorExample.Implementations.Airplanes
{
    public class AirbusAirplane : AirplaneBase
    {
        public AirbusAirplane(IAirTrafficControl airTrafficControl) : base(airTrafficControl)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine("Airbus airplane sends message: " + message);
            AirTrafficControl.SendMessage(message, this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Airbus airplane gets message: " + message);
        }
    }
}