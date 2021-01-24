﻿using System;

namespace Multiple_Classes
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; } = String.Empty;
        public string Vendor { get; set; } = String.Empty;
        public string Volume { get; set; } = String.Empty;
        public DateTime ProduceYear { get; set; } = DateTime.Now;

        public Car(in int id, in string model, in string vendor, in string volume, in DateTime produceYear)
        {
            Id = id;
            Model = model;
            Vendor = vendor;
            Volume = volume;
            ProduceYear = produceYear;
        }
        public int Age
        {
            get
            {
                var years = DateTime.Now.Year - ProduceYear.Year;
                return years;
            }
        }

        public void Show()
        {
            Console.WriteLine($"Car ID: {Id}");
            Console.WriteLine($"Car Model: {Model}");
            Console.WriteLine($"Car Vendor: {Vendor}");
            Console.WriteLine($"Car Volume: {Volume}");
            Console.WriteLine($"Car Produce Year: {ProduceYear.ToString("F")}");
            Console.WriteLine($"Car Age: {Age}");
        }
    }
}
