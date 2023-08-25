using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Entities
{
    public class EuroHesap :IEntity
    {
        public int EuroHesapID { get; set; }
        public int MusteriID { get; set; }
        public decimal? EuroVarlik { get; set; }
        public DateTime? HesapTarih { get; set; }
        public string? HesapIban { get; set; }


    }
}
