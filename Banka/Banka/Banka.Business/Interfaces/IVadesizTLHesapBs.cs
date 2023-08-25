using Banka.Model.Dtos.TLHavale;
using Banka.Model.Dtos.VadesizTLHesap;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IVadesizTLHesapBs
    {
        Task<ApiResponse<VadesizTLHesapGetDto>> GetByIdAsync(int VadesizTLHesapID, params string[] includeList);

        Task<ApiResponse<VadesizTLHesapGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<VadesizTLHesapGetDto>>> GetTLVadesizTLHesapAsync(params string[] includeList);
        Task<ApiResponse<List<VadesizTLHesapGetDto>>> GetByHesapTutarAsync(decimal HesapTutar, params string[] includeList);
        Task<ApiResponse<List<VadesizTLHesapGetDto>>> GetByHesapIBANAsync(string HesapIBAN, params string[] includeList);
        Task<ApiResponse<List<VadesizTLHesapGetDto>>> GetByHesapAcilmaTarihAsync(DateTime HesapAcilmaTarih, params string[] includeList);
        

        Task<ApiResponse<VadesizTLHesap>> InsertAsync(VadesizTLHesapPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(VadesizTLHesapPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
