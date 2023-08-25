﻿using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Entities
{
    internal class AltinHesap : IEntity
    {
        public int AltinHesapId { get; set; }
        public int MusteriID { get; set; }
        public decimal? AltinVarlikGram { get; set; }
        public DateTime? HesapTarih { get; set; }
       
    }
}