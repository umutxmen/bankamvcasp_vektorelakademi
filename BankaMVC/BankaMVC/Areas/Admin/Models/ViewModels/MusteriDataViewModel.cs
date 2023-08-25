namespace BankaMVC.Areas.Admin.Models.ViewModels
{
    public class MusteriDataViewModel
    {
        public int musteriDataID { get; set; }
        public string musteriAD { get; set; }
        public string musteriSoYAD { get; set; }
        public string musteriTC { get; set; }
        public string musteriTEL { get; set; }
        public string musteriMeslek { get; set; }
        public string musteriAdres { get; set; }
        public string musteriEmail { get; set; }
        public string musteriAnneliksoyad { get; set; }
        public string picturePath { get; set; }
        public List<MusteriVarlikViewModel> musteriVarlik { get; set; }
    }
}
