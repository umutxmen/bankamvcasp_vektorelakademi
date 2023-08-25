using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.AltinHesap
{
    public class AltinHesapPostDto : IDto
    {
       
        public decimal? AltinVarlikGram { get; set; }
        public DateTime? HesapTarih { get; set; }
    }
}
