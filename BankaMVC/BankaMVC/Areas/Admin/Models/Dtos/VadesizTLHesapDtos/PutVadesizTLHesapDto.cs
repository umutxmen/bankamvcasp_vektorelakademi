﻿namespace BankaMVC.Areas.Admin.Models.Dtos.VadesizTLHesapDtos

{
    public class PutVadesizTLHesapDto 
    {
        public int VadesizTLHesapID { get; set; }
        public int? MusteriID { get; set; }
        public decimal? HesapTutar { get; set; }
        public DateTime? HesapAcilmaTarih { get; set; }
        public string? HesapIBAN { get; set; }
    }
}
