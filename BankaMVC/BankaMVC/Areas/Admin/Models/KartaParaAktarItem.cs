namespace BankaMVC.Areas.Admin.Models

{
    public class KartaParaAktarItem
    {
        public int KartaParaİslemID { get; set; }
        public int MusteriID { get; set; }
        public int AktarılacakKartID { get; set; }
        public int VarlıkHesabı { get; set; }
        public decimal Miktar { get; set; }
        public DateTime? İslemTarihi { get; set; }

    }
}
