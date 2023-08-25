namespace BankaMVC.Areas.Admin.Models.Dtos.SterlinHesapDtos

{
    public class NewSterlinHesapDto
    {
        public int? SterlinHesapId { get; set; }
        public int? MusteriID { get; set; }
        public decimal? SterlinVarlik { get; set; }
        public DateTime? HesapTarih { get; set; }
        public string? HesapIban { get; set; }

    }
}
