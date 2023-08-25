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
    public interface IHarcamaRepository : IBaseRepository<Harcama>
    {
        Task<Harcama> GetByIdAsync(int HarcamaID, params string[] includeList);
        Task<List<Harcama>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);
        Task<List<Harcama>> GetByHarcananKartIDAsync(int HarcananKartID, params string[] includeList);
        Task<List<Harcama>> GetByHarcananMiktarAsync(decimal HarcananMiktar, params string[] includeList);
        Task<List<Harcama>> GetByTaksitMiktarıAsync(int TaksitMiktarı, params string[] includeList);
        Task<List<Harcama>> GetByHarcamaTarihiAsync(DateTime HarcamaTarihi, params string[] includeList);
        Task<List<Harcama>> GetBySatıcıKoduAsync(string SatıcıKodu, params string[] includeList);
    }
}
