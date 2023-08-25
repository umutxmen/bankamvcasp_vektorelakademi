namespace BankaMVC.Areas.Admin.Models.Dtos.GümüsHesapDtos

{
    public class NewGumusHesapDto
    {
        public int MusteriID { get; set; }
        public decimal? GümüsVarlikGram { get; set; }
        public DateTime? HesapTarih { get; set; }
    }
}
