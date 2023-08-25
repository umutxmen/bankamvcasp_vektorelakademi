using Infrastructure.DataAccess.Implementations.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banka.DataAccess.Implementations.EFCore.Contexts;
using Banka.DataAccess.Interfaces;
using Banka.Model.Entities;
using WS.DataAccess.Interfaces;
using System.Numerics;

namespace Banka.DataAccess.Implementations.EFCore.Repositories
{
    public class EFTRepository : BaseRepository<EFT, BankaContext>, IEFTRepository
    {
        public async Task<List<EFT>> GetByAlanIbanAsync(string AlanIban)
        {
            return await GetAllAsync(prd => prd.AlanIban == AlanIban);
        }

        public async Task<List<EFT>> GetByAciklamaAsync(string Aciklama)
        {
            return await GetAllAsync(prd => prd.Aciklama == Aciklama);
        }

        public async Task<List<EFT>> GetByBankaIDAsync(int BankaID)
        {
            return await GetAllAsync(prd => prd.BankaID == BankaID);
        }

        public async Task<List<EFT>> GetByDigerBankaIDAsync(int DigerBankaID)
        {
            return await GetAllAsync(prd => prd.DigerBankaID == DigerBankaID);
        }

        public async Task<List<EFT>> GetByGidenIbanAsync(string GidenIban)
        {
            return await GetAllAsync(prd => prd.GidenIban == GidenIban);
        }

        public async Task<EFT> GetByIdAsync(int EFTID)
        {
            return await GetAsync(prd => prd.EFTID == EFTID);
        }

        public async Task<List<EFT>> GetByMiktarAsync(decimal Miktar)
        {
            return await GetAllAsync(prd => prd.Miktar == Miktar);
        }

        public async Task<EFT> GetByMusteriIDAsync(int MusteriID)
        {
            return await GetAsync(prd => prd.MusteriID == MusteriID);
        }

        public async Task<List<EFT>> GetByİslemTarihiAsync(DateTime İslemTarihi)
        {
            return await GetAllAsync(prd => prd.İslemTarihi == İslemTarihi);
        }
    }
}
