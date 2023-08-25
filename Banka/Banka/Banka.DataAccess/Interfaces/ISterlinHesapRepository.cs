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
    public interface ISterlinHesapRepository : IBaseRepository<SterlinHesap>
    {
        Task<SterlinHesap> GetByIdAsync(int SterlinHesapId, params string[] includeList);
        Task<List<SterlinHesap>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);
        Task<List<SterlinHesap>> GetBySterlinVarlikAsync(decimal SterlinVarlik, params string[] includeList);
        Task<List<SterlinHesap>> GetByHesapTarihAsync(DateTime HesapTarih, params string[] includeList);
        Task<List<SterlinHesap>> GetByHesapIbanAsync(string HesapIban, params string[] includeList);
    }
}
