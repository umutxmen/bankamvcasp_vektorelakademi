namespace BankaMVC.Areas.Admin.Models
{
    public class MusteriDataItem
    {
        public int MusteriDataID { get; set; }

        public string MusteriAD { get; set; }
        public string MusteriSoYAD { get; set; }
        public string? MusteriTC { get; set; }
        public string? MusteriTEL { get; set; }
        public string? MusteriMeslek { get; set; }
        public string? MusteriAdres { get; set; }
        public string? MusteriEmail { get; set; }
        public string? MusteriAnneliksoyad { get; set; }
        public string? PicturePath { get; set; }
        public List<MusteriVarlikItem>? MusteriVarlik { get; set; }


    }
}
