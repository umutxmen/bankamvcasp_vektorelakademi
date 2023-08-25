﻿namespace BankaMVC.Areas.Admin.Models.Dtos.EuroSwiftDtos

{
    public class PutEuroSwiftDto
    {
        public int EuroSwiftID { get; set; }
        public int MusteriID { get; set; }
        public string? GidenHesapIban { get; set; }
        public string? AlanHesapIban { get; set; }
        public DateTime? SwiftTarihi { get; set; }
        public int? Miktar { get; set; }
        public int? SwiftKodu { get; set; }
        public string? Aciklama { get; set; }
    }
}
