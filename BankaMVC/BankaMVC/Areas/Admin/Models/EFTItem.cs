
namespace BankaMVC.Areas.Admin.Models
{
    public class EFTItem 
        {

        public int EFTID { get; set; }
        public int MusteriID { get; set; }
        public int? BankaID { get; set; }
        public int? DigerBankaID { get; set; }
        public string? GidenIban { get; set; }
        public string? AlanIban { get; set; }
        public decimal? Miktar { get; set; }
        public DateTime? İslemTarihi { get; set; }
        public string? Aciklama { get; set; }


    }
}
