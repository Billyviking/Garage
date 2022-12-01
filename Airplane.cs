using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageTest5
{
    internal class Airplane : Vehicle
    {
        public int NrOfEngines { get; set; }
        public Airplane(string id, string regNr, string brand, int nrOfEngines) : base(id, regNr, brand)
        {
            NrOfEngines = nrOfEngines;
        }

        public override string VehicleInfo()
        {
            return $"{base.VehicleInfo()}Number of Engines: {NrOfEngines}.";
        }
    }
}
