using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson10_WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B2";

            Book b1 = new Book();
            b1.Author = "Robert Taylore";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";
            */

            // ArrayLists are dynamically sized (not set in advance)
            //Support sorting, removing items, etc.
            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            //not strongly typed - can put different types in
            myArrayList.Add(b1);
            //myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                //will throw an error when we get to the book in the ArrayList
                Console.WriteLine(car.Make);
            }
            */

            /*
            //List<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1); gives an error
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */

            /*
            //Dictionary<TKey, TValue>
            //TKey - unique ID, like in Access
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);
            */

            //string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            //Object initializer syntax
            //No need for a constructor
            //Car car1 = new Car() { Make = "BMW", Model = "750Li", VIN = "C3" };
            //Car car2 = new Car() { Make = "Toyota", Model = "Prius", VIN = "D4" };

            //Collection initializer
            List<Car> myList = new List<Car>() {
                new Car { Make = "Oldsmobile", Model = "Cutlas Supreme", VIN = "E5" },
                new Car { Make = "Nissan", Model = "Altima", VIN = "F6" }
            };
        
            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
