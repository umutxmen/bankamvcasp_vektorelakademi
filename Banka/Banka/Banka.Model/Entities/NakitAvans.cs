using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Entities
{
    public class NakitAvans :IEntity
    {
        public int NakitAvansID { get; set; }
        public int MusteriID { get; set; }
        public int? Aktarılanİban { get; set; }
        public DateTime? SonOdemeTarihi { get; set; }
        public decimal? AvansMiktari { get; set; }
        public decimal? Faizorani { get; set; }
        public decimal? odenecekMiktar { get; set; }
      
    }
}
