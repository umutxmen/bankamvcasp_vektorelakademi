namespace BankaMVC.Areas.Admin.Models

{
    public class GumusHesapItem
    {
        public int GümüsHesapID { get; set; }
        public int MusteriID { get; set; }
        public decimal? GümüsVarlikGram { get; set; }
        public DateTime? HesapTarih { get; set; }
    }
}
