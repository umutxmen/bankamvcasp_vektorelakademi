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
    public interface IDolarSwiftRepository : IBaseRepository<DolarSwift>
    {

        Task<DolarSwift> GetByIdAsync(int id);
        Task<DolarSwift> GetByMusteriIDAsync(int MusteriID);
        Task<List<DolarSwift>> GetByGidenHesapIbanAsync(string GidenHesapIban);
        Task<List<DolarSwift>> GetByAlanHesapIbanAsync(string AlanHesapIban);
        Task<List<DolarSwift>> GetBySwiftTarihiAsync(DateTime SwiftTarihi);
        Task<List<DolarSwift>> GetByMiktarAsync(decimal Miktar);
        Task<List<DolarSwift>> GetBySwiftKoduAsync(int SwiftKodu);
        Task<List<DolarSwift>> GetByAciklamaAsync(string Aciklama);
    }
}
