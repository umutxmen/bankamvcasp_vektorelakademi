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
    public interface IGümüsHesapRepository : IBaseRepository<GümüsHesap>
    {
        Task<GümüsHesap> GetByIdAsync(int GümüsHesapID, params string[] includeList);
        Task<List<GümüsHesap>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);
        Task<List<GümüsHesap>> GetByGümüsVarlikGramAsync(decimal GümüsVarlikGram, params string[] includeList);
        Task<List<GümüsHesap>> GetByHesapTarihAsync(DateTime HesapTarih, params string[] includeList);

    }
}
