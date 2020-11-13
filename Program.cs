using System;

namespace MetroOOP
{
    class Program
    {
        try 
            {
               static void Main(string[] args)
                    {
                        public double Panjang = 20;
                        public double Lebar = 10;
                        public double Tinggi = 2;
                        public double Jari = 4;
                        public double MajoxAx = 10;
                        public double MinorAx = 5;
                        public double SAtas = 10;
                        public double SBawah = 20;
                        public double Sudut = 60;
                        BaseShape Base = new BaseShape(Panjang, Lebar, "BaseShape");
                        Square Persegi = new Square(Panjang, Lebar, "Square");
                        Rectangle PersegiPanjang = new Rectangle(Panjang, Lebar, "Rectangle");
                        Triangle Segitiga = new Triangle(Tinggi, Lebar, "Triangle");
                        Circle Lingkaran = new Circle(Jari, "Circle");
                        SideCube JajarGenjang = new SideCube(Panjang, Lebar, "Parallelogram");
                        Trapezoid Trapesium = new Trapesium(SAtas, SBawah, Tinggi, "Trapezoid");
                        Elips Elipsis = new Square(MajoxAx, MinorAx, "Elips");
                        Sector Juring = new Sector(Sudut, Jari, "Sector");
                     }
            }
        catch (Exception e) 
            {
                Console.WriteLine(e.Message)
            }
        finally
            {
                Console.WriteLine("Exception Mechanism Done")
            }
    }
}
