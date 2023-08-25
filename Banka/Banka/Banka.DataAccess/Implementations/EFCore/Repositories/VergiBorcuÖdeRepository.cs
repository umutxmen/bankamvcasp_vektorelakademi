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
    public class VergiBorcuOdeRepository : BaseRepository<VergiBorcuOde, BankaContext>, IVergiBorcuOdeRepository
    {
        public async Task<List<VergiBorcuOde>> GetByAciklamaAsync(string Aciklama, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.Aciklama == Aciklama);
        }

        public async Task<List<VergiBorcuOde>> GetByGondericiADAsync(string GondericiAD, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.GondericiAD == GondericiAD);
        }

        public async Task<List<VergiBorcuOde>> GetByGondericiIBANAsync(string GondericiIBAN, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.GondericiIBAN == GondericiIBAN);
        }

        public async Task<List<VergiBorcuOde>> GetByGondericiSoyadAsync(string GondericiSoyad, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.GondericiSoyad == GondericiSoyad);
        }

        public async Task<VergiBorcuOde> GetByIdAsync(int VergiOdeİslemID, params string[] includeList)
        {
            return await GetAsync(prd => prd.VergiodeİslemID == VergiOdeİslemID);
        }

        public async Task<List<VergiBorcuOde>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriID == MusteriID);
        }

        public async Task<List<VergiBorcuOde>> GetByMusteriTCNoAsync(string MusteriTCNo, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriTCNo == MusteriTCNo);
        }

        public async Task<List<VergiBorcuOde>> GetByverginoAsync(string vergino, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.vergino == vergino);
        }

        public async Task<List<VergiBorcuOde>> GetByOdemeTarihAsync(DateTime OdemeTarih, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.OdemeTarih == OdemeTarih);
        }
    }
}
