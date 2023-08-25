using Infrastructure.DataAccess.Implementations.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banka.DataAccess.Implementations.EFCore.Contexts;
using Banka.DataAccess.Interfaces;
using Banka.Model.Entities;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace WS.DataAccess.Implementations.EFCore.Repositories
{
    public class BankaBilgiRepository : BaseRepository<BankaBilgi, BankaContext>, IBankaBilgiRepository
    {
        public async Task<List<BankaBilgi>> GetByBankaAdresAsync(string bankaAdres, string[] includeList)
        {
            return await GetAllAsync(k => k.BankaAdres.ToLower() == bankaAdres.ToLower(), includeList);
        }

        public async Task<List<BankaBilgi>> GetByBankaSehirAsync(string BankaSehir, string[] includeList)
        {
            return await GetAllAsync(k => k.BankaSehir.ToLower() == BankaSehir.ToLower(), includeList);
        }

        public async Task<List<BankaBilgi>> GetByBankaSubeNoAsync(string BankaSubeNo, params string[] includeList)
        {
            return await GetAllAsync(k => k.BankaSubeNo.ToLower() == BankaSubeNo.ToLower(), includeList);
        }

        public async Task<List<BankaBilgi>> GetByBankaTelAsync(string BankaTel, string[] includeList)
        {
            return await GetAllAsync(k => k.BankaTel.ToLower() == BankaTel.ToLower(), includeList);
        }

        public async Task<List<BankaBilgi>> GetByBankaİlceAsync(string Bankaİlce, string[] includeList)
        {
            return await GetAllAsync(k => k.Bankaİlce.ToLower() == Bankaİlce.ToLower(), includeList);
        }

        public async Task<BankaBilgi> GetByIdAsync(int BankaId, params string[] includeList)
        {
            return await GetAsync(prd => prd.BankaId == BankaId, includeList);
        }

      

        public async Task GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<BankaBilgi> GetByNameAsync(string name, params string[] includeList)
        {
            throw new NotImplementedException();

        }
    }
}
