using System;
using MediatorExample.Contracts;

namespace MediatorExample.Implementations.Airplanes
{
    public class BoeingAirplane : AirplaneBase
    {
        public BoeingAirplane(IAirTrafficControl airTrafficControl) : base(airTrafficControl)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine("Boeing airplane sends message: " + message);
            AirTrafficControl.SendMessage(message, this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Boeing airplane gets message: " + message);
        }
    }
}