using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Dtos.BankaBilgi
{
    public class BankaBilgiPutDto :IDto
    {
        public int BankaId { get; set; }
        public string? BankaSubeNo { get; set; }
        public string? BankaSehir { get; set; }
        public string? Bankaİlce { get; set; }
        public string? BankaAdres { get; set; }
        public string? BankaTel { get; set; }
    }
}
