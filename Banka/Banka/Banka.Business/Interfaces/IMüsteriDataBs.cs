using Banka.Model.Dtos.KurKorumalıHesap;
using Banka.Model.Dtos.MusteriData;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IMusteriDataBs
    {
        Task<ApiResponse<MusteriDataGetDto>> GetMusteriDataByIdAsync(int id, params string[] includeList);

        // Task<ApiResponse<MusteriDataGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<MusteriDataGetDto>>> GetMusteriDataAsync(params string[] includeList);
        Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriADAsync(string MusteriAD, params string[] includeList);
        Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriSoYADAsync(string MusteriSoYAD, params string[] includeList);
        Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriTCAsync(string MusteriTC, params string[] includeList);
        Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriTELAsync(string MusteriTEL, params string[] includeList);
        Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriMeslekAsync(string MusteriMeslek, params string[] includeList);
        Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriAdresAsync(string MusteriAdres, params string[] includeList);
        //Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriVarlikIDAsync(int MusteriVarlikID, params string[] includeList);
        Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriEmailAsync(string MusteriEmail, params string[] includeList);
        Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriAnneliksoyadAsync(string MusteriAnneliksoyad, params string[] includeList);



        Task<ApiResponse<MusteriData>> InsertAsync(MusteriDataPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(MusteriDataPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
