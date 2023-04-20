using System;
namespace carSpace
{
    class Car
    {
        public int id{get;}
        public String mark {get; set;}
        public String model;
        public int year;
        public String color;
        public double price;
        public Boolean aviable;

        public Car(int Id, String Mark, String Model, int Year, String Color, double Price, Boolean Aviable) {
          id = Id;
          mark = Mark;
          model = Model;
          year = Year;
          color = Color;
          price = Price;
          aviable = Aviable;
        }

        public void Print() {
            Console.WriteLine($"{id} {mark} {model} {year} {color} {price} {aviable}");
        }

    }






}


