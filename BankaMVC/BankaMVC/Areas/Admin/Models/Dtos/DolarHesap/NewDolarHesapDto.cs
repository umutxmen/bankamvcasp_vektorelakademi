namespace BankaMVC.Areas.Admin.Models.Dtos.DolarHesap
{
    public class NewDolarHesapDto
    {
        public int MusteriID { get; set; }
        public decimal? DolarVarlik { get; set; }
        public DateTime? HesapTarihi { get; set; }
        public string? HesapIban { get; set; }
    }
}
