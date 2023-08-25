namespace BankaMVC.Areas.Admin.Models.Dtos.NakitAvansDtos

{
    public class NewNakitAvansDto
    {
        public int MusteriID { get; set; }
        public int? Aktarılanİban { get; set; }
        public DateTime? SonOdemeTarihi { get; set; }
        public decimal? AvansMiktari { get; set; }
        public decimal? Faizorani { get; set; }
        public decimal? odenecekMiktar { get; set; }

    }
}
