namespace BankaMVC.Areas.Admin.Models.Dtos.DovizDtos

{
    public class NewDovizDto 
    {
        public string? DovizAdı { get; set; }
        public decimal? GüncelKurAlım { get; set; }
        public decimal? GüncelKurSatım { get; set; }
    }
}
