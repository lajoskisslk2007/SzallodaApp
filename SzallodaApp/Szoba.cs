using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp
{
    public class Szoba
    {
        public int SzobaSzam { get;}
        protected int alapar;
        public int Alapar
        {
            get { return alapar; }
            set
            {
                if (value > 0)  alapar = value; 
            }
        }
        public Szoba (int SzobaSzam ,int Alapar)
        {
            this.SzobaSzam = SzobaSzam;
            this.Alapar = Alapar;
        }
        public virtual int Arkiszamitas(int ejszakakSzama)
        {
            return Alapar*ejszakakSzama;
        }
        public override string ToString()
        {
            return  $"Szoba{SzobaSzam} | Alapár: {Alapar} Ft / éj";
        }

    }
}
