using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_geometria
{
    internal class Rettangolo
    {
        private readonly double @base;
        private readonly double altezza;
        private readonly string numeroRettangolo;

        public Rettangolo(double @base, double altezza, string numeroRettangolo) 
        {
            this.@base = @base;
            this.altezza = altezza; 
            this.numeroRettangolo = numeroRettangolo;
        }


        public double Area() 
        {
            double area = @base * altezza;
            return area;
        }

        public double Perimetro()
        {
            double perimetro = (@base + altezza) * 2;
            return perimetro ;
        }
        public void Stampa()
        {
            Console.WriteLine("Rettangolo Numero {0}", numeroRettangolo);
            Console.WriteLine("base {0} cm", @base);
            Console.WriteLine("altezza {0} cm", @altezza);
            Console.WriteLine("Area {0} cm^2", Area());
            Console.WriteLine("Perimetro {0} cm", Perimetro());
            Console.WriteLine();
        }

      

    }

    
}
