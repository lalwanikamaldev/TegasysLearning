using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLearning
{

    // parameterized constructor //
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // parameterized constructor //
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public void DisplayCarDetails()
        {
            Console.WriteLine($"Make: {Ferrari}, Model: {Roma}, Year: {2023}");
        }
    }

    // non-parameterized constructor //
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // non-parameterized constructor
        public Person()
        {
            Name = "John Wick";
            Age = 46;
        }

        public void DisplayPersonDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

  
    public class Program
    {
        public static void Main()
        {
            // 1st code example //
            Car car1 = new Car("Ferrari", "Roma", 2023);
            car1.DisplayCarDetails();

            // 2nd code example //
            Person person1 = new Person();
            person1.DisplayPersonDetails(); 
        }
    }
