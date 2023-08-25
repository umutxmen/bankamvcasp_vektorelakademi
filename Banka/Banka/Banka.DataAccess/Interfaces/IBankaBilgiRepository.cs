using Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banka.Model.Entities;

namespace Banka.DataAccess.Interfaces
{
    public interface IBankaBilgiRepository : IBaseRepository<BankaBilgi>
    {
        Task<BankaBilgi> GetByIdAsync(int BankaId, params string[] includeList);

        Task<List<BankaBilgi>> GetByBankaSubeNoAsync(string BankaSubeNo, params string[] includeList);
        Task<List<BankaBilgi>> GetByBankaSehirAsync(string BankaSehir, string[] includeList);
        Task<List<BankaBilgi>> GetByBankaİlceAsync(string Bankaİlce, string[] includeList);
        Task<List<BankaBilgi>> GetByBankaAdresAsync(string BankaAdres, string[] includeList);
        Task<List<BankaBilgi>> GetByBankaTelAsync(string BankaTel, string[] includeList);
        Task<BankaBilgi> GetByNameAsync(string name, params string[] includeList);

        Task GetByNameAsync(string name);
    }
}
