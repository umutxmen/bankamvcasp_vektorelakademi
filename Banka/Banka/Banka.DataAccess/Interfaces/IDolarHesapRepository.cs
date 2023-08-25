using Banka.Model.Entities;
using Infrastructure.DataAccess.Interfaces;
using Banka.Model.Entities;
using System.Numerics;

namespace Banka.DataAccess.Interfaces
{
    public interface IDolarHesapRepository: IBaseRepository<DolarHesap>
    {
        Task<DolarHesap> GetByIdAsync(int id);
        Task<DolarHesap> GetByMusteriIDAsync(int MusteriID);
        Task<List<DolarHesap>> GetByDolarVarlikAsync(decimal DolarVarlik);
        Task<List<DolarHesap>> GetByHesapTarihiAsync(DateTime HesapTarihi);
        Task<List<DolarHesap>> GetByHesapIbanAsync(string HesapIban);
 
    }
}
