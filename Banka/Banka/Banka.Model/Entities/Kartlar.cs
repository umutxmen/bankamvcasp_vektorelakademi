using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Entities
{
    public class Kartlar :IEntity
    {
        public int KartlarID { get; set; }
        public int MusteriID { get; set; }
        public int? KrediKartıID { get; set; }
        public int? KrediKartı2ID { get; set; }
        public int? KrediKartı3ID { get; set; }
        public int? BankaKartıID { get; set; }
        public int? BankaKartı2ID { get; set; }
        public int? BankaKartı3ID { get; set; }
        public int? SanalKartID { get; set; }
        public int? SanalKart2ID { get; set; }
        public int? SanalKart3ID { get; set; }
    }
}
