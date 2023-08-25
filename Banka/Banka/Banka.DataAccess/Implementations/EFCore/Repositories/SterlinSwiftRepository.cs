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
    public class SterlinSwiftRepository : BaseRepository<SterlinSwift, BankaContext>, ISterlinSwiftRepository
    {
        public async Task<List<SterlinSwift>> GetByAlanHesapIbanAsync(string AlanHesapIban, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.AlanHesapIban == AlanHesapIban); 
            }

        public async Task<List<SterlinSwift>> GetByAciklamaAsync(string Aciklama, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.Aciklama == Aciklama);
        }

        public async Task<List<SterlinSwift>> GetByGidenHesapIbanAsync(string GidenHesapIban, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.GidenHesapIban == GidenHesapIban);
        }

        public async Task<SterlinSwift> GetByIdAsync(int SterlinSwiftID, params string[] includeList)
        {
            return await GetAsync(prd => prd.SterlinSwiftID == SterlinSwiftID);
        }

        public async Task<List<SterlinSwift>> GetByMiktarAsync(decimal Miktar, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.Miktar == Miktar);
        }

        public async Task<List<SterlinSwift>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriID == MusteriID);
        }

        public async Task<List<SterlinSwift>> GetBySwiftKoduAsync(int SwiftKodu, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.SwiftKodu == SwiftKodu);
        }

        public async Task<List<SterlinSwift>> GetBySwiftTarihiAsync(DateTime SwiftTarihi, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.SwiftTarihi == SwiftTarihi);
        }
    }
}
