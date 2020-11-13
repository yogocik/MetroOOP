using System;

namespace MetroOOP{
  class Triangle : BaseShape {
      protected double Tinggi;
      public Triangle(double tinggi, double alas, string model){
        Tinggi = tinggi;
        Lebar = alas;
        ModelName = model;
      }
      public double Luas(){
        return Tinggi*Lebar/2;
      }
      static void Main(string[] args){
        Console.WriteLine("This is derived object from BaseShape");
      }
    }
}
