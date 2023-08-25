using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.VergiBorcuode
{
    public class VergiBorcuOdeGetDto : IDto
    {
        public int VergiodeİslemID { get; set; }
        public int MusteriID { get; set; }
        public string vergino { get; set; }
        public string MusteriTCNo { get; set; }
        public string GondericiIBAN { get; set; }
        public string GondericiAD { get; set; }
        public string GondericiSoyad { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? OdemeTarih { get; set; }
    }
}
