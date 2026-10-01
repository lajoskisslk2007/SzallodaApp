using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp
{
    public class Szoba
    {
        public int Szobaszam { get; set; }
        protected int alapar { get; set; }
        public int Alapar
        {
            get { return alapar; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Az alapár nem lehet negatív.");
                }
                alapar = value;
            }
        }
        public Szoba (int szobaSzam, int alaperAr,int Alapar)
        {
            Szobaszam = szobaSzam;
            Alapar = alaperAr;
            alapar = Alapar;
        }
        public virtual int arkiszamitas()
        {
            return Alapar*alapar;
        }
        public override string ToString()
        {
            return  ($"Szoba{Szobaszam} | Alapár: {alapar} Ft / éj");
        }

    }
}
