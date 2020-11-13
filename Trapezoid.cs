using System;

namespace MetroOOP{
  class Trapezoid : Triangle {
      private int SisiAtas;
      private int SisiBawah; 
      static void Main(string[] args){
        Console.WriteLine("This is derived object from BaseShape")
      }
      public Trapezoid(double atas, double bawah, double tinggi,string model){
        SisiAtas = atas;
        SisiBawah = bawah;
        Tinggi = tinggi;
        ModelName = model;
      }
      public double Luas(){
        return (SisiAtas+SisiBawah)*Tinggi/2;
      }
    }
}
