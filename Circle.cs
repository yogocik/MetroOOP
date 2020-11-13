using System;

namespace MetroOOP{
 class Circle : BaseShape {
      protected int Phi = 3.14 ;
      protected int Radius;

      public Circle(double radius,string model){
        Radius = radius;
        ModelName = model;
      }
      public double Luas(){
        return Phi*Math.Pow(Radius,2);
      }
      static void Main(string[] args){
        Console.WriteLine("This is derived object from BaseShape");
      }
    }
}
