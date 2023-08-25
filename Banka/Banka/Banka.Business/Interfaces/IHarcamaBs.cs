using Banka.Model.Dtos.EuroSwift;
using Banka.Model.Dtos.GümüsHesap;
using Banka.Model.Dtos.Harcama;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IHarcamaBs
    {
        Task<ApiResponse<HarcamaGetDto>> GetHarcamaByIdAsync(int id, params string[] includeList);
        Task<ApiResponse<HarcamaGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<HarcamaGetDto>>> GetHarcamaAsync(params string[] includeList);
        Task<ApiResponse<List<HarcamaGetDto>>> GetByHarcananKartIDAsync(int HarcananKartID, params string[] includeList);
        Task<ApiResponse<List<HarcamaGetDto>>> GetByHarcananMiktarAsync(decimal HarcananMiktar, params string[] includeList);
        Task<ApiResponse<List<HarcamaGetDto>>> GetByTaksitMiktarıAsync(int TaksitMiktarı, params string[] includeList);
        Task<ApiResponse<List<HarcamaGetDto>>> GetByHarcamaTarihiAsync(DateTime HarcamaTarihi, params string[] includeList);
        Task<ApiResponse<List<HarcamaGetDto>>> GetBySatıcıKoduAsync(string SatıcıKodu, params string[] includeList);

        Task<ApiResponse<Harcama>> InsertAsync(HarcamaPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(HarcamaPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
