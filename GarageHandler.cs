using System.Drawing;

namespace GarageTest5
{
    internal class GarageHandler
    {

        private Garage<Vehicle> garage;

        internal void Initialize()
        {
            string antParkSpots;
            Console.Write("Ange antal parkeringsplatser i garaget : ");

            antParkSpots = Console.ReadLine();
            garage = new Garage<Vehicle>(int.Parse(antParkSpots));

            Console.WriteLine($"Garaget har {antParkSpots} parkeringsplatser.");
        }

        internal void SeedData()
        {
            garage.Park(new Airplane("a1", "AIR111", "Boeing", 3));
            garage.Park(new Car("c1", "CAR111", "Volvo", "Bensin"));
            garage.Park(new Boat("b1", "BOA111", "Silverwing", "Strong"));

            Console.WriteLine("Succefully seeded data! Press any key to continue...");
            Console.ReadKey();
        }



        //Hur många platser finns det totalt
        void totNumParkSpots()
        {
            
            //Console.WriteLine($"Garaget har {garage.Length}";
        }
        
        //Hur många lediga platser finns

        //Hur många parkerade av viss typ av fordon
    }
}