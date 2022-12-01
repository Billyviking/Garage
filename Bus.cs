using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageTest5
{
    internal class Bus : Vehicle
    {
        public string BusLength;
        public Bus(string id, string regNr, string brand, string busLength) : base(id, regNr, brand)
        {
            BusLength = busLength;
        }

        public override string VehicleInfo()
        {
            return $"{base.VehicleInfo()}Length of the bus : {BusLength}.";
        }


    }
}
