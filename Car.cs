namespace GarageTest5
{
    internal class Car : Vehicle
    {
        public string FuelType { get; set; }    
        public Car(string id, string regNr, string brand, string fuelType) : base(id, regNr, brand)
        {
    
            FuelType = fuelType;

        }

        public override string VehicleInfo()
        {
            return $"{base.VehicleInfo()}Fueltype  Gasoline or Diesel : {FuelType}."; 
        }
       
    }
}
