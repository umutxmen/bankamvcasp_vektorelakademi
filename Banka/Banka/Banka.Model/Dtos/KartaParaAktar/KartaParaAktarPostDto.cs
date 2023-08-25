using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.KartaParaAktar
{
    public class KartaParaAktarPostDto : IDto
    {
        public int MusteriID { get; set; }
        public int AktarılacakKartID { get; set; }
        public int VarlıkHesabı { get; set; }
        public decimal Miktar { get; set; }
        public DateTime? İslemTarihi { get; set; }

    }
}
