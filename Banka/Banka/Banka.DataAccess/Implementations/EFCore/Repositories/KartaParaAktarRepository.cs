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
    public class KartaParaAktarRepository : BaseRepository<KartaParaAktar, BankaContext>, IKartaParaAktarRepository
    {
        public async Task<List<KartaParaAktar>> GetByAktarılacakKartIDAsync(int AktarılacakKartID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.AktarılacakKartID == AktarılacakKartID, includeList);
        }

        public async Task<KartaParaAktar> GetByIdAsync(int KartaParaİslemID, params string[] includeList)
        {
            return await GetAsync(prd => prd.KartaParaİslemID == KartaParaİslemID, includeList);

        }

        public async Task<List<KartaParaAktar>> GetByMiktarAsync(decimal Miktar, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.Miktar == Miktar, includeList);
        }

        public async Task<List<KartaParaAktar>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriID == MusteriID, includeList);
        }

        public async Task<List<KartaParaAktar>> GetByVarlıkHesabıAsync(int VarlıkHesabı, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.VarlıkHesabı == VarlıkHesabı, includeList);
        }

        public async Task<List<KartaParaAktar>> GetByİslemTarihiAsync(DateTime İslemTarihi, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.İslemTarihi == İslemTarihi, includeList);
        }
    }
}
