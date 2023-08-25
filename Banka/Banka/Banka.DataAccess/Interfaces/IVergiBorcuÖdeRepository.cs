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
    public interface IVergiBorcuOdeRepository : IBaseRepository<VergiBorcuOde>
    {
        Task<VergiBorcuOde> GetByIdAsync(int VergiOdeİslemID, params string[] includeList);
        Task<List<VergiBorcuOde>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);
        Task<List<VergiBorcuOde>> GetByverginoAsync(string vergino, params string[] includeList);
        Task<List<VergiBorcuOde>> GetByMusteriTCNoAsync(string MusteriTCNo, params string[] includeList);
        Task<List<VergiBorcuOde>> GetByGondericiIBANAsync(string GondericiIBAN, params string[] includeList);
        Task<List<VergiBorcuOde>> GetByGondericiADAsync(string GondericiAD, params string[] includeList);
        Task<List<VergiBorcuOde>> GetByGondericiSoyadAsync(string GondericiSoyad, params string[] includeList);
        Task<List<VergiBorcuOde>> GetByAciklamaAsync(string Aciklama, params string[] includeList);
        Task<List<VergiBorcuOde>> GetByOdemeTarihAsync(DateTime OdemeTarih, params string[] includeList);
    }
}
