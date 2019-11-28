using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib_Vererbung_001
{
    class CKreis
    {
        // ---- Konstanten ----
        const double pi = Math.PI;

        // ---- Eigenschaften ----
        protected int x;
        int y;
        double radius;

        // ---- Konstruktoren ----
        public CKreis()
        {
            this.x = 0;
            this.y = 0;
            this.radius = 0;
        }

        public CKreis(int x, int y, double r)
        {
            this.x = x;
            this.y = y;
            radius = r;
        }

        // ---- Methoden ----
        public double GetArea()
        {
            return Math.Pow(radius, 2) * pi;
        }
    }

    class CGraphischKreis : CKreis
    {

        public void zeichnen()
        {
            Console.WriteLine("Der Kreis wird gezeichnet.");
        }

        public void test()
        {
            x = 30;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CKreis kreis = new CKreis(200, 100, 10);
            double area = kreis.GetArea();
            Console.WriteLine("Die Fläche von 'kreis' beträgt " + area);

            CGraphischKreis kreiszeichnen = new CGraphischKreis();
            kreiszeichnen.zeichnen();

            CKreis kreis2 = kreiszeichnen;

            // 



            // Console.ReadLine();
        }
    }
}
