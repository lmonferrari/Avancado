using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegate_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car() { Name = "Fiat 500" };
            var needCar = new NeedCar();
            var buyCar = new BuyCar();

            needCar.NeededCar += buyCar.OnNeedCar;

            needCar.NeedNewCar(car);
        }
    }
}
