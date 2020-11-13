using System;

namespace MetroOOP{
 class Sector : Circle {
      private double Angle;
      static void Main(string[] args){
        Console.WriteLine("This is derived object from BaseShape")
      }
      public Sector(double sudut, double radius ,string model){
        Radius = radius;
        Angle = sudut;
        ModelName = model;
      }
      public double Luas() {
        return Phi*Math.pow(Radius,2)*Angle/360;
      }
    }
}
