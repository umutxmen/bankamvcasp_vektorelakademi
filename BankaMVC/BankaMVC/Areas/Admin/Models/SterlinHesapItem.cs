namespace BankaMVC.Areas.Admin.Models

{
    public class SterlinHesapItem 
    {
        public int? SterlinHesapId { get; set; }
        public int? MusteriID { get; set; }
        public decimal? SterlinVarlik { get; set; }
        public DateTime? HesapTarih { get; set; }
        public string? HesapIban { get; set; }
    }
}
