using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.EuroSwift
{
    public class EuroSwiftGetDto : IDto
    {
        public int EuroSwiftID { get; set; }
        public int MusteriID { get; set; }
        public string? GidenHesapIban { get; set; }
        public string? AlanHesapIban { get; set; }
        public DateTime? SwiftTarihi { get; set; }
        public int? Miktar { get; set; }
        public int? SwiftKodu { get; set; }
        public string? Aciklama { get; set; }
    }
}
