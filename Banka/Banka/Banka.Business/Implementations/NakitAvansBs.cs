using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.MusteriData;
using Banka.Model.Dtos.MusteriVarlik;
using Banka.Model.Dtos.NakitAvans;
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
    public class NakitAvansBs : INakitAvansBs
    {
        private readonly INakitAvansRepository _repo;
        private readonly IMapper _mapper;
        public NakitAvansBs(INakitAvansRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<NakitAvansGetDto>>> GetByAktarılanİbanAsync(int Aktarılanİban, params string[] includeList)
        {
            var nakitavans = await _repo.GetByAktarılanİbanAsync(Aktarılanİban);
            if (nakitavans != null && nakitavans.Count > 0)
            {
                var returnList = _mapper.Map<List<NakitAvansGetDto>>(nakitavans);
                return ApiResponse<List<NakitAvansGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<NakitAvansGetDto>>> GetByAvansMiktarıAsync(decimal HeAvansMiktarısapAcimTarihi, params string[] includeList)
        {
            var nakitavans = await _repo.GetByAvansMiktarıAsync(HeAvansMiktarısapAcimTarihi);
            if (nakitavans != null && nakitavans.Count > 0)
            {
                var returnList = _mapper.Map<List<NakitAvansGetDto>>(nakitavans);
                return ApiResponse<List<NakitAvansGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<NakitAvansGetDto>>> GetByFaizoranıAsync(decimal Faizoranı, params string[] includeList)
        {
            var nakitavans = await _repo.GetByFaizoranıAsync(Faizoranı);
            if (nakitavans != null && nakitavans.Count > 0)
            {
                var returnList = _mapper.Map<List<NakitAvansGetDto>>(nakitavans);
                return ApiResponse<List<NakitAvansGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<NakitAvansGetDto>> GetByIdAsync(int NakitAvansID, params string[] includeList)
        {
            if (NakitAvansID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(NakitAvansID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<NakitAvansGetDto>(bankabilgi);
                return ApiResponse<NakitAvansGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<NakitAvansGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<NakitAvansGetDto>(bankakartı);
                return ApiResponse<NakitAvansGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<NakitAvansGetDto>>> GetBySonOdemeTarihiAsync(DateTime SonOdemeTarihi, params string[] includeList)
        {
            var nakitavans = await _repo.GetBySonOdemeTarihiAsync(SonOdemeTarihi);
            if (nakitavans != null && nakitavans.Count > 0)
            {
                var returnList = _mapper.Map<List<NakitAvansGetDto>>(nakitavans);
                return ApiResponse<List<NakitAvansGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<NakitAvansGetDto>>> GetByodenecekMiktarAsync(decimal odenecekMiktar, params string[] includeList)
        {
            var nakitavans = await _repo.GetByodenecekMiktarAsync(odenecekMiktar);
            if (nakitavans != null && nakitavans.Count > 0)
            {
                var returnList = _mapper.Map<List<NakitAvansGetDto>>(nakitavans);
                return ApiResponse<List<NakitAvansGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<NakitAvansGetDto>>> GetNakitAvansAsync(params string[] includeList)
        {
            var MusteriData = await _repo.GetAllAsync(includeList: includeList);
            if (MusteriData != null && MusteriData.Count > 0)
            {
                var returnList = _mapper.Map<List<NakitAvansGetDto>>(MusteriData);
                return ApiResponse<List<NakitAvansGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<NakitAvans>> InsertAsync(NakitAvansPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<NakitAvans>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<NakitAvans>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(NakitAvansPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<NakitAvans>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
