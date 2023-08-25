namespace BankaMVC.Areas.Admin.Models.Dtos.DolarHesap
{
    public class PutDolarHesapDto
    {
        public int DolarHesapID { get; set; }
        public int MusteriID { get; set; }
        public decimal? DolarVarlik { get; set; }
        public DateTime? HesapTarihi { get; set; }
        public string? HesapIban { get; set; }
    }
}
