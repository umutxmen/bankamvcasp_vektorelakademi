using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.VadesizTLHesap
{
    public class VadesizTLHesapPostDto : IDto
    {
        public int? MusteriID { get; set; }
        public decimal? HesapTutar { get; set; }
        public DateTime? HesapAcilmaTarih { get; set; }
        public string? HesapIBAN { get; set; }

    }
}
