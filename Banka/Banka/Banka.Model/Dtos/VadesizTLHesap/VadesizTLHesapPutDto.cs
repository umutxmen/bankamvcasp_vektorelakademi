using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.VadesizTLHesap
{
    public class VadesizTLHesapPutDto : IDto
    {
        public int VadesizTLHesapID { get; set; }
        public int? MusteriID { get; set; }
        public decimal? HesapTutar { get; set; }
        public DateTime? HesapAcilmaTarih { get; set; }
        public string? HesapIBAN { get; set; }
    }
}
