using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageTest5
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        string idNr;

        private T[] vehicles; // En Array, Generisk som tar objekt 
        private string? antParkSpots;

        public Garage(int capacity)
        {
            vehicles = new T[capacity];
        }

        public bool Park(T newVehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] is null)
                {
                    vehicles[i] = newVehicle; // här sker akten
                    return true;
                }
            }
            return false;

        }

        public bool Unpark(string regnr)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] is not null && vehicles[i].RegNr == regnr)
                {
                    vehicles[i] = null;
                    return true;
                }
            }
         
            return false;
        }

        // detta tillåter oss att iterera (foreach tex) över garage objekt/instanser. Även använda LINQ
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle is not null)
                {
                    yield return vehicle;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
