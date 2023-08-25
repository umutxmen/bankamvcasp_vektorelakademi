using Infrastructure.DataAccess.Implementations.EFCore;
using Banka.DataAccess.Implementations.EFCore.Contexts;
using Banka.DataAccess.Interfaces;
using Banka.Model.Entities;
using System.Numerics;

namespace Banka.DataAccess.EF.Repositories
{
    public class DolarHesapRepository : BaseRepository<DolarHesap, BankaContext>, IDolarHesapRepository
    {
        public async Task<List<DolarHesap>> GetByDolarVarlikAsync(decimal DolarVarlik)
        {
            return await GetAllAsync(prd => prd.DolarVarlik == DolarVarlik);
        }

        public async Task<List<DolarHesap>> GetByHesapIbanAsync(string HesapIban)
        {
            return await GetAllAsync(prd => prd.HesapIban == HesapIban);

        }

        public async Task<List<DolarHesap>> GetByHesapTarihiAsync(DateTime HesapTarihi)
        {
            return await GetAllAsync(prd => prd.HesapTarihi == HesapTarihi);
        }

        public async Task<DolarHesap> GetByIdAsync(int id)
        {
            return await GetAsync(prd => prd.DolarHesapID == id);
        }

        public async Task<DolarHesap> GetByMusteriIDAsync(int MusteriID)
        {
            return await GetAsync(prd => prd.MusteriID == MusteriID);
        }
    }
}
