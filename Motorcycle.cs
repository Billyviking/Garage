using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageTest5
{
    internal class Motorcycle : Vehicle
    {
        public string CylinderVolume;
        public Motorcycle(string id, string regNr, string brand, string cylinderVolume) : base(id, regNr, brand)
        {
            CylinderVolume = cylinderVolume;    
        }

        public override string VehicleInfo()
        {
            return $"{base.VehicleInfo()} Cylinder volym: {CylinderVolume}";
        }


    }
}
