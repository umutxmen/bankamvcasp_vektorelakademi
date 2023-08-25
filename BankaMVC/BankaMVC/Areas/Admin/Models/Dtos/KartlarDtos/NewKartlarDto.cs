namespace BankaMVC.Areas.Admin.Models.Dtos.KartlarDtos

{
    public class NewKartlarDto
    {
        public int MusteriID { get; set; }
        public int? KrediKartıID { get; set; }
        public int? KrediKartı2ID { get; set; }
        public int? KrediKartı3ID { get; set; }
        public int? BankaKartıID { get; set; }
        public int? BankaKartı2ID { get; set; }
        public int? BankaKartı3ID { get; set; }
        public int? SanalKartID { get; set; }
        public int? SanalKart2ID { get; set; }
        public int? SanalKart3ID { get; set; }
    }
}
