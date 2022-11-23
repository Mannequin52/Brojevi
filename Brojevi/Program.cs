using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskoTijelo
{
    class Program
    {
        class Brojevi
        {
            private double broj;

            public double Broj { get => broj; set => broj = value; }
            public virtual double ApsVrijednost()
            {
                return 0;
            }

        }

        class Cijeli : Brojevi
        {
            public virtual double ApsVrijednost()
            {
                return 0;
            }
        }
        class Decimalni : Brojevi
        {
            public virtual double ApsVrijednost()
            {
                return 0;
            }
        }
        class Pozitivni : Cijeli
        {
            public virtual double ApsVrijednost()
            {
                return 0;
            }
        }
        class Negativni : Cijeli
        {

        }



        static public void Main(string[] args)
        {
            Pozitivni x = new Pozitivni();
            Cijeli y = new Cijeli();
            Decimalni z = new Decimalni();

            x.Pozitivni = 100;
            y.Cijeli = -100;
            z.Decimalni = 100.45;

            Console.WriteLine(x.Pozitivni + y.Cijeli + z.Decimalni);


        }
    }
}
