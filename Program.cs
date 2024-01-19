﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week_01_lab_02_Cars_W
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(2022, "Toyota Camry", 25000);
            Car car2 = new Car(2021, "Honda Accord", 23000, false);
            Car car3 = new Car(2023, "Ford Mustang", 45000);
            Car car4 = new Car(2020, "Chevrolet Malibu", 20000, true);

            Console.WriteLine("Car 1: " + car1);
            Console.WriteLine("Car 2: " + car2);
            Console.WriteLine("Car 3: " + car3);
            Console.WriteLine("Car 4: " + car4);

            if (car1 == car2)
            {
                System.Console.WriteLine("This is a test");
            }




            else



            {
                System.Console.WriteLine("This is not a test");
            }
        }
    }


    public class Car
    {
        private int year;
        private string model;
        private double price;
        private bool isDrivable;

        public Car(int year, string model, double price, bool isDrivable = true)
        {
            this.year = year;
            this.model = model;
            this.price = price;
            this.isDrivable = isDrivable;
        }

        public override string ToString()
        {
            return $"Year: {year}, Model: {model}, Is Drivable: {isDrivable}, Price: {price}";
        }

    }


}
