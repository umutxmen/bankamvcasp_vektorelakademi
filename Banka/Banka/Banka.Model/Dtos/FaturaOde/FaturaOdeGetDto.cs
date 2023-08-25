using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.Faturaode
{
    public class FaturaOdeGetDto : IDto
    {
        public int FaturaYatırİslemID { get; set; }
        public int MusteriID { get; set; }
        public string faturano { get; set; }
        public string Gonderenİban { get; set; }
        public decimal odenecekMiktar { get; set; }
        public DateTime? OdemeTarih { get; set; }
        public string? Aciklama { get; set; }
    }
}
