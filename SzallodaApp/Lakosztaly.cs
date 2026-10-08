using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp
{
    public class Lakosztaly:Szoba
    {
        public int ExtraSzolgaltatasAr { get; set; }

        public Lakosztaly(int SzobaSzam, int Alapar, int ExtraSzolgaltatasAr) : base(SzobaSzam, Alapar)
        {
            this.ExtraSzolgaltatasAr = ExtraSzolgaltatasAr;
        }
        
        public override int Arkiszamitas(int ejszakakSzama)
        {
            return base.Arkiszamitas(ejszakakSzama) + ExtraSzolgaltatasAr;
        }
        public override string ToString()
        {
            return $"b{base.ToString()} | Extra szolgáltatás: {ExtraSzolgaltatasAr}Ft";
        }
    }

}
