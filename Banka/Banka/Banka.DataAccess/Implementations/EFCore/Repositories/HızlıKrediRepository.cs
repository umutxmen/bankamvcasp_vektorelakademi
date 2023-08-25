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
    public class HizliKrediRepository : BaseRepository<HizliKredi, BankaContext>, IHizliKrediRepository
    {
        public async Task<List<HizliKredi>> GetByAktarılacakİbanAsync(string Aktarılacakİban, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.Aktarılacakİban == Aktarılacakİban, includeList);
        }

        public async Task<HizliKredi> GetByIdAsync(int HizliKrediID, params string[] includeList)
        {
            return await GetAsync(prd => prd.HizliKrediID == HizliKrediID, includeList);
        }

        public async Task<List<HizliKredi>> GetByKrediFaizAsync(decimal KrediFaiz, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KrediFaiz == KrediFaiz, includeList);
        }

        public async Task<List<HizliKredi>> GetByKrediMiktarAsync(decimal KrediMiktar, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KrediMiktar == KrediMiktar, includeList);
        }

        public async Task<List<HizliKredi>> GetByKrediSonOdemeTarihAsync(DateTime KrediSonOdemeTarih, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KrediSonOdemeTarih == KrediSonOdemeTarih, includeList);
        }

        public async Task<List<HizliKredi>> GetByKrediSonodemeTutarAsync(decimal KrediSonodemeTutar, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KrediSonodemeTutar == KrediSonodemeTutar, includeList);
        }

        public async Task<List<HizliKredi>> GetByKrediTaksitSayısıAsync(int KrediTaksitSayısı, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KrediTaksitSayısı == KrediTaksitSayısı, includeList);
        }

        public async Task<List<HizliKredi>> GetByKrediÇekimTarihiAsync(DateTime KrediÇekimTarihi, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.KrediÇekimTarihi == KrediÇekimTarihi, includeList);
        }

        public async Task<List<HizliKredi>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriID == MusteriID, includeList);
        }
    }
}
