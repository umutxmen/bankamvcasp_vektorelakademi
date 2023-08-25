using Banka.Model.Entities;
using Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Banka.Model.Entities;

namespace Banka.DataAccess.Interfaces
{
    public interface IKartlarRepository : IBaseRepository<Kartlar>
    {
        Task<Kartlar> GetByIDAsync(int id, params string[] includeList);

        Task<Kartlar> GetByMusteriIDAsync(int MusteriID, params string[] includeList);
        Task<List<Kartlar>> GetByKrediKartıIDAsync(int KrediKartıID, params string[] includeList);
        Task<List<Kartlar>> GetByKrediKartı2IDAsync(int KrediKartı2ID, params string[] includeList);
        Task<List<Kartlar>> GetByKrediKartı3IDAsync(int KrediKartı3ID, params string[] includeList);
        Task<List<Kartlar>> GetByBankaKartıIDAsync(int BankaKartıID, params string[] includeList);
        Task<List<Kartlar>> GetByBankaKartı2IDAsync(int BankaKartı2ID, params string[] includeList);
        Task<List<Kartlar>> GetByBankaKartı3IDAsync(int BankaKartı3ID, params string[] includeList);
        Task<List<Kartlar>> GetBySanalKartIDAsync(int SanalKartID, params string[] includeList);
        Task<List<Kartlar>> GetBySanalKart2IDAsync(int SanalKart2ID, params string[] includeList);
        Task<List<Kartlar>> GetBySanalKart3IDAsync(int SanalKart3ID, params string[] includeList);
     
    }
}
