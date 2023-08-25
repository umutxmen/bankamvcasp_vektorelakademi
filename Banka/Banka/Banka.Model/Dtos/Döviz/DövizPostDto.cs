using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.Doviz
{
    public class DovizPostDto :IDto
    {
        public string? DovizAdı { get; set; }
        public decimal? GüncelKurAlım { get; set; }
        public decimal? GüncelKurSatım { get; set; }
    }
}
