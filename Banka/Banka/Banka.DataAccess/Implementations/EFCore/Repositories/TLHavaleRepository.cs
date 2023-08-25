using Infrastructure.DataAccess.Implementations.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banka.DataAccess.Implementations.EFCore.Contexts;
using Banka.DataAccess.Interfaces;
using Banka.Model.Entities;
using System.Numerics;

namespace Banka.DataAccess.Implementations.EFCore.Repositories
{
    public class TLHavaleRepository : BaseRepository<TLHavale, BankaContext>, ITLHavaleRepository
    {
        public async Task<List<TLHavale>> GetByAlanHesapIbanAsync(string AlanHesapIban, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.AlanHesapIban == AlanHesapIban);
        }

        public async Task<List<TLHavale>> GetByAciklamaAsync(string Aciklama, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.Aciklama == Aciklama);
        }

        public async Task<List<TLHavale>> GetByGidenHesapIbanAsync(string GidenHesapIban, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.GidenHesapIban == GidenHesapIban);
        }

        public async Task<List<TLHavale>> GetByHavaleIDAsync(int HavaleID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.HavaleID == HavaleID);
        }

        public async Task<TLHavale> GetByIdAsync(int HavaleID, params string[] includeList)
        {
            return await GetAsync(prd => prd.HavaleID == HavaleID);
        }

        public async Task<List<TLHavale>> GetByMiktarAsync(decimal Miktar, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.Miktar == Miktar);
        }

        public async Task<List<TLHavale>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriID == MusteriID);
        }

        public async Task<List<TLHavale>> GetByİslemTarihAsync(DateTime İslemTarih, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.İslemTarih == İslemTarih);
        }
    }
}
