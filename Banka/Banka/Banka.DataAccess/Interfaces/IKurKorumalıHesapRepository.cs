using Banka.Model.Entities;
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
    public interface IKurKorumalıHesapRepository : IBaseRepository<KurKorumalıHesap>
    {
        Task<KurKorumalıHesap> GetByIdAsync(int KurKorumaliHesapId);
        Task<KurKorumalıHesap> GetByMusteriIDAsync(int MusteriID);
        Task<List<KurKorumalıHesap>> GetByVarlikTLAsync(decimal VarlikTL);
        Task<List<KurKorumalıHesap>> GetByDovizIDAsync(int DovizID);
        Task<List<KurKorumalıHesap>> GetByHesapAcimTarihiAsync(DateTime HesapAcimTarihi);
        Task<List<KurKorumalıHesap>> GetByHesapAcimKuruAsync(decimal HesapAcimKuru);
        Task<List<KurKorumalıHesap>> GetByHesapKapanmaTarihiAsync(DateTime HesapKapanmaTarihi);
        Task<List<KurKorumalıHesap>> GetByHesapKapanmaKuruAsync(decimal HesapKapanmaKuru);
        Task<List<KurKorumalıHesap>> GetByHesapFaizoranAsync(int HesapFaizoran);
    }
}
