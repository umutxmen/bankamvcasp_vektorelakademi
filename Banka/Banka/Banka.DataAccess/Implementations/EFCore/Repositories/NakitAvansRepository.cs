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
    public class NakitAvansRepository : BaseRepository<NakitAvans, BankaContext>, INakitAvansRepository
    {
        public async Task<List<NakitAvans>> GetByAktarılanİbanAsync(int Aktarılanİban, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.Aktarılanİban == Aktarılanİban);
        }

        public async Task<List<NakitAvans>> GetByAvansMiktarıAsync(decimal AvansMiktarı, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.AvansMiktari == AvansMiktarı);
        }

        public async Task<List<NakitAvans>> GetByFaizoranıAsync(decimal Faizoranı, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.Faizorani == Faizoranı);
        }

        public async Task<NakitAvans> GetByIdAsync(int NakitAvansID, params string[] includeList)
        {
            return await GetAsync(prd => prd.NakitAvansID == NakitAvansID);
        }

        public async Task<List<NakitAvans>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriID == MusteriID);
        }

      
        public async Task<List<NakitAvans>> GetBySonOdemeTarihiAsync(DateTime SonOdemeTarihi, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.SonOdemeTarihi == SonOdemeTarihi);
        }

        public async Task<List<NakitAvans>> GetByodenecekMiktarAsync(decimal odenecekMiktar, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.odenecekMiktar == odenecekMiktar);
        }
    }
}
