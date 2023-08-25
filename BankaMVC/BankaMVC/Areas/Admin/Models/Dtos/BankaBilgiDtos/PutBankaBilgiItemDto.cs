namespace BankaMVC.Areas.Admin.Models.Dtos.BankaBilgiDtos
{
    public class PutBankaBilgiItemDto
    {
        public int BankaId { get; set; }
        public string? BankaSubeNo { get; set; }
        public string? BankaSehir { get; set; }
        public string? Bankaİlce { get; set; }
        public string? BankaAdres { get; set; }
        public string? BankaTel { get; set; }
    }
}
