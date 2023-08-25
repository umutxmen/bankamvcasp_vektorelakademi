namespace BankaMVC.Areas.Admin.Models.Dtos.KurKorumalıHesapDtos

{
    public class NewKurKorumalıHesapDto
    {
        public int MusteriID { get; set; }
        public decimal? VarlikTL { get; set; }
        public int? DovizID { get; set; }
        public DateTime? HesapAcimTarihi { get; set; }
        public decimal? HesapAcimKuru { get; set; }
        public DateTime? HesapKapanmaTarihi { get; set; }
        public decimal? HesapKapanmaKuru { get; set; }
        public int? HesapFaizoran { get; set; }
    }
}
