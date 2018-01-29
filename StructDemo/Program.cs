using System;
using System.Reflection;

namespace StructDemo {
    class Program {
        static void Main (string[] args) {
            // Create a struct
            Car myCar = new Car ();
            myCar.Brand = "BMW";
            myCar.Model = "i8";
            myCar.Color = "Black";
            myCar.Accelerate ();

            var secondCar = myCar;
            secondCar.Color = "Silver";
            // Struct is value type so myCar props are not changed
            myCar.Accelerate ();
            secondCar.Accelerate ();

            // =================
            var studentArrays = new Student[5] { new Student (1, "Alex", 15), new Student (2, "Anna", 16), new Student (3, "Kim", 14), new Student (4, "Yuri", 14), new Student (5, "Dan", 16) };
            // studentArrays[0].Name = "Alex";
            
            //
            
        }
        

    }
    struct Car {
        public string Brand;
        public string Model;
        public string Color;

        public void Accelerate () {
            System.Console.WriteLine ($"{this.Color} {this.Brand} {this.Model} is speeding...");
        }
    }
    struct Student {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void Study () {
            System.Console.WriteLine ($"{this.Name} is studying");
        }
        public Student (int id, string name, int age) {
            this.ID = id;
            this.Name = name;
            this.Age = age;
        }
    }
    struct Teacher {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void Teach () {
            System.Console.WriteLine ($"{this.Name} is teaching");
        }
    }
}