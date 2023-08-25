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
    public class SanalKartRepository : BaseRepository<SanalKart, BankaContext>, ISanalKartRepository
    {
        public async Task<List<SanalKart>> GetByBagliKrediKartIDAsync(int BagliKrediKartID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.BagliKrediKartID == BagliKrediKartID);

        }

        public async Task<SanalKart> GetByIdAsync(int SanalKartID, params string[] includeList)
        {
            return await GetAsync(prd => prd.SanalKartID == SanalKartID);
        }

        public async Task<List<SanalKart>> GetByKartCVCNoAsync(int KartCVCNo, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartCVCNo == KartCVCNo);
        }

        public async Task<List<SanalKart>> GetByKartKullanumYılAsync(int KartKullanumYıl, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartKullanumYıl == KartKullanumYıl);
        }

        public async Task<List<SanalKart>> GetByKartKullanımAyAsync(int KartKullanımAy, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartKullanımAy == KartKullanımAy);
        }

        public async Task<List<SanalKart>> GetByKartNoAsync(string KartNo, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartNo == KartNo);

        }

        public async Task<List<SanalKart>> GetByKartSahipAdAsync(string KartSahipAd, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartSahipAd == KartSahipAd);
        }

        public async Task<List<SanalKart>> GetByKartSahipSoyadAsync(string KartSahipSoyad, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartSahipSoyad == KartSahipSoyad);
        }

        public async Task<List<SanalKart>> GetByKartTeknolojisiAsync(string KartTeknolojisi, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartTeknolojisi == KartTeknolojisi);
        }

        public async Task<List<SanalKart>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriID == MusteriID);
        }
    }
}
