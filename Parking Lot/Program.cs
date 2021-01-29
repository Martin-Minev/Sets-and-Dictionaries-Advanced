using System;
using System.Linq;
using System.Collections.Generic;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string input = string.Empty;
            while ((input=Console.ReadLine()) != "END")
            {
                string[] cmdArgs = input.Split(", ");
                string direction = cmdArgs[0];
                string plate = cmdArgs[1];

                if (!cars.Contains(plate))
                {
                    if (direction == "IN")
                    {
                        cars.Add(plate);
                    }
                }
                else
                {
                    if (direction == "OUT")
                    {
                        cars.Remove(plate);
                    }
                }
            }
            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
