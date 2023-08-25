using Infrastructure.DataAccess.Implementations.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banka.DataAccess.Implementations.EFCore.Contexts;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.BankaKartı;
using Banka.Model.Entities;
using WS.DataAccess.Interfaces;
using System.Numerics;

namespace Banka.DataAccess.Implementations.EFCore.Repositories
{
    public class BankaKartiRepository : BaseRepository<BankaKarti, BankaContext>, IBankaKartiRepository
    {
        public async Task<List<BankaKarti>> GetByKartSahipAdAsync(string KartSahipAd, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartSahipAd == KartSahipAd, includeList);
        }

        public async Task<List<BankaKarti>> GetByBagliIbanAsync(string Baglıİban, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.Baglıİban == Baglıİban, includeList);
        }

        public async Task<BankaKarti> GetByIdAsync(int customerId, params string[] includeList)
        {
            return await GetAsync(prd => prd.BankaKartID == customerId, includeList);
        }

        public async Task<List<BankaKarti>> GetByKartNoAsync(string KartNo, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartNo == KartNo, includeList);
        }

        public async Task<List<BankaKarti>> GetByKartSahipSoyadAsync(string KartSahipSoyad, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartSahipSoyad == KartSahipSoyad, includeList);
        }

        public async Task<List<BankaKarti>> GetByKartSonKullanimAyAsync(int KartSonKullanımAy, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartSonKullanımAy == KartSonKullanımAy, includeList);
        }

        public async Task<List<BankaKarti>> GetByKartSonKullanimYilAsync(int KartSonKullanımYıl, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartSonKullanımYıl == KartSonKullanımYıl, includeList);
        }

        public async Task<List<BankaKarti>> GetByKartTeknolojisiAsync(string KartTeknolojisi, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KartTeknolojisi == KartTeknolojisi, includeList);
        }

        public async Task<BankaKarti> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            return await GetAsync(prd => prd.MusteriID == MusteriID, includeList);
        }
    }
}
