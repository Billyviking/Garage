using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageTest5
{
    internal class Vehicle
    {

        //Fields som alla subklasser skall ha så de ska ärvas 
        public string Id { get; set; }  
        public string RegNr { get; set; }   
        public string Brand { get; set; }    
        public string VisibleDamage { get; set; } 
                                        


    }
}
