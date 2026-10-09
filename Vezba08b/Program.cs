using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba08b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tacka t1; // promenljiva t1 tipa Tacka - null
            t1 = new Tacka(); // objekat tipa Tacka
            Tacka.PrikaziTacku(t1);
            t1.Ime="T1";
            t1.X = 3.1;
            t1.Y= 4.2;
            t1.Prikazi();
            Console.WriteLine("D1: " + t1.D);
            Tacka t2 = new Tacka(5.1, 6.2, "T2");
            t2.Prikazi();
            Tacka t3=new Tacka("T3");
            t3.Prikazi();
            Tacka t4 = new Tacka(t2);
            t4.Pomeri(1, 1);
            t4.Prikazi();
        }
    }
    class Tacka
    {
        private double x;
        private double y;
        private string ime;
        // svojstva
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                if(value < 0)
                    this.x = - value;
                else
                    this.x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                this.y = value;
            }
        }
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                this.ime = value;
            }
        }
        public double D
        {
            get { return Math.Sqrt(x * x + y * y); }
        }
        // konstruktor
        public Tacka()
        {
            x = 0;
            y = 0;
            ime = "T";
        }
        public Tacka(double x, double y, string ime)
        {
            this.x = x;
            this.y = y;
            this.ime = ime;
        }
        public Tacka(string ime)
        {
            this.x = 0;
            this.y = 0;
            this.ime = ime;
        }
        public Tacka (Tacka t)
        {
            this.x = t.x;
            this.y = t.y;
            this.ime = t.ime;
        }
        public static void PrikaziTacku(Tacka t)
        {
            Console.WriteLine(t.ime + ": " + t.x + " , " + t.y);
        }
        public void Prikazi()
        {
            Console.WriteLine(ime + ": " + x + " , " + y);
        }
        public double UdaljenostOdKP()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public void Pomeri(double dx, double dy)
        {
            this.x += dx;
            this.y += dy;
        }
    }
}
