using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Model.Entities
{
    public class BankaBilgi : IEntity
    {
        public int BankaId { get; set; }
        public string? BankaSubeNo { get; set; }
        public string? BankaSehir { get; set; }
        public string? Bankaİlce { get; set; }
        public string? BankaAdres { get; set; }
        public string? BankaTel { get; set; }


    }
}
