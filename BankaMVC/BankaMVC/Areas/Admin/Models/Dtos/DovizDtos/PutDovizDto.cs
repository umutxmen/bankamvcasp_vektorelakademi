namespace BankaMVC.Areas.Admin.Models.Dtos.DovizDtos

{
    public class PutDovizDto
    {
        public int DovizID { get; set; }
        public string? DovizAdı { get; set; }
        public decimal? GüncelKurAlım { get; set; }
        public decimal? GüncelKurSatım { get; set; }
    }
}
