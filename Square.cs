using System;

namespace MetroOOP{
  class Square : BaseShape {
      static void Main(string[] args){
        Console.WriteLine("This is derived object from BaseShape");
      }
      public Square(double panjang,double lebar,string model){
        Panjang = panjang;
        Lebar = lebar;
        ModelName = model;
      }
    }
}

