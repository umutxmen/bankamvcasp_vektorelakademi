namespace BankaMVC.Areas.Admin.Models.Dtos.DolarSwiftDtos
{
    public class PutDolarSwiftDto
    {
        public int DolarSwiftID { get; set; }
        public int MusteriID { get; set; }
        public string? GidenHesapIban { get; set; }
        public string? AlanHesapIban { get; set; }
        public DateTime? SwiftTarihi { get; set; }
        public decimal? Miktar { get; set; }
        public int? SwiftKodu { get; set; }
        public string? Aciklama { get; set; }
    }
}
