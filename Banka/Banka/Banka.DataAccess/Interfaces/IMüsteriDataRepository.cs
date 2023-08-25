using Banka.Model.Entities;
using Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banka.Model.Entities;
using System.Numerics;

using Banka.Model.Entities;

namespace Banka.DataAccess.Interfaces
{
    public interface IMusteriDataRepository : IBaseRepository<MusteriData>
    {
      //  Task<MusteriData> GetByMusteriDataIDAsync(int MusteriDataID);
        Task<MusteriData> GetByIdAsync(int id, params string[] includeList);

        //Task<MusteriData> GetByMusteriIDAsync(int MusteriID);
        Task<List<MusteriData>> GetByMusteriADAsync(string MusteriAD);
       // Task<List<MusteriData>> GetByMusteriVarlikIDAsync(int MusteriVarlikID);
        Task<List<MusteriData>> GetByMusteriSoYADAsync(string MusteriSoYAD);
        Task<List<MusteriData>> GetByMusteriTCAsync(string MusteriTC);
        Task<List<MusteriData>> GetByMusteriTELAsync(string MusteriTEL);
        Task<List<MusteriData>> GetByMusteriMeslekAsync(string MusteriMeslek);
        Task<List<MusteriData>> GetByMusteriAdresAsync(string MusteriAdres);
        Task<List<MusteriData>> GetByMusteriEmailAsync(string MusteriEmail);
        Task<List<MusteriData>> GetByMusteriAnneliksoyadAsync(string MusteriAnneliksoyad);
    }
}
