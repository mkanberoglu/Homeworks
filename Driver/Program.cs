using System.Drawing;
using System.Runtime.CompilerServices;

namespace CarDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver surucu = new Driver(name: "Veli", age: 22, car: new Car(brand :"Bentley", model : "2021", color: "beyaz"));
            Driver surucu1 = new Driver(name: "Ramazan", age: 24, car: new Car(brand: "Mercede", model: "2022", color: "siyah"));
        }
        public class Driver
        {
            string name;
            int age;
            Car car;
            static DateTime raceStart;
            DateTime driverStartTime = DateTime.Now;
            
            public Driver(string name, int age, Car car)
            {
                this.name = name;
                this.age = age;
                this.car = car;
                string msg = $"{this.name} {this.age} yaşında, {this.car.model} model {this.car.color} {this.car.brand} aracı ile {raceStart - driverStartTime} fark ile yarışa başladı.";
                Console.WriteLine(msg);
            }
            static Driver()
            {
                raceStart = DateTime.Now;
                string msg = $"Yarış {raceStart}'de başladı. ";
                Console.WriteLine(msg);
            }
        }
        public class Car
        {
            public string brand;
            public string model;
            public string color;
            public Car(string brand, string model, string color)
            {
                this.brand = brand;
                this.model = model;
                this.color = color;
            }
        }
    }
}