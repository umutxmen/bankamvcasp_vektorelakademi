﻿using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.VadeliTLHesap
{
    public class VadeliTLHesapGetDto : IDto
    {
        public int VadeliTLHesapID { get; set; }
        public int MusteriID { get; set; }
        public decimal Varlık { get; set; }
        public DateTime? VadeBasTarihi { get; set; }
        public DateTime? VadeBitisTarihi { get; set; }
        public int? VadeliFaizoran { get; set; }
        public decimal? VadeSonuMiktar { get; set; }

    }
}
