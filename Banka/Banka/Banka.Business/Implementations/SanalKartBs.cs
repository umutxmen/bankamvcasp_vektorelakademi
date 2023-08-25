using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.NakitAvans;
using Banka.Model.Dtos.SanalKart;
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
    public class SanalKartBs : ISanalKartBs
    {
        private readonly ISanalKartRepository _repo;
        private readonly IMapper _mapper;
        public SanalKartBs(ISanalKartRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<SanalKartGetDto>>> GetByBagliKrediKartIDAsync(int BagliKrediKartID, params string[] includeList)
        {
            var sanalkart = await _repo.GetByBagliKrediKartIDAsync(BagliKrediKartID);
            if (sanalkart != null && sanalkart.Count > 0)
            {
                var returnList = _mapper.Map<List<SanalKartGetDto>>(sanalkart);
                return ApiResponse<List<SanalKartGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<SanalKartGetDto>> GetByIdAsync(int SanalKartID, params string[] includeList)
        {
            if (SanalKartID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(SanalKartID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<SanalKartGetDto>(bankabilgi);
                return ApiResponse<SanalKartGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SanalKartGetDto>>> GetByKartCVCNoAsync(int KartCVCNo, params string[] includeList)
        {
            var sanalkart = await _repo.GetByKartCVCNoAsync(KartCVCNo);
            if (sanalkart != null && sanalkart.Count > 0)
            {
                var returnList = _mapper.Map<List<SanalKartGetDto>>(sanalkart);
                return ApiResponse<List<SanalKartGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SanalKartGetDto>>> GetByKartKullanumYılAsync(int KartKullanumYıl, params string[] includeList)
        {
            var sanalkart = await _repo.GetByKartKullanumYılAsync(KartKullanumYıl);
            if (sanalkart != null && sanalkart.Count > 0)
            {
                var returnList = _mapper.Map<List<SanalKartGetDto>>(sanalkart);
                return ApiResponse<List<SanalKartGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SanalKartGetDto>>> GetByKartKullanımAyAsync(int KartKullanımAy, params string[] includeList)
        {
            var sanalkart = await _repo.GetByKartKullanımAyAsync(KartKullanımAy);
            if (sanalkart != null && sanalkart.Count > 0)
            {
                var returnList = _mapper.Map<List<SanalKartGetDto>>(sanalkart);
                return ApiResponse<List<SanalKartGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SanalKartGetDto>>> GetByKartNoAsync(string KartNo, params string[] includeList)
        {
            var sanalkart = await _repo.GetByKartNoAsync(KartNo);
            if (sanalkart != null && sanalkart.Count > 0)
            {
                var returnList = _mapper.Map<List<SanalKartGetDto>>(sanalkart);
                return ApiResponse<List<SanalKartGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SanalKartGetDto>>> GetByKartSahipAdAsync(string KartSahipAd, params string[] includeList)
        {
            var sanalkart = await _repo.GetByKartSahipAdAsync(KartSahipAd);
            if (sanalkart != null && sanalkart.Count > 0)
            {
                var returnList = _mapper.Map<List<SanalKartGetDto>>(sanalkart);
                return ApiResponse<List<SanalKartGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SanalKartGetDto>>> GetByKartSahipSoyadAsync(string KartSahipSoyad, params string[] includeList)
        {
            var sanalkart = await _repo.GetByKartSahipSoyadAsync(KartSahipSoyad);
            if (sanalkart != null && sanalkart.Count > 0)
            {
                var returnList = _mapper.Map<List<SanalKartGetDto>>(sanalkart);
                return ApiResponse<List<SanalKartGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SanalKartGetDto>>> GetByKartTeknolojisiAsync(string KartTeknolojisi, params string[] includeList)
        {
            var sanalkart = await _repo.GetByKartTeknolojisiAsync(KartTeknolojisi);
            if (sanalkart != null && sanalkart.Count > 0)
            {
                var returnList = _mapper.Map<List<SanalKartGetDto>>(sanalkart);
                return ApiResponse<List<SanalKartGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<SanalKartGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<SanalKartGetDto>(bankakartı);
                return ApiResponse<SanalKartGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SanalKartGetDto>>> GetSanalKartAsync(params string[] includeList)
        {
            var SanalKart = await _repo.GetAllAsync(includeList: includeList);
            if (SanalKart != null && SanalKart.Count > 0)
            {
                var returnList = _mapper.Map<List<SanalKartGetDto>>(SanalKart);
                return ApiResponse<List<SanalKartGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<SanalKart>> InsertAsync(SanalKartPostDto dto)
        {

            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<SanalKart>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<SanalKart>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(SanalKartPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<SanalKart>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
