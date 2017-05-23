using System;
using System.Threading;

namespace EventsDelegate_2
{
    class NeedCar
    {
        private Car _car;

        public NeedCar(Car car)
        {
            _car = car;
        }

        public event EventHandler NeededCar;

        public void NeedNewCar()
        {
            Console.WriteLine("{0} - This car is needed to out company", _car.Name);
            Thread.Sleep(400);
            OnNeedCar();
        }

        public void OnNeedCar()
        {
            if(NeededCar != null)
            {
                NeededCar(this, new EventArgs());
            }
        }
    }
}
