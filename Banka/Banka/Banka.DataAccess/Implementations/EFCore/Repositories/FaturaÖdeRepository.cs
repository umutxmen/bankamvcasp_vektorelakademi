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
    public class FaturaOdeRepository : BaseRepository<FaturaOde, BankaContext>, IFaturaOdeRepository
    {
        public async Task<List<FaturaOde>> GetByAciklamaAsync(string Aciklama)
        {
            return await GetAllAsync(prd => prd.Aciklama == Aciklama);
        }

        public async Task<List<FaturaOde>> GetByGonderenİbanAsync(string Gonderenİban)
        {
            return await GetAllAsync(prd => prd.Gonderenİban == Gonderenİban);
        }

        public async Task<FaturaOde> GetByIdAsync(int FaturaYatırİslemID)
        {
            return await GetAsync(prd => prd.FaturaYatırİslemID == FaturaYatırİslemID);
        }

        public async Task<FaturaOde> GetByMusteriIDAsync(int MusteriID)
        {
            return await GetAsync(prd => prd.MusteriID == MusteriID);
        }

        public async Task<List<FaturaOde>> GetByfaturanoAsync(string faturano)
        {
            return await GetAllAsync(prd => prd.faturano == faturano);
        }

        public async Task<List<FaturaOde>> GetByOdemeTarihAsync(DateTime OdemeTarih)
        {
            return await GetAllAsync(prd => prd.OdemeTarih == OdemeTarih);
        }

        public async Task<List<FaturaOde>> GetByodenecekMiktarAsync(decimal odenecekMiktar)
        {
            return await GetAllAsync(prd => prd.odenecekMiktar == odenecekMiktar);
        }
    }
}
