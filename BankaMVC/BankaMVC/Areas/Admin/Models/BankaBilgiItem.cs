namespace BankaMVC.Areas.Admin.Models
{
    public class BankaBilgiItem
    {
        public int BankaId { get; set; }
        public string? BankaSubeNo { get; set; }
        public string? BankaSehir { get; set; }
        public string? Bankaİlce { get; set; }
        public string? BankaAdres { get; set; }
        public string? BankaTel { get; set; }
        public List<BankaBilgiItem>? BankaBilgi { get; set; }

    }
}
