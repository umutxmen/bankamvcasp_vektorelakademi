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
    public interface IKrediKartıRepository : IBaseRepository<KrediKartı>
    {
        Task<KrediKartı> GetByIdAsync(int KrediKartıID, params string[] includeList);
        Task<List<KrediKartı>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);
        Task<List<KrediKartı>> GetByBaglıİbanAsync(string Baglıİban, params string[] includeList);
        Task<List<KrediKartı>> GetByKartNoAsync(string KartNo, params string[] includeList);
        Task<List<KrediKartı>> GetByKartkullanımAyAsync(int KartkullanımAy, params string[] includeList);
        Task<List<KrediKartı>> GetByKartkullanımYılAsync(int KartkullanımYıl, params string[] includeList);
        Task<List<KrediKartı>> GetByKartCVCNoAsync(int KartCVCNo, params string[] includeList);
        Task<List<KrediKartı>> GetByKartSahipAdAsync(string KartSahipAd, params string[] includeList);
        Task<List<KrediKartı>> GetByKartSahipSoyadAsync(string KartSahipSoyad, params string[] includeList);
        Task<List<KrediKartı>> GetByKartTeknolojisiAsync(string KartTeknolojisi, params string[] includeList);
    }
}
