namespace BankaMVC.Areas.Admin.Models.Dtos.KartaParaAktarDtos

{
    public class PutKartaParaAktarDto
    {
        public int KartaParaİslemID { get; set; }
        public int MusteriID { get; set; }
        public int AktarılacakKartID { get; set; }
        public int VarlıkHesabı { get; set; }
        public decimal Miktar { get; set; }
        public DateTime? İslemTarihi { get; set; }
    }
}
