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

        public Garage(string? antParkSpots)
        {
            this.antParkSpots = antParkSpots;
        }

        public bool Park(T newVehicle)
        {
            // loopa genom vehicles med en for-loop
            // om du stöter på null, parkera bilen där
            // vehicles[i] = newVehicle;
            // return true

            // om ingen null hittats dvs hela loopen snurrat
            return false;

        }

        public bool Unpark(string regnr)
        {
            // vehicles[i] = null;
            // vehicles[i] = default!;
            // jag ska sätta in Null så blir det ledigt

            return false;
        }


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
