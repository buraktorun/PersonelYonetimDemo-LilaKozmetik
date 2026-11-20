using static DataAccess.Enum.Enum;

namespace DataAccess.Entity
{
    public class Personel
    {
        public int Id { get; set; }
        public bool Aktif { get; set; } = true;
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string? Telefon { get; set; }
        public decimal Maas { get; set; }
        public string? Aciklama { get; set; }
        public Departman Departman { get; set; }
    }
}
