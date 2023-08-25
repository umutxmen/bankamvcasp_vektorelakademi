﻿using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.GümüsHesap
{
    public class GümüsHesapPostDto : IDto
    {
        public int MusteriID { get; set; }
        public decimal? GümüsVarlikGram { get; set; }
        public DateTime? HesapTarih { get; set; }

    }
}
