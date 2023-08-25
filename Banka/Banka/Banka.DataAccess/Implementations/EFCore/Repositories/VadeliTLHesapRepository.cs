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
    public class VadeliTLHesapRepository : BaseRepository<VadeliTLHesap, BankaContext>, IVadeliTLHesapRepository
    {
        public async Task<VadeliTLHesap> GetByIdAsync(int VadeliTLHesapID, params string[] includeList)
        {
            return await GetAsync(prd => prd.VadeliTLHesapID == VadeliTLHesapID);
                }

        public async Task<List<VadeliTLHesap>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriID == MusteriID);
        }

        public async Task<List<VadeliTLHesap>> GetByVadeBasTarihiAsync(DateTime VadeBasTarihi, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.VadeBasTarihi == VadeBasTarihi);
        }

        public async Task<List<VadeliTLHesap>> GetByVadeBitisTarihiAsync(DateTime VadeBitisTarihi, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.VadeBitisTarihi == VadeBitisTarihi);
        }

        public async Task<List<VadeliTLHesap>> GetByVadeliFaizoranAsync(int VadeliFaizoran, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.VadeliFaizoran == VadeliFaizoran);
        }

        public async Task<List<VadeliTLHesap>> GetByVadeSonuMiktarAsync(decimal VadeSonuMiktar, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.VadeSonuMiktar == VadeSonuMiktar);
        }

        public async Task<List<VadeliTLHesap>> GetByVarlıkAsync(decimal Varlık, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.Varlık == Varlık);
        }
    }
}
