using System;
using System.Linq;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make hash set and add 4 cars .. then add one more of the same
            HashSet<string> carHash = new HashSet< string >();
            {
                carHash.Add("Bugatti Chiron");
                carHash.Add("Pagani Huayra");
                carHash.Add("Lykan Hypersport");
                carHash.Add("Aston Martin");
                carHash.Add("Aston Martin");
            };
            //Make new hash set and add two cars
            HashSet<string> unionLot = new HashSet<string>();
            {
                carHash.Add("Toyota Camry");
                carHash.Add("Honda Civic");
            }
            //remove a car from a hash set
            carHash.Remove("Bugatti Chiron");
            //combine two hash sets with union
            carHash.UnionWith(unionLot);

            // foreach(string car in carHash){
            //     Console.WriteLine(car);
            // }
            //write it to the terminal
            Console.WriteLine("Car Hash set contains: {0} cars", carHash.Count);
        }
    }
}
