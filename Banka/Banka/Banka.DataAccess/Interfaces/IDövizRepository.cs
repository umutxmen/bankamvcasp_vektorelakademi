using Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banka.Model.Entities;
using System.Numerics;

namespace WS.DataAccess.Interfaces
{
    public interface IDovizRepository : IBaseRepository<Doviz>
    {
        Task<Doviz> GetByIdAsync(int DovizID);
       
        Task<List<Doviz>> GetByDovizAdıAsync(string DovizAdı);
        Task<List<Doviz>> GetByGüncelKurAlımAsync(decimal GüncelKurAlım);
        Task<List<Doviz>> GetByGüncelKurSatımAsync(decimal GüncelKurSatım);

    }
}
