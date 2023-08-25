using Banka.Model.Dtos.HizliKredi;
using Banka.Model.Dtos.KartaParaAktar;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IKartaParaAktarBs
    {
        Task<ApiResponse<KartaParaAktarGetDto>> GetByIdAsync(int KartaParaİslemID, params string[] includeList);
        Task<ApiResponse<KartaParaAktarGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<KartaParaAktarGetDto>>> GetKartaParaAktarAsync(params string[] includeList);
        Task<ApiResponse<List<KartaParaAktarGetDto>>> GetByAktarılacakKartIDAsync(int AktarılacakKartID, params string[] includeList);
        Task<ApiResponse<List<KartaParaAktarGetDto>>> GetByVarlıkHesabıAsync(int VarlıkHesabı, params string[] includeList);
        Task<ApiResponse<List<KartaParaAktarGetDto>>> GetByMiktarAsync(decimal Miktar, params string[] includeList);
        Task<ApiResponse<List<KartaParaAktarGetDto>>> GetByİslemTarihiAsync(DateTime İslemTarihi, params string[] includeList);
      
        Task<ApiResponse<KartaParaAktar>> InsertAsync(KartaParaAktarPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(KartaParaAktarPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
