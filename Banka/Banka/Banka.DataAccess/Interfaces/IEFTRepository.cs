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
    public interface IEFTRepository : IBaseRepository<EFT> {

        Task<EFT> GetByIdAsync(int EFTID);
        Task<EFT> GetByMusteriIDAsync(int MusteriID);
        Task<List<EFT>> GetByBankaIDAsync(int BankaID);
        Task<List<EFT>> GetByDigerBankaIDAsync(int DigerBankaID);
        Task<List<EFT>> GetByGidenIbanAsync(string GidenIban);
        Task<List<EFT>> GetByAlanIbanAsync(string AlanIban);
        Task<List<EFT>> GetByMiktarAsync(decimal Miktar);
        Task<List<EFT>> GetByİslemTarihiAsync(DateTime İslemTarihi);
        Task<List<EFT>> GetByAciklamaAsync(string Aciklama);


    }
}
