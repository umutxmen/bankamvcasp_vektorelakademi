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
    public interface IVadesizTLHesapRepository : IBaseRepository<VadesizTLHesap>
    {
        Task<VadesizTLHesap> GetByIdAsync(int VadesizTLHesapID, params string[] includeList);
        Task<List<VadesizTLHesap>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);
        Task<List<VadesizTLHesap>> GetByHesapTutarAsync(decimal HesapTutar, params string[] includeList);
        Task<List<VadesizTLHesap>> GetByHesapAcilmaTarihAsync(DateTime HesapAcilmaTarih, params string[] includeList);
        Task<List<VadesizTLHesap>> GetByHesapIBANAsync(string HesapIBAN, params string[] includeList);
       
    }
}
