using Banka.Model.Dtos.MusteriData;
using Banka.Model.Dtos.MusteriVarlik;
using Banka.Model.Dtos.NakitAvans;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IMusteriVarlikBs
    {
        Task<ApiResponse<MusteriVarlikGetDto>> GetMusteriVarlikByIdAsync(int id, params string[] includeList);

        Task<ApiResponse<MusteriVarlikGetDto>> GetByBankaIdAsync(int BankaId, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByMusteriDataAsync(string MusteriAD, params string[] includeList);
      //  Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByMusteriVarlikIDAsync(int MusteriVarlikID, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByMusteriDataIDAsync(int MusteriDataID, params string[] includeList);

        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetMusteriVarlikAsync(params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByHesapTLVadesizAsync(bool HesapTLVadesiz, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByHesapTLVadeliAsync(bool HesapTLVadeli, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByHesapEuroVadesizAsync(bool HesapEuroVadesiz, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByHesapDolarVadesizAsync(bool HesapEuroVadesiz, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByHesapSterlinVadesizAsync(bool HesapSterlinVadesiz, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByHesapAltinVadesizAsync(bool HesapAltinVadesiz, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByHesapGümüsVadesizAsync(bool HesapGümüsVadesiz, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByVadesizTLHesapIDAsync(int VadesizTLHesapID, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByVadeliTLHesapIDAsync(int VadeliTLHesapID, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByDolarHesapIDAsync(int DolarHesapID, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByEuroHesapIDAsync(int EuroHesapID, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetBySterlinHesapIDAsync(int SterlinHesapID, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByKurKorumalıTLHesapIDAsync(int KurKorumalıTLHesapID, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByAltinHesapIDAsync(int AltinHesapID, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByGümüsHesapIDAsync(int GümüsHesapID, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByBankaKartlarIDAsync(int BankaKartlarID, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByKrediKartlarIDAsync(int KrediKartlarID, params string[] includeList);
        Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByIbanlarIDAsync(int IbanlarID, params string[] includeList);



        Task<ApiResponse<MusteriVarlik>> InsertAsync(MusteriVarlikPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(MusteriVarlikPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
