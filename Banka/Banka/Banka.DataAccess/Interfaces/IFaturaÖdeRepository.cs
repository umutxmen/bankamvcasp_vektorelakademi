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
    public interface IFaturaOdeRepository : IBaseRepository<FaturaOde>
    {
        Task<FaturaOde> GetByIdAsync(int FaturaYatırİslemID);
        Task<FaturaOde> GetByMusteriIDAsync(int MusteriID);
        Task<List<FaturaOde>> GetByfaturanoAsync(string faturano);
        Task<List<FaturaOde>> GetByGonderenİbanAsync(string Gonderenİban);
        Task<List<FaturaOde>> GetByodenecekMiktarAsync(decimal odenecekMiktar);
        Task<List<FaturaOde>> GetByOdemeTarihAsync(DateTime OdemeTarih);
        Task<List<FaturaOde>> GetByAciklamaAsync(string Aciklama);
    }
}
