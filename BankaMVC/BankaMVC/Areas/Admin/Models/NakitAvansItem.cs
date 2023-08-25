namespace BankaMVC.Areas.Admin.Models

{
    public class NakitAvansItem 
    {
        public int NakitAvansID { get; set; }
        public int MusteriID { get; set; }
        public int? Aktarılanİban { get; set; }
        public DateTime? SonOdemeTarihi { get; set; }
        public decimal? AvansMiktari { get; set; }
        public decimal? Faizorani { get; set; }
        public decimal? OdenecekMiktar { get; set; }
      
    }
}
