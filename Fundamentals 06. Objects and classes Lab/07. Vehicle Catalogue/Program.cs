using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatalogVehicle catalog = new CatalogVehicle();  

            string input;
            while((input = Console.ReadLine()) != "end") 
            {
                string[] cmdArgs = input.Split('/');
                string type = cmdArgs[0];   
                string brand = cmdArgs[1];  
                string model = cmdArgs[2];
                
                if(type == "Car")
                {
                    int horsePower = int.Parse(cmdArgs[3]);
                    Car car = new Car(brand, model, horsePower);
                    catalog.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    int weight = int.Parse(cmdArgs[3]); 
                    Truck truck = new Truck(brand, model, weight);
                    catalog.Trucks.Add(truck);
                }
            }
            Console.WriteLine(catalog);
        }
    }

    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }   
        public string Model { get; set; }   
        public int Weight { get; set; } 
    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class CatalogVehicle
    {
        public CatalogVehicle()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
        public override string ToString()
        {
            StringBuilder catalogBuilder = new StringBuilder();
            if (this.Cars.Count > 0)
            {
                catalogBuilder.AppendLine("Cars:");
                foreach (Car car in this.Cars.OrderBy(c => c.Brand))
                {
                    catalogBuilder.AppendLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (this.Trucks.Count > 0)
            {
                catalogBuilder.AppendLine("Trucks:");
                foreach (Truck truck in this.Trucks.OrderBy(t => t.Brand))
                {
                    catalogBuilder.AppendLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

            return catalogBuilder.ToString().TrimEnd();
        }
    }
}
