using Banka.Model.Dtos.DolarHesap;
using Banka.Model.Dtos.Doviz;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IDovizBs
    {
        Task<ApiResponse<DovizGetDto>> GetByIdAsync(int DovizID, params string[] includeList);

        Task<ApiResponse<List<DovizGetDto>>> GetDovizAsync(params string[] includeList);
        Task<ApiResponse<List<DovizGetDto>>> GetByDovizAdıAsync(string DovizAdı, params string[] includeList);
        Task<ApiResponse<List<DovizGetDto>>> GetByGüncelKurAlımAsync(decimal GüncelKurAlım, params string[] includeList);
        Task<ApiResponse<List<DovizGetDto>>> GetByGüncelKurSatımAsync(decimal GüncelKurSatım, params string[] includeList);

        Task<ApiResponse<Doviz>> InsertAsync(DovizPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(DovizPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
