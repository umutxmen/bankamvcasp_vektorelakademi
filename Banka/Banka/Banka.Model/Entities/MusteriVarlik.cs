using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Entities
{
    public class MusteriVarlik :IEntity
    {
        public int MusteriVarlikID { get; set; }
        public int? MusteriDataID { get; set; }
        public string? MusteriAD { get; set; }

        public int? BankaId { get; set; }
        public bool? HesapTLVadesiz { get; set; }
        public bool? HesapTLVadeli { get; set; }
        public bool? HesapDolarVadesiz { get; set; }
        public bool? HesapEuroVadesiz { get; set; }
        public bool? HesapSterlinVadesiz { get; set; }
        public bool? HesapAltinVadesiz { get; set; }
        public bool? HesapGumusVadesiz { get; set; }
        public int? VadesizTLHesapID { get; set; }
        public int? VadeliTLHesapID { get; set; }
        public int? DolarHesapID { get; set; }
        public int? EuroHesapID { get; set; }
        public int? SterlinHesapID { get; set; }
        public int? KurKorumalıTLHesapID { get; set; }
        public int? AltinHesapID { get; set; }
        public int? GumusHesapID { get; set; }
        public int? BankaKartlarID { get; set; }
        public int? KrediKartlarID { get; set; }
        public int? IbanlarID { get; set; }

        //Navigasyon
     public MusteriData? MusteriData { get; set; }

    }
}
