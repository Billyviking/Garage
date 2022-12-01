using GarageTest5;
using System;
using GarageTest5;

Console.WriteLine("THE GARAGE MANAGEMENT SYSTEM\n");

// Startar upp ett garage
// Använder en Array som tar objekt "antParkSpots"                                                                                              
// Användaren anger storlek på Arrayen

string antParkSpots;
Console.Write("Ange antal parkeringsplatser i garaget : ");

antParkSpots = Console.ReadLine();

var garage = new Garage<Vehicle>(antParkSpots); //Array? med antal parkeringar

Console.WriteLine($"Garaget har {antParkSpots} parkeringsplatser.");

//Prova lägga till något i arrayen
int antal = int.Parse(antParkSpots);

//PROVAR ANDRA ARRAYER
var array = new string[3];
array[0] = "Tripp;";
array[1] = "Trapp";
array[2] = "Trull";

foreach(var v in array)
{
    Console.WriteLine(v);
}
    Console.WriteLine();

Console.ReadLine();
//myGarage[] myGarages = new Vehicle[antal];
//garage[0] = 20;




//int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
//myIntArray[0] = 11;
//myIntArray[1] = 22;
//myIntArray[2] = 33;

//// Creates and initializes a new integer array and a new Object array.

//Object[] myObjArray = new Object[3] { 26, 27, 28 };


//                 garage.Park(new Airplane("1", "AIR111", "SAAB", "None", 2));

//// Prints the initial values of both arrays.
//Console.WriteLine("Initially,");
//Console.Write("integer array:");
//Console.WriteLine(myIntArray.Length);
//Console.WriteLine(myObjArray.Length);
//Console.WriteLine(garage.Park);



//// Declare a single-dimensional string array
//String[] array1d = { "zero", "one", "two", "three" };
//ShowArrayInfo(array1d);
//void ShowArrayInfo(string[] array1d)

//{
//    throw new NotImplementedException();
//}




//public void seekFirstFreeSpot()
//    {
//    foreach garage.
//}



Console.WriteLine();


Console.ReadLine();


//var hangar = new Garage<Airplane>(5);

garage.Park(new Airplane("1", "AIR111", "SAAB", "None", 2));
garage.Park(new Car("1", "AIR111", "SAAB", "None", "Gasoline"));
//garage.Unpark("AIR111");
foreach (var vehicle in garage)
{
    Console.WriteLine(vehicle.VehicleInfo());
}

//garage.Any(c => c.RegNr == "HejHej");
//garage.First(c => c.VisibleDamage == "None");


// Declare a single-dimensional string array
String[] array1d = { "zero", "one", "two", "three" };
ShowArrayInfo(array1d);
void ShowArrayInfo(string[] array1d)
{
    throw new NotImplementedException();
}

Console.ReadLine();
