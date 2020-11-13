using System;

namespace MetroOOP{
  class Elips : Circle {
      private MajorAxis;
      private MinorAxis;
      static void Main(string[] args){
        Console.WriteLine("This is derived object from BaseShape")
      }
      public Elips(double major, double minor, string model){
        MajorAxis = major;
        MinorAxis = minor;
        ModelName = model;
      }
      public double Luas(){
        return Phi*MajorAxis*MinorAxis
      }
    }
}
