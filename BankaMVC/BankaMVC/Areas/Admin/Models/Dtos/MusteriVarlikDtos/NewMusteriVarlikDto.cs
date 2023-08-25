namespace BankaMVC.Areas.Admin.Models.Dtos.CategoryDtos
{
  public class NewMusteriVarlikDto
  {
        public int BankaId { get; set; }
        public int MusteriDataID { get; set; }
        // public string? MusteriAD { get; set; }
        public string? MusteriAD { get; set; }

        public bool HesapTLVadesiz { get; set; }
        public bool? HesapTLVadeli { get; set; }
        public bool? HesapDolarVadesiz { get; set; }
        public bool? HesapEuroVadesiz { get; set; }
        public bool? HesapSterlinVadesiz { get; set; }
        public bool? HesapAltinVadesiz { get; set; }
        public bool? HesapGumusVadesiz { get; set; }
        public int? VadesizTLHesapID { get; set; }
        public int? VadeliTLHesapID { get; set; }
        public int? DolarHesapID { get; set; }
        public int? EuroHesapID { get; set; }
        public int? SterlinHesapID { get; set; }
        public int? KurKorumalıTLHesapID { get; set; }
        public int? AltinHesapID { get; set; }
        public int? GumusHesapID { get; set; }
        public int? BankaKartlarID { get; set; }
        public int? KrediKartlarID { get; set; }
        public int? IbanlarID { get; set; }
    }
}
