using System;

namespace EventsDelegate_2
{

    class BuyCar
    {
        public void OnNeedCar(object source, EventHandler e)
        {
            System.Console.WriteLine("Wee Need to buy a new car!!!!");
        }

    }
}
