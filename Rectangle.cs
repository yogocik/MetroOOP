using System;

namespace MetroOOP{
  class Rectangle : BaseShape {
      static void Main(string[] args){
        Console.WriteLine("This is derived object from BaseShape");
      }
      public Rectangle(double panjang,double lebar,string model){
        Panjang = panjang;
        Lebar = lebar;
        ModelName = model;
      }
    }
}
