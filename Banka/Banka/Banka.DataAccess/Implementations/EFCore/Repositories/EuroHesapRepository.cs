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
    public class EuroHesapRepository : BaseRepository<EuroHesap, BankaContext>, IEuroHesapRepository
    {
        public async Task<List<EuroHesap>> GetByEuroVarlikAsync(decimal EuroVarlik)
        {
            return await GetAllAsync(prd => prd.EuroVarlik == EuroVarlik);
        }

        public async Task<List<EuroHesap>> GetByHesapIbanAsync(string HesapIban)
        {
            return await GetAllAsync(prd => prd.HesapIban == HesapIban);
        }

        public async Task<List<EuroHesap>> GetByHesapTarihAsync(DateTime HesapTarih)
        {
            return await GetAllAsync(prd => prd.HesapTarih == HesapTarih);
        }

        public async Task<EuroHesap> GetByIdAsync(int EuroHesapID)
        {
            return await GetAsync(prd => prd.EuroHesapID == EuroHesapID);
        }

        public async Task<EuroHesap> GetByMusteriIDAsync(int MusteriID)
        {
            return await GetAsync(prd => prd.MusteriID == MusteriID);

        }
    }
}
