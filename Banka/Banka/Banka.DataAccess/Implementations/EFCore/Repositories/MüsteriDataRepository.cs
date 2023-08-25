using Banka.Model.Entities;
using Infrastructure.DataAccess.Implementations.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banka.DataAccess.Implementations.EFCore.Contexts;
using Banka.DataAccess.Interfaces;
using Banka.Model.Entities;
using System.Numerics;


namespace Banka.DataAccess.Implementations.EFCore.Repositories
{
    public class MusteriDataRepository : BaseRepository<MusteriData, BankaContext>, IMusteriDataRepository
    {
      

        public async Task<List<MusteriData>> GetByMusteriADAsync(string MusteriAD)
        {
            return await GetAllAsync(prd => prd.MusteriAD == MusteriAD);
        }

        public async Task<List<MusteriData>> GetByMusteriAdresAsync(string MusteriAdres)
        {
            return await GetAllAsync(prd => prd.MusteriAdres == MusteriAdres);
        }

        public async Task<List<MusteriData>> GetByMusteriAnneliksoyadAsync(string MusteriAnneliksoyad)
        {
            return await GetAllAsync(prd => prd.MusteriAnneliksoyad == MusteriAnneliksoyad);
        }

        public async Task<List<MusteriData>> GetByMusteriEmailAsync(string MusteriEmail)
        {
            return await GetAllAsync(prd => prd.MusteriEmail == MusteriEmail);
        }

        

        public async Task<List<MusteriData>> GetByMusteriMeslekAsync(string MusteriMeslek)
        {
            return await GetAllAsync(prd => prd.MusteriMeslek == MusteriMeslek);
        }

        public async Task<List<MusteriData>> GetByMusteriSoYADAsync(string MusteriSoYAD)
        {
            return await GetAllAsync(prd => prd.MusteriSoYAD == MusteriSoYAD);
        }

        public async Task<List<MusteriData>> GetByMusteriTCAsync(string MusteriTC)
        {
            return await GetAllAsync(prd => prd.MusteriTC == MusteriTC);
        }

        public async Task<List<MusteriData>> GetByMusteriTELAsync(string MusteriTEL)
        {
            return await GetAllAsync(prd => prd.MusteriTEL == MusteriTEL);
        }

        public async Task<MusteriData> GetByIdAsync(int id, params string[] includeList)
        {
            return await GetAsync(prd => prd.MusteriDataID == id, includeList);
        }

        //   public async Task<List<MusteriData>> GetByMusteriVarlikIDAsync(int MusteriVarlikID)
        //  {
        //  return await GetAllAsync(prd => prd.MusteriVarlikID == MusteriVarlikID);
        //  }
    }
}
