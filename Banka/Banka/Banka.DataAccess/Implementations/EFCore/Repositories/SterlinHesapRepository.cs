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
    public class SterlinHesapRepository : BaseRepository<SterlinHesap, BankaContext>, ISterlinHesapRepository
    {
        public async Task<List<SterlinHesap>> GetByHesapIbanAsync(string HesapIban, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.HesapIban == HesapIban);
            }

        public async Task<List<SterlinHesap>> GetByHesapTarihAsync(DateTime HesapTarih, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.HesapTarih == HesapTarih);
        }

        public async Task<SterlinHesap> GetByIdAsync(int SterlinHesapId, params string[] includeList)
        {
            return await GetAsync(prd => prd.SterlinHesapId == SterlinHesapId);
        }

        public async Task<List<SterlinHesap>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriID == MusteriID);
        }

        public async Task<List<SterlinHesap>> GetBySterlinVarlikAsync(decimal SterlinVarlik, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.SterlinVarlik == SterlinVarlik);
        }
    }
}
