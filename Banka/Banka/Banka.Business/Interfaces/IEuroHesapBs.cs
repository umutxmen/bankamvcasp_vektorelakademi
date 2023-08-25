using Banka.Model.Dtos.Doviz;
using Banka.Model.Dtos.EFT;
using Banka.Model.Dtos.EuroHesap;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IEuroHesapBs
    {
        Task<ApiResponse<EuroHesapGetDto>> GetByIdAsync(int EuroHesapID, params string[] includeList);
        Task<ApiResponse<EuroHesapGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<EuroHesapGetDto>>> GetEuroHesapAsync(params string[] includeList);
        Task<ApiResponse<List<EuroHesapGetDto>>> GetByEuroVarlikAsync(decimal EuroVarlik, params string[] includeList);
        Task<ApiResponse<List<EuroHesapGetDto>>> GetByHesapTarihAsync(DateTime HesapTarih, params string[] includeList);
        Task<ApiResponse<List<EuroHesapGetDto>>> GetByHesapIbanAsync(string HesapIban, params string[] includeList);

        Task<ApiResponse<EuroHesap>> InsertAsync(EuroHesapPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(EuroHesapPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
