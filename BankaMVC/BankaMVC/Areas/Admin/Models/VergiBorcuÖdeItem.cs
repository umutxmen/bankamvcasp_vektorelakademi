namespace BankaMVC.Areas.Admin.Models

{
    public class VergiBorcuÖdeItem
    {
        public int VergiodeİslemID { get; set; }
        public int MusteriID { get; set; }
        public string vergino { get; set; }
        public string MusteriTCNo { get; set; }
        public string GondericiIBAN { get; set; }
        public string GondericiAD { get; set; }
        public string GondericiSoyad { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? OdemeTarih { get; set; }
    }
}
