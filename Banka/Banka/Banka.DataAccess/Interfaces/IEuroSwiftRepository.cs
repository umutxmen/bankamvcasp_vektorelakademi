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
    public interface IEuroSwiftRepository : IBaseRepository<EuroSwift>
    {
        Task<EuroSwift> GetByIdAsync(int EuroSwiftID);
        Task<EuroSwift> GetByMusteriIDAsync(int MusteriID);
        Task<List<EuroSwift>> GetByGidenHesapIbanAsync(string GidenHesapIban);
        Task<List<EuroSwift>> GetByAlanHesapIbanAsync(string AlanHesapIban);
        Task<List<EuroSwift>> GetBySwiftTarihiAsync(DateTime SwiftTarihi);
        Task<List<EuroSwift>> GetByMiktarAsync(int Miktar);
        Task<List<EuroSwift>> GetBySwiftKoduAsync(int SwiftKodu);
        Task<List<EuroSwift>> GetByAciklamaAsync(string Aciklama);
    }
}
