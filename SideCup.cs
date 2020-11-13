using System;

namespace MetroOOP{
  class SideCube : Triangle {
      static void Main(string[] args){
        Console.WriteLine("This is derived object from BaseShape");
      }
      public SideCube(double sisi, double tinggi,string model){
        Lebar = sisi;
        Tinggi = tinggi;
        ModelName = model;
      }
      public double Luas(){
        return Lebar*Tinggi;
      }
  }
}
