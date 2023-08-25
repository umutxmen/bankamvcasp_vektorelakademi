using Banka.Model.Dtos.Harcama;
using Banka.Model.Dtos.HizliKredi;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IHizliKrediBs
    {
        Task<ApiResponse<HizliKrediGetDto>> GetByIdAsync(int HizliKrediID, params string[] includeList);
        Task<ApiResponse<HizliKrediGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<HizliKrediGetDto>>> GetHizliKrediAsync(params string[] includeList);
        Task<ApiResponse<List<HizliKrediGetDto>>> GetByAktarılacakİbanAsync(string Aktarılacakİban, params string[] includeList);
        Task<ApiResponse<List<HizliKrediGetDto>>> GetByKrediMiktarAsync(decimal KrediMiktar, params string[] includeList);
        Task<ApiResponse<List<HizliKrediGetDto>>> GetByKrediFaizAsync(decimal KrediFaiz, params string[] includeList);
        Task<ApiResponse<List<HizliKrediGetDto>>> GetByKrediÇekimTarihiAsync(DateTime KrediÇekimTarihi, params string[] includeList);
        Task<ApiResponse<List<HizliKrediGetDto>>> GetByKrediTaksitSayısıAsync(int KrediTaksitSayısı, params string[] includeList);
        Task<ApiResponse<List<HizliKrediGetDto>>> GetByKrediSonOdemeTarihAsync(DateTime KrediSonOdemeTarih, params string[] includeList);
        Task<ApiResponse<List<HizliKrediGetDto>>> GetByKrediSonodemeTutarAsync(decimal KrediSonodemeTutar, params string[] includeList);

        Task<ApiResponse<HizliKredi>> InsertAsync(HizliKrediPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(HizliKrediPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
