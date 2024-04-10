using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning
{
    public class Filmer
    {
        public int ID { get; set; }
        public string Namn { get; set; }
        public string Pris { get; set; }
        public string Format { get; set; }
        public string Speltid { get; set; }
        public int Antal{ get; set; }
        public bool Köpt { get; internal set; }

        public Filmer(int id, string namn, string pris, string format, string speltid, int antal)
        {
            ID = id;
            Namn = namn;
            Pris = pris;
            Format = format;
            Speltid = speltid;
            Antal = antal;
        }
        public override string ToString()
        {
            return $"Namn: {Namn} ID: ({ID})";
        }
        public Filmer()
        {
            Köpt = false;
        }
    }
}

