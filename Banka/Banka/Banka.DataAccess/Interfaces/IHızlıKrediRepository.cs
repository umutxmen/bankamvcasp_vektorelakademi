using Banka.Model.Entities;
using Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banka.Model.Entities;
using System.Numerics;

namespace Banka.DataAccess.Interfaces
{
    public interface IHizliKrediRepository : IBaseRepository<HizliKredi>
    {
        Task<HizliKredi> GetByIdAsync(int HizliKrediID, params string[] includeList);
        Task<List<HizliKredi>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);
        Task<List<HizliKredi>> GetByAktarılacakİbanAsync(string Aktarılacakİban, params string[] includeList);
        Task<List<HizliKredi>> GetByKrediMiktarAsync(decimal KrediMiktar, params string[] includeList);
        Task<List<HizliKredi>> GetByKrediFaizAsync(decimal KrediFaiz, params string[] includeList);
        Task<List<HizliKredi>> GetByKrediÇekimTarihiAsync(DateTime KrediÇekimTarihi, params string[] includeList);
        Task<List<HizliKredi>> GetByKrediTaksitSayısıAsync(int KrediTaksitSayısı, params string[] includeList);
        Task<List<HizliKredi>> GetByKrediSonOdemeTarihAsync(DateTime KrediSonOdemeTarih, params string[] includeList);
        Task<List<HizliKredi>> GetByKrediSonodemeTutarAsync(decimal KrediSonodemeTutar, params string[] includeList);
    }
}
