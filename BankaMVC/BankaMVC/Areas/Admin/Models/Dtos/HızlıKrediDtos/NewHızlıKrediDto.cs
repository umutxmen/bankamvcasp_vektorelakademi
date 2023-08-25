namespace BankaMVC.Areas.Admin.Models.Dtos.HızlıKrediDtos

{
    public class NewHızlıKrediDto
    {
        public int MusteriID { get; set; }
        public string? Aktarılacakİban { get; set; }

        public decimal? KrediMiktar { get; set; }
        public decimal? KrediFaiz { get; set; }
        public DateTime? KrediÇekimTarihi { get; set; }
        public int? KrediTaksitSayısı { get; set; }
        public DateTime? KrediSonOdemeTarih { get; set; }
        public decimal? KrediSonodemeTutar { get; set; }
    }
}
