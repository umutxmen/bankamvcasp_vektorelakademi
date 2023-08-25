using Infrastructure.DataAccess.Implementations.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banka.DataAccess.Implementations.EFCore.Contexts;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.EuroSwift;
using Banka.Model.Entities;
using System.Numerics;

namespace Banka.DataAccess.Implementations.EFCore.Repositories
{
    public class EuroSwiftRepository : BaseRepository<EuroSwift, BankaContext>, IEuroSwiftRepository
    {
        public async Task<List<EuroSwift>> GetByAlanHesapIbanAsync(string AlanHesapIban)
        {
            return await GetAllAsync(prd => prd.AlanHesapIban == AlanHesapIban);
        }

        public async Task<List<EuroSwift>> GetByAciklamaAsync(string Aciklama)
        {
            return await GetAllAsync(prd => prd.Aciklama == Aciklama);
        }

        public async Task<List<EuroSwift>> GetByGidenHesapIbanAsync(string GidenHesapIban)
        {
            return await GetAllAsync(prd => prd.GidenHesapIban == GidenHesapIban);
        }

        public async Task<EuroSwift> GetByIdAsync(int EuroSwiftID)
        {
            return await GetAsync(prd => prd.EuroSwiftID == EuroSwiftID);
        }

        public async Task<List<EuroSwift>> GetByMiktarAsync(int Miktar)
        {
            return await GetAllAsync(prd => prd.Miktar == Miktar);
        }

        public async Task<EuroSwift> GetByMusteriIDAsync(int MusteriID)
        {
            return await GetAsync(prd => prd.MusteriID == MusteriID);
        }

        public async Task<List<EuroSwift>> GetBySwiftKoduAsync(int SwiftKodu)
        {
            return await GetAllAsync(prd => prd.SwiftKodu == SwiftKodu);
        }

        public async Task<List<EuroSwift>> GetBySwiftTarihiAsync(DateTime SwiftTarihi)
        {
            return await GetAllAsync(prd => prd.SwiftTarihi == SwiftTarihi);
        }
    }
}
