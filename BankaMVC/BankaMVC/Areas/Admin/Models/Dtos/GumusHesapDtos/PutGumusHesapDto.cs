namespace BankaMVC.Areas.Admin.Models.Dtos.GümüsHesapDtos

{
    public class PutGumusHesapDto
    {
        public int GümüsHesapID { get; set; }
        public int MusteriID { get; set; }
        public decimal? GümüsVarlikGram { get; set; }
        public DateTime? HesapTarih { get; set; }
    }
}
