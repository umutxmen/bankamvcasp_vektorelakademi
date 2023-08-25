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
    public interface INakitAvansRepository : IBaseRepository<NakitAvans>
    {
        Task<NakitAvans> GetByIdAsync(int NakitAvansID, params string[] includeList);
        Task<List<NakitAvans>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);
        Task<List<NakitAvans>> GetByAktarılanİbanAsync(int Aktarılanİban, params string[] includeList);
        Task<List<NakitAvans>> GetBySonOdemeTarihiAsync(DateTime SonOdemeTarihi, params string[] includeList);
        Task<List<NakitAvans>> GetByAvansMiktarıAsync(decimal AvansMiktarı, params string[] includeList);
        Task<List<NakitAvans>> GetByFaizoranıAsync(decimal Faizoranı, params string[] includeList);
        Task<List<NakitAvans>> GetByodenecekMiktarAsync(decimal odenecekMiktar, params string[] includeList);
    }
}
