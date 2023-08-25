namespace BankaMVC.Areas.Admin.Models

{
    public class FaturaOdeItem
    {
        public int FaturaYatırİslemID { get; set; }
        public int MusteriID { get; set; }
        public string faturano { get; set; }
        public string Gonderenİban { get; set; }
        public decimal odenecekMiktar { get; set; }
        public DateTime? OdemeTarih { get; set; }
        public string? Aciklama { get; set; }
    }
}
