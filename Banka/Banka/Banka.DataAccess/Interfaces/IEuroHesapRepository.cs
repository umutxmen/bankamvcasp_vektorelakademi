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
    public interface IEuroHesapRepository : IBaseRepository<EuroHesap>
    {
        Task<EuroHesap> GetByIdAsync(int EuroHesapID);
        Task<EuroHesap> GetByMusteriIDAsync(int MusteriID);
        Task<List<EuroHesap>> GetByEuroVarlikAsync(decimal EuroVarlik);
        Task<List<EuroHesap>> GetByHesapTarihAsync(DateTime HesapTarih);
        Task<List<EuroHesap>> GetByHesapIbanAsync(string HesapIban);
     
    }
}
