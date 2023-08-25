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
    public class MusteriVarlikRepository : BaseRepository<MusteriVarlik, BankaContext>, IMusteriVarlikRepository
    {
        public async Task<List<MusteriVarlik>> GetByAltinHesapIDAsync(int AltinHesapID)
        {
            return await GetAllAsync(prd => prd.AltinHesapID == AltinHesapID);
        }

      

        public async Task<List<MusteriVarlik>> GetByBankaKartlarIDAsync(int BankaKartlarID)
        {
            return await GetAllAsync(prd => prd.BankaKartlarID == BankaKartlarID);
        }

        public async Task<List<MusteriVarlik>> GetByDolarHesapIDAsync(int DolarHesapID)
        {
            return await GetAllAsync(prd => prd.DolarHesapID == DolarHesapID);
        }

        public async Task<List<MusteriVarlik>> GetByEuroHesapIDAsync(int EuroHesapID)
        {
            return await GetAllAsync(prd => prd.EuroHesapID == EuroHesapID);
        }

        public async Task<List<MusteriVarlik>> GetByGümüsHesapIDAsync(int GümüsHesapID)
        {
            return await GetAllAsync(prd => prd.GumusHesapID == GümüsHesapID);
        }

        public async Task<List<MusteriVarlik>> GetByHesapAltinVadesizAsync(bool HesapAltinVadesiz)
        {
            return await GetAllAsync(prd => prd.HesapAltinVadesiz == HesapAltinVadesiz);
        }

        public async Task<List<MusteriVarlik>> GetByHesapDolarVadesizAsync(bool HesapDolarVadesiz)
        {
            return await GetAllAsync(prd => prd.HesapDolarVadesiz == HesapDolarVadesiz);
        }

        public async Task<List<MusteriVarlik>> GetByHesapDolarVadesizAsync(int DolarVadesiz)
        {
            return await GetAllAsync(prd => prd.DolarHesapID == DolarVadesiz);
        }

        public async Task<List<MusteriVarlik>> GetByHesapEuroVadesizAsync(bool HesapEuroVadesiz)
        {
            return await GetAllAsync(prd => prd.HesapEuroVadesiz == HesapEuroVadesiz);
        }

        public async Task<List<MusteriVarlik>> GetByHesapGümüsVadesizAsync(bool HesapGümüsVadesiz)
        {
            return await GetAllAsync(prd => prd.HesapGumusVadesiz == HesapGümüsVadesiz);
        }

        public async Task<List<MusteriVarlik>> GetByHesapSterlinVadesizAsync(bool HesapSterlinVadesiz)
        {
            return await GetAllAsync(prd => prd.HesapSterlinVadesiz == HesapSterlinVadesiz);
        }

        public async Task<List<MusteriVarlik>> GetByHesapTLVadeliAsync(bool HesapTLVadeli)
        {
            return await GetAllAsync(prd => prd.HesapTLVadeli == HesapTLVadeli);
        }

        public async Task<List<MusteriVarlik>> GetByHesapTLVadesizAsync(bool HesapTLVadesiz)
        {
            return await GetAllAsync(prd => prd.HesapTLVadesiz == HesapTLVadesiz);
        }

        public async Task<List<MusteriVarlik>> GetByIbanlarIDAsync(int IbanlarID)
        {
            return await GetAllAsync(prd => prd.IbanlarID == IbanlarID);
        }

        public async Task<MusteriVarlik> GetByIdAsync(int id)
        {
            return await GetAsync(prd => prd.MusteriVarlikID == id);
        }

        public async Task<List<MusteriVarlik>> GetByKrediKartlarIDAsync(int KrediKartlarID)
        {
            return await GetAllAsync(prd => prd.KrediKartlarID == KrediKartlarID);
        }

        public async Task<List<MusteriVarlik>> GetByKurKorumalıTLHesapIDAsync(int KurKorumalıTLHesapID)
        {
            return await GetAllAsync(prd => prd.KurKorumalıTLHesapID == KurKorumalıTLHesapID);
        }

        public async Task<List<MusteriVarlik>> GetByMusteriDataIDAsync(int MusteriDataID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriDataID == MusteriDataID);
        }


        public async Task<List<MusteriVarlik>> GetBySterlinHesapIDAsync(int SterlinHesapID)
        {
            return await GetAllAsync(prd => prd.SterlinHesapID == SterlinHesapID);
        }

        public async Task<List<MusteriVarlik>> GetByVadeliTLHesapIDAsync(int VadeliTLHesapID)
        {
            return await GetAllAsync(prd => prd.VadeliTLHesapID == VadeliTLHesapID);
        }

        public async Task<List<MusteriVarlik>> GetByVadesizTLHesapIDAsync(int VadesizTLHesapID)
        {
            return await GetAllAsync(prd => prd.VadesizTLHesapID == VadesizTLHesapID);
        }

        public async Task<MusteriVarlik> GetByBankaIdAsync(int BankaId)
        {
            return await GetAsync(prd => prd.BankaId == BankaId);
        }

      

        public async Task<MusteriVarlik> GetByMusteriVarlikIdAsync(int MusteriID)
        {
            return await GetAsync(prd => prd.MusteriVarlikID == MusteriID);
        }

        public async Task<List<MusteriVarlik>> GetByMusteriDataAsync(int MusterıDataID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriDataID== MusterıDataID, includeList);
        }
        public async Task<List<MusteriVarlik>> GetByMusteriDataAsync(string MusteriAD, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriAD.ToLower() == MusteriAD.ToLower(), includeList);
        }

        public async Task<List<MusteriVarlik>> GetByMusteriVarlikIDAsync(int MusteriVarlikID, params string[] includeList)
        {
            return await GetAllAsync(prd => prd.MusteriVarlikID == MusteriVarlikID);
        }
    }
}
