using System;
using System.Threading;

namespace EventsDelegate_2
{
    class NeedCar
    {
        public event EventHandler NeededCar;

        public void NeedNewCar(Car car)
        {
            Console.WriteLine("{0} - This car is needed to out company", car.Name);
            Thread.Sleep(400);
            OnNeedCar(car);
        }

        public void OnNeedCar(Car car)
        {
            if(NeededCar != null)
            {
                NeededCar(this, EventArgs.Empty);
            }
        }
    }
}
