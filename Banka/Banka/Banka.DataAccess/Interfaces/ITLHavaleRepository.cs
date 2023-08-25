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
    public interface ITLHavaleRepository : IBaseRepository<TLHavale>
    {
        Task<TLHavale> GetByIdAsync(int HavaleID, params string[] includeList);

        Task<List<TLHavale>> GetByHavaleIDAsync(int HavaleID, params string[] includeList);
        Task<List<TLHavale>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);
        Task<List<TLHavale>> GetByGidenHesapIbanAsync(string GidenHesapIban, params string[] includeList);
        Task<List<TLHavale>> GetByAlanHesapIbanAsync(string AlanHesapIban, params string[] includeList);
        Task<List<TLHavale>> GetByİslemTarihAsync(DateTime İslemTarih, params string[] includeList);
        Task<List<TLHavale>> GetByMiktarAsync(decimal Miktar, params string[] includeList);
        Task<List<TLHavale>> GetByAciklamaAsync(string Aciklama, params string[] includeList);
    }
}
