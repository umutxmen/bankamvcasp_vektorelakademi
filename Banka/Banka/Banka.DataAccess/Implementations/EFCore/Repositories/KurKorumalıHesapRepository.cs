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
    public class KurKorumalıHesapRepository : BaseRepository<KurKorumalıHesap, BankaContext>, IKurKorumalıHesapRepository
    {
        public async Task<List<KurKorumalıHesap>> GetByDovizIDAsync(int DovizID)
        {
            return await GetAllAsync(prd => prd.DovizID == DovizID);
        }

        public async Task<List<KurKorumalıHesap>> GetByVarlikTLAsync(decimal VarlikTL)
        {
            return await GetAllAsync(prd => prd.VarlikTL == VarlikTL);
        }

        public async Task<List<KurKorumalıHesap>> GetByHesapAcimKuruAsync(decimal HesapAcimKuru)
        {
            return await GetAllAsync(prd => prd.HesapAcimKuru == HesapAcimKuru);
        }

        public async Task<List<KurKorumalıHesap>> GetByHesapAcimTarihiAsync(DateTime HesapAcimTarihi)
        {
            return await GetAllAsync(prd => prd.HesapAcimTarihi == HesapAcimTarihi);
        }

        public async Task<List<KurKorumalıHesap>> GetByHesapFaizoranAsync(int HesapFaizoran)
        {
            return await GetAllAsync(prd => prd.HesapFaizoran == HesapFaizoran);
        }

        public async Task<List<KurKorumalıHesap>> GetByHesapKapanmaKuruAsync(decimal HesapKapanmaKuru)
        {
            return await GetAllAsync(prd => prd.HesapKapanmaKuru == HesapKapanmaKuru);
        }

        public async Task<List<KurKorumalıHesap>> GetByHesapKapanmaTarihiAsync(DateTime HesapKapanmaTarihi)
        {
            return await GetAllAsync(prd => prd.HesapKapanmaTarihi == HesapKapanmaTarihi);
        }

        public async Task<KurKorumalıHesap> GetByIdAsync(int KurKorumaliHesapId)
        {
            return await GetAsync(prd => prd.KurKorumaliHesapId == KurKorumaliHesapId);
        }

        public async Task<KurKorumalıHesap> GetByMusteriIDAsync(int MusteriID)
        {
            return await GetAsync(prd => prd.MusteriID == MusteriID);
        }

      
    }
}
