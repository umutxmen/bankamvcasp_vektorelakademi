using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.DolarHesap
{
    public class DolarHesapGetDto :IDto    {
        public int DolarHesapID { get; set; }
        public int MusteriID { get; set; }
        public decimal? DolarVarlik { get; set; }
        public DateTime? HesapTarihi { get; set; }
        public string? HesapIban { get; set; }

    }
}
