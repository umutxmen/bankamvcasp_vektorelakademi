using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.EFT
{
    public class EFTGetDto : IDto
    {
        public int EFTID { get; set; }
        public int MusteriID { get; set; }
        public int? BankaID { get; set; }
        public int? DigerBankaID { get; set; }
        public string? GidenIban { get; set; }
        public string? AlanIban { get; set; }
        public decimal? Miktar { get; set; }
        public DateTime? İslemTarihi { get; set; }
        public string? Aciklama { get; set; }

    }
}
