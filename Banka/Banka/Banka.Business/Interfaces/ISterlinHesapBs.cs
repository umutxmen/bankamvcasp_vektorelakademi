using Banka.Model.Dtos.SanalKart;
using Banka.Model.Dtos.SterlinHesap;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface ISterlinHesapBs
    {
        Task<ApiResponse<SterlinHesapGetDto>> GetByIdAsync(int SterlinHesapId, params string[] includeList);

        Task<ApiResponse<SterlinHesapGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<SterlinHesapGetDto>>> GetSterlinHesapAsync(params string[] includeList);
        Task<ApiResponse<List<SterlinHesapGetDto>>> GetBySterlinVarlikAsync(decimal SterlinVarlik, params string[] includeList);
        Task<ApiResponse<List<SterlinHesapGetDto>>> GetByHesapTarihAsync(DateTime HesapTarih, params string[] includeList);
        Task<ApiResponse<List<SterlinHesapGetDto>>> GetByHesapIbanAsync(string HesapIban, params string[] includeList);
  


        Task<ApiResponse<SterlinHesap>> InsertAsync(SterlinHesapPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(SterlinHesapPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
