using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.KrediKartı;
using Banka.Model.Dtos.KurKorumalıHesap;
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
    public class KurKorumalıHesapBs : IKurKorumalıHesapBs
    {
        private readonly IKurKorumalıHesapRepository _repo;
        private readonly IMapper _mapper;
        public KurKorumalıHesapBs(IKurKorumalıHesapRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetByDovizIDAsync(int DovizID, params string[] includeList)
        {

            var kurkoruma = await _repo.GetByDovizIDAsync(DovizID);
            if (kurkoruma != null && kurkoruma.Count > 0)
            {
                var returnList = _mapper.Map<List<KurKorumalıHesapGetDto>>(kurkoruma);
                return ApiResponse<List<KurKorumalıHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetByHesapAcimKuruAsync(decimal HesapAcimKuru, params string[] includeList)
        {
            var kurkoruma = await _repo.GetByHesapAcimKuruAsync(HesapAcimKuru);
            if (kurkoruma != null && kurkoruma.Count > 0)
            {
                var returnList = _mapper.Map<List<KurKorumalıHesapGetDto>>(kurkoruma);
                return ApiResponse<List<KurKorumalıHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetByHesapAcimTarihiAsync(DateTime HesapAcimTarihi, params string[] includeList)
        {
            var kurkoruma = await _repo.GetByHesapAcimTarihiAsync(HesapAcimTarihi);
            if (kurkoruma != null && kurkoruma.Count > 0)
            {
                var returnList = _mapper.Map<List<KurKorumalıHesapGetDto>>(kurkoruma);
                return ApiResponse<List<KurKorumalıHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetByHesapFaizoranAsync(int HesapFaizoran, params string[] includeList)
        {
            var kurkoruma = await _repo.GetByHesapFaizoranAsync(HesapFaizoran);
            if (kurkoruma != null && kurkoruma.Count > 0)
            {
                var returnList = _mapper.Map<List<KurKorumalıHesapGetDto>>(kurkoruma);
                return ApiResponse<List<KurKorumalıHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetByHesapKapanmaKuruAsync(decimal HesapKapanmaKuru, params string[] includeList)
        {
            var kurkoruma = await _repo.GetByHesapKapanmaKuruAsync(HesapKapanmaKuru);
            if (kurkoruma != null && kurkoruma.Count > 0)
            {
                var returnList = _mapper.Map<List<KurKorumalıHesapGetDto>>(kurkoruma);
                return ApiResponse<List<KurKorumalıHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetByHesapKapanmaTarihiAsync(DateTime HesapKapanmaTarihi, params string[] includeList)
        {
            var kurkoruma = await _repo.GetByHesapKapanmaTarihiAsync(HesapKapanmaTarihi);
            if (kurkoruma != null && kurkoruma.Count > 0)
            {
                var returnList = _mapper.Map<List<KurKorumalıHesapGetDto>>(kurkoruma);
                return ApiResponse<List<KurKorumalıHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<KurKorumalıHesapGetDto>> GetByIdAsync(int KurKorumaliHesapId, params string[] includeList)
        {
            if (KurKorumaliHesapId <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(KurKorumaliHesapId);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<KurKorumalıHesapGetDto>(bankabilgi);
                return ApiResponse<KurKorumalıHesapGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<KurKorumalıHesapGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<KurKorumalıHesapGetDto>(bankakartı);
                return ApiResponse<KurKorumalıHesapGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetByVarlikTLAsync(decimal VarlikTL, params string[] includeList)
        {
            var kurkoruma = await _repo.GetByVarlikTLAsync(VarlikTL);
            if (kurkoruma != null && kurkoruma.Count > 0)
            {
                var returnList = _mapper.Map<List<KurKorumalıHesapGetDto>>(kurkoruma);
                return ApiResponse<List<KurKorumalıHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetKurKorumalıHesapAsync(params string[] includeList)
        {
            var KurKorumalıHesap = await _repo.GetAllAsync(includeList: includeList);
            if (KurKorumalıHesap != null && KurKorumalıHesap.Count > 0)
            {
                var returnList = _mapper.Map<List<KurKorumalıHesapGetDto>>(KurKorumalıHesap);
                return ApiResponse<List<KurKorumalıHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<KurKorumalıHesap>> InsertAsync(KurKorumalıHesapPostDto dto)
        {

            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<KurKorumalıHesap>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<KurKorumalıHesap>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(KurKorumalıHesapPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<KurKorumalıHesap>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
