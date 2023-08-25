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
    public class KrediKartıRepository : BaseRepository<KrediKartı, BankaContext>, IKrediKartıRepository
    {
        public async Task<List<KrediKartı>> GetByBaglıİbanAsync(string Baglıİban, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.Baglıİban == Baglıİban, includeList);
        }

        public async Task<KrediKartı> GetByIdAsync(int KrediKartıID, params string[] includeList)
        {
            return await GetAsync(prd => prd.KrediKartıID == KrediKartıID, includeList);
        }

        public async Task<List<KrediKartı>> GetByKartCVCNoAsync(int KartCVCNo, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartCVCNo == KartCVCNo, includeList);
        }

        public async Task<List<KrediKartı>> GetByKartkullanımAyAsync(int KartkullanımAy, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartkullanımAy == KartkullanımAy, includeList);
        }

        public async Task<List<KrediKartı>> GetByKartkullanımYılAsync(int KartkullanımYıl, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartkullanımYıl == KartkullanımYıl, includeList);
        }

        public async Task<List<KrediKartı>> GetByKartNoAsync(string KartNo, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartNo == KartNo, includeList);
        }

        public async Task<List<KrediKartı>> GetByKartSahipAdAsync(string KartSahipAd, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartSahipAd == KartSahipAd, includeList);
        }

        public async Task<List<KrediKartı>> GetByKartSahipSoyadAsync(string KartSahipSoyad, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartSahipSoyad == KartSahipSoyad, includeList);
        }

        public async Task<List<KrediKartı>> GetByKartTeknolojisiAsync(string KartTeknolojisi, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartTeknolojisi == KartTeknolojisi, includeList);
        }

        public async Task<List<KrediKartı>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriID == MusteriID, includeList);

        }

    }
}

