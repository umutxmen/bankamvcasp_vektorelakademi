namespace BankaMVC.Areas.Admin.Models
{
    public class DovizItem
    {
        public int DovizID { get; set; }
        public string? DovizAdı { get; set; }
        public decimal? GüncelKurAlım { get; set; }
        public decimal? GüncelKurSatım { get; set; }
    }
}
