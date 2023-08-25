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
    public class GümüsHesapRepository : BaseRepository<GümüsHesap, BankaContext>, IGümüsHesapRepository
    {
        public async Task<List<GümüsHesap>> GetByGümüsVarlikGramAsync(decimal GümüsVarlikGram, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.GümüsVarlikGram == GümüsVarlikGram, includeList);
        }

        public async Task<List<GümüsHesap>> GetByHesapTarihAsync(DateTime HesapTarih, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.HesapTarih == HesapTarih, includeList);
        }

        public async Task<GümüsHesap> GetByIdAsync(int GümüsHesapID, params string[] includeList)
        {
            return await GetAsync(prd => prd.GümüsHesapID == GümüsHesapID, includeList);
        }

        public async Task<List<GümüsHesap>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriID == MusteriID, includeList);
        }
    }
}
