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
    public class VadesizTLHesapRepository : BaseRepository<VadesizTLHesap, BankaContext>, IVadesizTLHesapRepository
    {
        public async Task<List<VadesizTLHesap>> GetByHesapAcilmaTarihAsync(DateTime HesapAcilmaTarih, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.HesapAcilmaTarih == HesapAcilmaTarih);
        }

        public async Task<List<VadesizTLHesap>> GetByHesapIBANAsync(string HesapIBAN, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.HesapIBAN == HesapIBAN);
        }

        public async Task<List<VadesizTLHesap>> GetByHesapTutarAsync(decimal HesapTutar, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.HesapTutar == HesapTutar);
        }

        public async Task<VadesizTLHesap> GetByIdAsync(int VadesizTLHesapID, params string[] includeList)
        {
            return await GetAsync(prd => prd.VadesizTLHesapID == VadesizTLHesapID);
        }

        public async Task<List<VadesizTLHesap>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriID == MusteriID);
        }
    }
}
