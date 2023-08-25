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
    public interface IKartaParaAktarRepository : IBaseRepository<KartaParaAktar>
    {
        Task<KartaParaAktar> GetByIdAsync(int KartaParaİslemID, params string[] includeList);
        Task<List<KartaParaAktar>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);
        Task<List<KartaParaAktar>> GetByAktarılacakKartIDAsync(int AktarılacakKartID, params string[] includeList);
        Task<List<KartaParaAktar>> GetByVarlıkHesabıAsync(int VarlıkHesabı, params string[] includeList);
        Task<List<KartaParaAktar>> GetByMiktarAsync(decimal Miktar, params string[] includeList);
        Task<List<KartaParaAktar>> GetByİslemTarihiAsync(DateTime İslemTarihi, params string[] includeList);
       
    }
}
