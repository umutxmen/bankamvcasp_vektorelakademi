using Infrastructure.DataAccess.Implementations.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Banka.DataAccess.Implementations.EFCore.Contexts;
using Banka.DataAccess.Interfaces;
using Banka.Model.Entities;
using System.Numerics;

namespace WS.DataAccess.Implementations.EFCore.Repositories
{
    public class DolarSwiftRepository : BaseRepository<DolarSwift, BankaContext>, IDolarSwiftRepository
    {
        public async Task<List<DolarSwift>> GetByAlanHesapIbanAsync(string AlanHesapIban)
        {
            return await GetAllAsync(prd => prd.AlanHesapIban == AlanHesapIban);
        }

        public async Task<List<DolarSwift>> GetByAciklamaAsync(string Aciklama)
        {
            return await GetAllAsync(prd => prd.Aciklama == Aciklama); 
        }

        public async Task<List<DolarSwift>> GetByGidenHesapIbanAsync(string GidenHesapIban)
        {
            return await GetAllAsync(prd => prd.GidenHesapIban == GidenHesapIban);
        }

        public async Task<DolarSwift> GetByIdAsync(int id)
        {
            return await GetAsync(prd => prd.DolarSwiftID == id);
        }

        public async Task<List<DolarSwift>> GetByMiktarAsync(decimal Miktar)
        {
            return await GetAllAsync(prd => prd.Miktar == Miktar);
        }

        public async Task<DolarSwift> GetByMusteriIDAsync(int MusteriID)
        {
            return await GetAsync(prd => prd.MusteriID == MusteriID);
        }

        public async Task<List<DolarSwift>> GetBySwiftKoduAsync(int SwiftKodu)
        {
            return await GetAllAsync(prd => prd.SwiftKodu == SwiftKodu);
        }

        public async Task<List<DolarSwift>> GetBySwiftTarihiAsync(DateTime SwiftTarihi)
        {
            return await GetAllAsync(prd => prd.SwiftTarihi == SwiftTarihi);
        }
    }
}
