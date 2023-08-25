namespace BankaMVC.Areas.Admin.Models.Dtos.VadeliTLHesapDtos

{
    public class NewVadeliTLHesapDto 
    {
        public int MusteriID { get; set; }
        public decimal Varlık { get; set; }
        public DateTime? VadeBasTarihi { get; set; }
        public DateTime? VadeBitisTarihi { get; set; }
        public int? VadeliFaizoran { get; set; }
        public decimal? VadeSonuMiktar { get; set; }

    }
}
