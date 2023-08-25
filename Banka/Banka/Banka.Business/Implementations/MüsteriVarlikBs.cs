using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.KurKorumalıHesap;
using Banka.Model.Dtos.MusteriData;
using Banka.Model.Dtos.MusteriVarlik;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Implementations
{
    public class MusteriVarlikBs : IMusteriVarlikBs
    {
        private readonly IMusteriVarlikRepository _repo;
        private readonly IMapper _mapper;
        public MusteriVarlikBs(IMusteriVarlikRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public async Task<ApiResponse<NoData>> DeleteAsync(int id)
        {
            if (id <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(id);
            if (bankabilgi != null)
            {
                await _repo.DeleteAsync(bankabilgi);
                return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
            }
            throw new NotFoundException("Silinecek olan içerik bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByAltinHesapIDAsync(int AltinHesapID, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByAltinHesapIDAsync(AltinHesapID);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<MusteriVarlikGetDto>> GetByBankaIdAsync(int BankaId, params string[] includeList)
        {
            if (BankaId <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByBankaIdAsync(BankaId);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<MusteriVarlikGetDto>(bankakartı);
                return ApiResponse<MusteriVarlikGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByBankaKartlarIDAsync(int BankaKartlarID, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByBankaKartlarIDAsync(BankaKartlarID);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByDolarHesapIDAsync(int DolarHesapID, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByDolarHesapIDAsync(DolarHesapID);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByEuroHesapIDAsync(int EuroHesapID, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByEuroHesapIDAsync(EuroHesapID);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByGümüsHesapIDAsync(int GümüsHesapID, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByGümüsHesapIDAsync(GümüsHesapID);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByHesapAltinVadesizAsync(bool HesapAltinVadesiz, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByHesapAltinVadesizAsync(HesapAltinVadesiz);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByHesapDolarVadesizAsync(bool HesapEuroVadesiz, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByHesapDolarVadesizAsync(HesapEuroVadesiz);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

      

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByHesapEuroVadesizAsync(bool HesapEuroVadesiz, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByHesapEuroVadesizAsync(HesapEuroVadesiz);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByHesapGümüsVadesizAsync(bool HesapGümüsVadesiz, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByHesapGümüsVadesizAsync(HesapGümüsVadesiz);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByHesapSterlinVadesizAsync(bool HesapSterlinVadesiz, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByHesapSterlinVadesizAsync(HesapSterlinVadesiz);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByHesapTLVadeliAsync(bool HesapTLVadeli, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByHesapTLVadeliAsync(HesapTLVadeli);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByHesapTLVadesizAsync(bool HesapTLVadesiz, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByHesapTLVadesizAsync(HesapTLVadesiz);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByIbanlarIDAsync(int IbanlarID, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByIbanlarIDAsync(IbanlarID);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<MusteriVarlikGetDto>> GetByIdAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(MusteriID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<MusteriVarlikGetDto>(bankabilgi);
                return ApiResponse<MusteriVarlikGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByKrediKartlarIDAsync(int KrediKartlarID, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByKrediKartlarIDAsync(KrediKartlarID);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByKurKorumalıTLHesapIDAsync(int KurKorumalıTLHesapID, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByKurKorumalıTLHesapIDAsync(KurKorumalıTLHesapID);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

       

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByMusteriDataAsync(string MusteriAD, params string[] includeList)
        {
            var products = await _repo.GetByMusteriDataAsync(MusteriAD, includeList);
            if (products != null && products.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(products);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByMusteriDataIDAsync(int MusteriDataID, params string[] includeList)
        {

            var Musterivarlik = await _repo.GetByMusteriDataIDAsync(MusteriDataID);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<MusteriVarlikGetDto>> GetMusteriVarlikByIdAsync(int id, params string[] includeList)
        {
            if (id <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(id);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<MusteriVarlikGetDto>(bankabilgi);
                return ApiResponse<MusteriVarlikGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetBySterlinHesapIDAsync(int SterlinHesapID, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetBySterlinHesapIDAsync(SterlinHesapID);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByVadeliTLHesapIDAsync(int VadeliTLHesapID, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByVadeliTLHesapIDAsync(VadeliTLHesapID);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetByVadesizTLHesapIDAsync(int VadesizTLHesapID, params string[] includeList)
        {
            var Musterivarlik = await _repo.GetByVadesizTLHesapIDAsync(VadesizTLHesapID);
            if (Musterivarlik != null && Musterivarlik.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(Musterivarlik);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriVarlikGetDto>>> GetMusteriVarlikAsync(params string[] includeList)
        {
            var MusteriData = await _repo.GetAllAsync(includeList: includeList);
            if (MusteriData != null && MusteriData.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriVarlikGetDto>>(MusteriData);
                return ApiResponse<List<MusteriVarlikGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<MusteriVarlik>> InsertAsync(MusteriVarlikPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<MusteriVarlik>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<MusteriVarlik>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(MusteriVarlikPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<MusteriVarlik>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }

      
    }
}
