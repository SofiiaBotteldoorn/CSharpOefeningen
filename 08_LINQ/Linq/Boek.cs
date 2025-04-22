namespace Linq
{
    public class Boek
    {
        public int BoekId { get; set; }
        public string Titel { get; set; } = null!;
        public string Auteur { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public int PaginaAantal { get; set; }
        public decimal Prijs { get; set; }
    }
}
