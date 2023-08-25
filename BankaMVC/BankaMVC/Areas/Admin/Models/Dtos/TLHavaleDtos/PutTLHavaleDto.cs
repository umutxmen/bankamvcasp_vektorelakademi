namespace BankaMVC.Areas.Admin.Models.Dtos.TLHavaleDtos

{
    public class PutTLHavaleDto 
    {
        public int HavaleID { get; set; }
        public int MusteriID { get; set; }
        public string? GidenHesapIban { get; set; }
        public string? AlanHesapIban { get; set; }
        public DateTime? İslemTarih { get; set; }
        public decimal? Miktar { get; set; }
        public string? Aciklama { get; set; }
    }
}
