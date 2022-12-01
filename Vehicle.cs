using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageTest5
{
    //Abstract så går inte att Instansieras ska bara ärvas
    internal abstract class Vehicle 
    {

        //Fields som alla subklasser skall ha så de ska ärvas 
        public string Id { get; set; }  
        public string RegNr { get; set; }   
        public string Type { get; set; }    
     

        //public Vehicle(string id, string regNr, string type) 
        //{
        //    Id = id;        
        //    RegNr = regNr;
        //    Type = type;
        //  e;  
        //}

        //public virtual string VehicleInfo()
        //{
        //    return $"Type: {this.GetType().Name}, Id: {Id}, License Plate: {RegNr}, Type: {Type} ";
        //}

    
    }
}
