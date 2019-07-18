using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    public class CarDAO
    {
       public void StartDriving()
        {
            Console.WriteLine("Strting drive");
        }

        public void EndDriving()
        {
            Console.WriteLine("Ending drive");
        }

        public void IncreaseSpeedOfCar()
        {
            Console.WriteLine("Increaasing the car's speed");
        }

        public void DecreaseSpeedOfCar()
        {
            Console.WriteLine("Decreaasing the car's speed");
        }

        public void TurningRight()
        {
            Console.WriteLine("Turn right");
        }

        public void TurningLeft()
        {
            Console.WriteLine("Turn left");
        }

        public void ShowStateOfFuel()
        {
            Console.WriteLine("Show fuel's state");
        }

        public void ShowMyLocation()
        {
            Console.WriteLine("Show current location");
        }
    }
}
