using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.BankaKartı
{
    public class BankaKartiGetDto :IDto
    {
        public int BankaKartID { get; set; }
        public int MusteriID { get; set; }
        public string? Baglıİban { get; set; }
        public string? KartNo { get; set; }
        public int? KartSonKullanımAy { get; set; }
        public int? KartSonKullanımYıl { get; set; }
        public string? KartSahipAd { get; set; }
        public string? KartSahipSoyad { get; set; }
        public string? KartTeknolojisi { get; set; }
    }
}
