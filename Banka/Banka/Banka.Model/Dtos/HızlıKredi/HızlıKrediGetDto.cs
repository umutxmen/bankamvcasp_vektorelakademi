using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.HizliKredi
{
    public class HizliKrediGetDto : IDto
    {
        public int HizliKrediID { get; set; }
        public int MusteriID { get; set; }
        public string? Aktarılacakİban { get; set; }

        public decimal? KrediMiktar { get; set; }
        public decimal? KrediFaiz { get; set; }
        public DateTime? KrediÇekimTarihi { get; set; }
        public int? KrediTaksitSayısı { get; set; }
        public DateTime? KrediSonOdemeTarih { get; set; }
        public decimal? KrediSonodemeTutar { get; set; }
    }
}
