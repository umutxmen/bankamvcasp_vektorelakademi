namespace BankaMVC.Areas.Admin.Models.Dtos.NakitAvansDtos

{
    public class PutNakitAvansDto
    {
        public int NakitAvansID { get; set; }
        public int MusteriID { get; set; }
        public int? Aktarılanİban { get; set; }
        public DateTime? SonOdemeTarihi { get; set; }
        public decimal? AvansMiktarı { get; set; }
        public decimal? Faizoranı { get; set; }
        public decimal? odenecekMiktar { get; set; }
    }
}
