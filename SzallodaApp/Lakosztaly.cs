using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp
{
    public class Lakosztaly:Szoba
    {
        public int ExtraSzolgaltatasAr { get; set; }

        public Lakosztaly(int szobaSzam, int Alapar, int extraSzolgaltatasAr) : base(szobaSzam, Alapar)
        {
            Szobaszam = szobaSzam;
            extraSzolgaltatasAr = ExtraSzolgaltatasAr;
            alapar = Alapar;
        }
        
        public override int ArKiszamitas(int ejszakakSzama):base(arkiszamitas())
        {
            ejszakakSzama = 3;
            return alapar * ejszakakSzama;
        }
        public override string ToString():base(ToString())
        {
            return $"Extra szolgáltatás: {ExtraSzolgaltatasAr}Ft";
        }
    }

}
