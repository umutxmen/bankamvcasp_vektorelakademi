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
    public class KartlarRepository : BaseRepository<Kartlar, BankaContext>, IKartlarRepository
    {
        public async Task<List<Kartlar>> GetByBankaKartı2IDAsync(int BankaKartı2ID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.BankaKartı2ID == BankaKartı2ID, includeList);
        }

        public async Task<List<Kartlar>> GetByBankaKartı3IDAsync(int BankaKartı3ID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.BankaKartı3ID == BankaKartı3ID, includeList);
        }

        public async Task<List<Kartlar>> GetByBankaKartıIDAsync(int BankaKartıID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.BankaKartıID == BankaKartıID, includeList);
        }

        public async Task<List<Kartlar>> GetByKrediKartı2IDAsync(int KrediKartı2ID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KrediKartı2ID == KrediKartı2ID, includeList);
        }

        public async Task<List<Kartlar>> GetByKrediKartı3IDAsync(int KrediKartı3ID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KrediKartı3ID == KrediKartı3ID, includeList);
        }

        public async Task<List<Kartlar>> GetByKrediKartıIDAsync(int KrediKartıID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KrediKartıID == KrediKartıID, includeList);
        }

        public async Task<Kartlar> GetByIDAsync(int kartlarID, params string[] includeList)
        {
            return await GetAsync(prd => prd.KartlarID == kartlarID, includeList);
        }

        public async Task<List<Kartlar>> GetBySanalKart2IDAsync(int SanalKart2ID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.SanalKart2ID == SanalKart2ID, includeList);
        }

        public async Task<List<Kartlar>> GetBySanalKart3IDAsync(int SanalKart3ID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.SanalKart3ID == SanalKart3ID, includeList);
        }

        public async Task<List<Kartlar>> GetBySanalKartIDAsync(int SanalKartID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.SanalKartID == SanalKartID, includeList);
        }

        public async Task<Kartlar> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            return await GetAsync(prd => prd.MusteriID == MusteriID, includeList);
        }
    }
}
