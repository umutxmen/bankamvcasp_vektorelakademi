using Banka.Model.Dtos.EuroSwift;
using Banka.Model.Dtos.Faturaode;
using Banka.Model.Dtos.GümüsHesap;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IGümüsHesapBs
    {
        Task<ApiResponse<GümüsHesapGetDto>> GetByIdAsync(int GümüsHesapID, params string[] includeList);
        Task<ApiResponse<GümüsHesapGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<GümüsHesapGetDto>>> GetGümüsHesapAsync(params string[] includeList);
        Task<ApiResponse<List<GümüsHesapGetDto>>> GetByHesapTarihAsync(DateTime HesapTarih, params string[] includeList);
        Task<ApiResponse<List<GümüsHesapGetDto>>> GetByGümüsVarlikGramAsync(decimal GümüsVarlikGram, params string[] includeList);
       

        Task<ApiResponse<GümüsHesap>> InsertAsync(GümüsHesapPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(GümüsHesapPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
