using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.KrediKartı
{
    public class KrediKartıGetDto : IDto
    {
        public int KrediKartıID { get; set; }
        public int MusteriID { get; set; }
        public string? Baglıİban { get; set; }
        public string? KartNo { get; set; }
        public int? KartkullanımAy { get; set; }
        public int? KartkullanımYıl { get; set; }
        public int? KartCVCNo { get; set; }
        public string? KartSahipAd { get; set; }
        public string? KartSahipSoyad { get; set; }
        public string? KartTeknolojisi { get; set; }
    }
}
