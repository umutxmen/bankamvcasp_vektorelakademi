namespace BankaMVC.Areas.Admin.Models.Dtos.VadesizTLHesapDtos

{
    public class NewVadesizTLHesapDto 
    {
        public int? MusteriID { get; set; }
        public decimal? HesapTutar { get; set; }
        public DateTime? HesapAcilmaTarih { get; set; }
        public string? HesapIBAN { get; set; }

    }
}
