using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Entities
{
    public class SterlinHesap :IEntity
    {
        public int? SterlinHesapId { get; set; }
        public int? MusteriID { get; set; }
        public decimal? SterlinVarlik { get; set; }
        public DateTime? HesapTarih { get; set; }
        public string? HesapIban { get; set; }
    }
}
