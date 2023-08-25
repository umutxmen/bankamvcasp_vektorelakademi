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

namespace WS.DataAccess.Implementations.EFCore.Repositories
{
    public class HarcamaRepository : BaseRepository<Harcama, BankaContext>, IHarcamaRepository
    {
        public async Task<List<Harcama>> GetByHarcamaTarihiAsync(DateTime HarcamaTarihi, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.HarcamaTarihi == HarcamaTarihi, includeList);
        }

        public async Task<List<Harcama>> GetByHarcananKartIDAsync(int HarcananKartID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.HarcananKartID == HarcananKartID, includeList);
        }

        public async Task<List<Harcama>> GetByHarcananMiktarAsync(decimal HarcananMiktar, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.HarcananMiktar == HarcananMiktar, includeList);
        }

        public async Task<Harcama> GetByIdAsync(int HarcamaID, params string[] includeList)
        {
            return await GetAsync(prd => prd.HarcamaID == HarcamaID, includeList);
        }

        public async Task<List<Harcama>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriID == MusteriID, includeList);
        }

        public async Task<List<Harcama>> GetBySatıcıKoduAsync(string SatıcıKodu, params string[] includeList)
        {           return await GetAllAsync(prd => prd.SatıcıKodu == SatıcıKodu, includeList);
        }

        public async Task<List<Harcama>> GetByTaksitMiktarıAsync(int TaksitMiktarı, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.TaksitMiktarı == TaksitMiktarı, includeList);

        }
    }
}
