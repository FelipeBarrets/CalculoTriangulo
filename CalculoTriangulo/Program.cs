using System;

namespace CalculoTriangulo
{
    public class Program
    {
        public static void Main()
        {
            double larg;
            double alt;
            Console.WriteLine("Insira a largura");
            larg = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a altura");
            alt = double.Parse(Console.ReadLine());
            area(larg, alt);
            perimetro(larg, alt);
            diametro(larg, alt);


        }
        static void area(double larg, double alt)
        {
            double area;
            area = larg * alt;
            Console.WriteLine("area= " + area.ToString("F"));
        }
        static void perimetro(double larg, double alt)
        {
            double perimetro;
            perimetro = larg * 2 + alt * 2;
            Console.WriteLine("perimetro= " + perimetro.ToString("F"));
        }
        static void diametro(double larg, double alt)
        {
            double diametro;
            diametro = Math.Sqrt(larg * larg + alt * alt);
            Console.WriteLine("diametro= " + diametro.ToString("F"));
        }

    }

}
