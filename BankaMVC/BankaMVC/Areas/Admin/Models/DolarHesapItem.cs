namespace BankaMVC.Areas.Admin.Models
{
    public class DolarHesapItem
    {
        public int DolarHesapID { get; set; }
        public int MusteriID { get; set; }
        public decimal? DolarVarlik { get; set; }
        public DateTime? HesapTarihi { get; set; }
        public string? HesapIban { get; set; }
    }
}
