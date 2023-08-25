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
    public interface ISanalKartRepository : IBaseRepository<SanalKart>
    {
        Task<SanalKart> GetByIdAsync(int SanalKartID, params string[] includeList);
        Task<List<SanalKart>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);
        Task<List<SanalKart>> GetByBagliKrediKartIDAsync(int BagliKrediKartID, params string[] includeList);
        Task<List<SanalKart>> GetByKartNoAsync(string KartNo, params string[] includeList);
        Task<List<SanalKart>> GetByKartKullanımAyAsync(int KartKullanımAy, params string[] includeList);
        Task<List<SanalKart>> GetByKartKullanumYılAsync(int KartKullanumYıl, params string[] includeList);
        Task<List<SanalKart>> GetByKartCVCNoAsync(int KartCVCNo, params string[] includeList);
        Task<List<SanalKart>> GetByKartSahipAdAsync(string KartSahipAd, params string[] includeList);
        Task<List<SanalKart>> GetByKartSahipSoyadAsync(string KartSahipSoyad, params string[] includeList);
        Task<List<SanalKart>> GetByKartTeknolojisiAsync(string KartTeknolojisi, params string[] includeList);
    }
}
