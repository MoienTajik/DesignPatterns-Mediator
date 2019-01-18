namespace MediatorExample.Contracts
{
    public abstract class AirplaneBase
    {
        protected readonly IAirTrafficControl AirTrafficControl;

        public AirplaneBase(IAirTrafficControl airTrafficControl)
        {
            AirTrafficControl = airTrafficControl;
        }

        public abstract void Send(string message);

        public abstract void Notify(string message);
    }
}