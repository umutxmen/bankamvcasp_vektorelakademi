using Banka.Model.Entities;
using Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banka.Model.Entities;
using System.Numerics;

namespace WS.DataAccess.Interfaces
{
    public interface IBankaKartiRepository : IBaseRepository<BankaKarti>
    {
        Task<BankaKarti> GetByIdAsync(int customerId, params string[] includeList);
        Task<BankaKarti> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<List<BankaKarti>> GetByBagliIbanAsync(string Bagliİban, params string[] includeList);
        Task<List<BankaKarti>> GetByKartNoAsync(string KartNo, params string[] includeList);
        Task<List<BankaKarti>> GetByKartSonKullanimAyAsync(int KartSonKullanımAy, params string[] includeList);
        Task<List<BankaKarti>> GetByKartSonKullanimYilAsync(int KartSonKullanımYıl, params string[] includeList);
        Task<List<BankaKarti>> GetByKartSahipAdAsync(string KartSahipAd, params string[] includeList);
        Task<List<BankaKarti>> GetByKartSahipSoyadAsync(string KartSahipSoyad, params string[] includeList);
        Task<List<BankaKarti>> GetByKartTeknolojisiAsync(string KartTeknolojisi, params string[] includeList);
    }
}
