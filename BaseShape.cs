using System;

namespace MetroOOP {
   class BaseShape {
      //member variables
      public double Panjang;
      public double Lebar;
      public string ModelName;      
      public double Luas() {
         return Panjang * Lebar;
      }
      public void TampilkanLuas() {
         Console.WriteLine("Model: {0}", ModelName);
         Console.WriteLine("Luas: {0}", Luas());
      }
      public BaseShape(double panjang, double lebar, string model)
        {
            Panjang = panjang;
            Lebar = lebar;
            ModelName = model;
        }

    }
}