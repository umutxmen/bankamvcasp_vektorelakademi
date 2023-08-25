namespace BankaMVC.Areas.Admin.Models

{
    public class EuroHesapItem 
    {
        public int EuroHesapID { get; set; }
        public int MusteriID { get; set; }
        public decimal? EuroVarlik { get; set; }
        public DateTime? HesapTarih { get; set; }
        public string? HesapIban { get; set; }


    }
}
