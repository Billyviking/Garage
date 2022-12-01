namespace GarageTest5
{
    internal class Car : Vehicle
    {
        public string FuelType { get; set; }    
        public Car(string id, string regNr, string brand, string visibleDamage, string fuelType) : base(id, regNr, brand, visibleDamage)
        {
    
            FuelType = fuelType;

        }

        public override string VehicleInfo()
        {
            return $"{base.VehicleInfo()}Fueltype  Gasoline or Diesel : {FuelType}."; 
        }
       
    }
}
