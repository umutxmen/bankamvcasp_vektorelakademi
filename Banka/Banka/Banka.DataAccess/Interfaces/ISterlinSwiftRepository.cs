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
    public interface ISterlinSwiftRepository : IBaseRepository<SterlinSwift>
    {
        Task<SterlinSwift> GetByIdAsync(int SterlinSwiftID, params string[] includeList);
        Task<List<SterlinSwift>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);
        Task<List<SterlinSwift>> GetByGidenHesapIbanAsync(string GidenHesapIban, params string[] includeList);
        Task<List<SterlinSwift>> GetByAlanHesapIbanAsync(string AlanHesapIban, params string[] includeList);
        Task<List<SterlinSwift>> GetBySwiftTarihiAsync(DateTime SwiftTarihi, params string[] includeList);
        Task<List<SterlinSwift>> GetByMiktarAsync(decimal Miktar, params string[] includeList);
        Task<List<SterlinSwift>> GetBySwiftKoduAsync(int SwiftKodu, params string[] includeList);
        Task<List<SterlinSwift>> GetByAciklamaAsync(string Aciklama, params string[] includeList);
    }
}
