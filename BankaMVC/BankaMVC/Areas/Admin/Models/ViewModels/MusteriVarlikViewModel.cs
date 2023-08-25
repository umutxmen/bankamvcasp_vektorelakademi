namespace BankaMVC.Areas.Admin.Models.ViewModels
{
    public class MusteriVarlikViewModel
    {
        public int musteriVarlikID { get; set; }
        public int musteriDataID { get; set; }
        public int bankaId { get; set; }
        public bool hesapTLVadesiz { get; set; }
        public bool hesapTLVadeli { get; set; }
        public bool hesapDolarVadesiz { get; set; }
        public bool hesapEuroVadesiz { get; set; }
        public bool hesapSterlinVadesiz { get; set; }
        public bool hesapAltinVadesiz { get; set; }
        public bool hesapGumusVadesiz { get; set; }
        public int vadesizTLHesapID { get; set; }
        public int vadeliTLHesapID { get; set; }
        public int dolarHesapID { get; set; }
        public int euroHesapID { get; set; }
        public int sterlinHesapID { get; set; }
        public int kurKorumalıTLHesapID { get; set; }
        public int altinHesapID { get; set; }
        public int gumusHesapID { get; set; }
        public int bankaKartlarID { get; set; }
        public int krediKartlarID { get; set; }
        public int ibanlarID { get; set; }
    }
}
