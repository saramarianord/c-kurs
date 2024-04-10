namespace Ovning
{
    public class Book
    {

        public int ID { get; set; }
        public string Namn { get; set; }
        public string Pris { get; set; }
        public string Författare { get; set; }
        public string Genre { get; set; }
        public string Format { get; set; }
        public string Språk { get; set; }
        public int Antal { get; set; }
        public bool Köpt { get; internal set; }

        public Book(int id, string namn, string pris, string författare, string genre, string format, string språk, int antal)
        {
            ID = id;
            Namn = namn;
            Pris = pris;
            Författare = författare;
            Genre = genre;
            Format = format;
            Språk = språk;
            Antal = antal;
        }
        public override string ToString()
        {
            return $"Namn: {Namn} ID: ({ID})";
        }
        public Book()
        {
            Köpt = false;
        }
    }
}
