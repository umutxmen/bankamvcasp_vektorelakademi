using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.KurKorumalıHesap
{
    public class KurKorumalıHesapPostDto : IDto
    {
        public int MusteriID { get; set; }
        public decimal? VarlikTL { get; set; }
        public int? DovizID { get; set; }
        public DateTime? HesapAcimTarihi { get; set; }
        public decimal? HesapAcimKuru { get; set; }
        public DateTime? HesapKapanmaTarihi { get; set; }
        public decimal? HesapKapanmaKuru { get; set; }
        public int? HesapFaizoran { get; set; }

    }
}
