using Banka.Model.Entities;
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
    public interface IVadeliTLHesapRepository : IBaseRepository<VadeliTLHesap>
    {
        Task<VadeliTLHesap> GetByIdAsync(int VadeliTLHesapID, params string[] includeList);
        Task<List<VadeliTLHesap>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);
        Task<List<VadeliTLHesap>> GetByVarlıkAsync(decimal Varlık, params string[] includeList);
        Task<List<VadeliTLHesap>> GetByVadeBasTarihiAsync(DateTime VadeBasTarihi, params string[] includeList);
        Task<List<VadeliTLHesap>> GetByVadeBitisTarihiAsync(DateTime VadeBitisTarihi, params string[] includeList);
        Task<List<VadeliTLHesap>> GetByVadeliFaizoranAsync(int VadeliFaizoran, params string[] includeList);
        Task<List<VadeliTLHesap>> GetByVadeSonuMiktarAsync(decimal VadeSonuMiktar, params string[] includeList);
    }
}
