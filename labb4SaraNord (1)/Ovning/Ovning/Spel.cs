using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning
{
    public class Spel
    {
        public int ID { get; set; }
        public string Namn { get; set; }
        public string Pris { get; set; }
        public string Plattform { get; set; }
        public int Antal { get; set; }
        public bool Köpt { get; internal set; }

        public Spel(int id, string namn, string pris, string plattform, int antal)
        {
            ID = id;
            Namn = namn;
            Pris = pris;
            Plattform = plattform;
            Antal = antal;
        }
        public override string ToString()
        {
            return $"Namn: {Namn} ID: ({ID})";
        }
        public Spel()
        {
            Köpt = false;
        }
    }
}
