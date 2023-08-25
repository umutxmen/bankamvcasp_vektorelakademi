using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.SanalKart
{
    public class SanalKartPostDto : IDto
    {
        public int MusteriID { get; set; }
        public int? BagliKrediKartID { get; set; }
        public string? KartNo { get; set; }
        public int? KartKullanımAy { get; set; }
        public int? KartKullanumYıl { get; set; }
        public int? KartCVCNo { get; set; }
        public string? KartSahipAd { get; set; }
        public string? KartSahipSoyad { get; set; }
        public string? KartTeknolojisi { get; set; }

    }
}
