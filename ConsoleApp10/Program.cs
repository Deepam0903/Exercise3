using System;

namespace ConsoleApp10
{
    class Car
    {
        string color = "red";
        int maxSpeed = 200;
        public string model;
        string col;
        int year;




        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        public Car()
        {
            model = "Mustang";
        }

        public Car(string modelName)
        {
            model = modelName;
        }

        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
            Console.WriteLine(myObj.maxSpeed);

            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.col = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.col = "white";
            Opel.year = 2005;
            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);

            Car my_1 = new Car();
            my_1.fullThrottle();

            Console.WriteLine(Ford.model);

            Car Ford1 = new Car("Mustang");
            Console.WriteLine(Ford1.model);

            Car Ford2 = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford2.color + " " + Ford2.year + " " + Ford2.model);




        }
    }



}