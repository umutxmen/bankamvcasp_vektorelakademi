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
    public interface IMusteriVarlikRepository : IBaseRepository<MusteriVarlik>
    {
        Task<MusteriVarlik> GetByIdAsync(int MusteriVarlikID);

        Task<MusteriVarlik> GetByBankaIdAsync(int BankaId);
       // Task<List<MusteriVarlik>> GetByMusteriDataAsync(int MusteriDataID, params string[] includeList);
        Task<List<MusteriVarlik>> GetByMusteriDataIDAsync(int MusteriDataID, params string[] includeList);
        Task<List<MusteriVarlik>> GetByMusteriVarlikIDAsync(int GetByMusteriVarlikIDAsync, params string[] includeList);
        Task<List<MusteriVarlik>> GetByMusteriDataAsync(string MusteriAD, params string[] includeList);


        Task<List<MusteriVarlik>> GetByHesapTLVadesizAsync(bool HesapTLVadesiz);
        Task<List<MusteriVarlik>> GetByHesapTLVadeliAsync(bool HesapTLVadeli);
        Task<List<MusteriVarlik>> GetByHesapEuroVadesizAsync(bool HesapEuroVadesiz);
        Task<List<MusteriVarlik>> GetByHesapSterlinVadesizAsync(bool HesapSterlinVadesiz);
        Task<List<MusteriVarlik>> GetByHesapDolarVadesizAsync(bool HesapDolarVadesiz);
        Task<List<MusteriVarlik>> GetByHesapAltinVadesizAsync(bool HesapAltinVadesiz);
        Task<List<MusteriVarlik>> GetByHesapGümüsVadesizAsync(bool HesapGümüsVadesiz);
        Task<List<MusteriVarlik>> GetByVadesizTLHesapIDAsync(int VadesizTLHesapID);
        Task<List<MusteriVarlik>> GetByVadeliTLHesapIDAsync(int VadeliTLHesapID);
        Task<List<MusteriVarlik>> GetByDolarHesapIDAsync(int DolarHesapID);
        Task<List<MusteriVarlik>> GetByEuroHesapIDAsync(int EuroHesapID);
        Task<List<MusteriVarlik>> GetBySterlinHesapIDAsync(int SterlinHesapID);
        Task<List<MusteriVarlik>> GetByKurKorumalıTLHesapIDAsync(int KurKorumalıTLHesapID);
        Task<List<MusteriVarlik>> GetByAltinHesapIDAsync(int AltinHesapID);
        Task<List<MusteriVarlik>> GetByGümüsHesapIDAsync(int GümüsHesapID);
        Task<List<MusteriVarlik>> GetByBankaKartlarIDAsync(int BankaKartlarID);
        Task<List<MusteriVarlik>> GetByKrediKartlarIDAsync(int KrediKartlarID);
        Task<List<MusteriVarlik>> GetByIbanlarIDAsync(int IbanlarID);

    }
}
