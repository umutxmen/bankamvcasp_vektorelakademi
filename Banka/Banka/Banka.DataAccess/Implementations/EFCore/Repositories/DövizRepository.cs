using Infrastructure.DataAccess.Implementations.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banka.DataAccess.Implementations.EFCore.Contexts;
using Banka.DataAccess.Interfaces;
using Banka.Model.Entities;
using WS.DataAccess.Interfaces;

namespace Banka.DataAccess.Implementations.EFCore.Repositories
{
    public class DovizRepository : BaseRepository<Doviz, BankaContext>, IDovizRepository
    {
        public async Task<List<Doviz>> GetByDovizAdıAsync(string DovizAdı)
        {
            return await GetAllAsync(prd => prd.DovizAdı == DovizAdı);
        }

        public async Task<List<Doviz>> GetByGüncelKurAlımAsync(decimal GüncelKurAlım)
        {
            return await GetAllAsync(prd => prd.GüncelKurAlım == GüncelKurAlım);
        }

        public async Task<List<Doviz>> GetByGüncelKurSatımAsync(decimal GüncelKurSatım)
        {
            return await GetAllAsync(prd => prd.GüncelKurSatım == GüncelKurSatım);
        }

        public async Task<Doviz> GetByIdAsync(int DovizID)
        {
            return await GetAsync(prd => prd.DovizID == DovizID);
        }
    }
}
