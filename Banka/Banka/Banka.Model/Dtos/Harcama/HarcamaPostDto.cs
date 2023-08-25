using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.Harcama
{
    public class HarcamaPostDto : IDto
    {
        public int MusteriID { get; set; }
        public int HarcananKartID { get; set; }

        public decimal? HarcananMiktar { get; set; }
        public int? TaksitMiktarı { get; set; }
        public DateTime? HarcamaTarihi { get; set; }
        public string? SatıcıKodu { get; set; }
    }
}
