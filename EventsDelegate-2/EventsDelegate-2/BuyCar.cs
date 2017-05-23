using System;

namespace EventsDelegate_2
{

    class BuyCar
    {
        public void OnNeedCar(object source, EventArgs e)
        {
            System.Console.WriteLine("Consulting prices...");
        }

    }
}
