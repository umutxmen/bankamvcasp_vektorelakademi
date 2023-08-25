﻿using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Entities
{
    public class TLHavale :IEntity
    {
        public int HavaleID { get; set; }
        public int MusteriID { get; set; }
        public string? GidenHesapIban { get; set; }
        public string? AlanHesapIban { get; set; }
        public DateTime? İslemTarih { get; set; }
        public decimal? Miktar { get; set; }
        public string? Aciklama { get; set; }
    }
}
