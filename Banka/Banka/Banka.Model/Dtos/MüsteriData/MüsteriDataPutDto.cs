using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.MusteriData
{
    public class MusteriDataPutDto : IDto
    {
        public int MusteriDataID { get; set; }
      //  public int? MusteriVarlikID { get; set; }

        public string MusteriAD { get; set; }
        public string MusteriSoYAD { get; set; }
        public string? MusteriTC { get; set; }
        public string? MusteriTEL { get; set; }
        public string? MusteriMeslek { get; set; }
        public string? MusteriAdres { get; set; }
        public string? MusteriEmail { get; set; }
        public string? MusteriAnneliksoyad { get; set; }
        public string? PicturePath { get; set; }


    }
}
