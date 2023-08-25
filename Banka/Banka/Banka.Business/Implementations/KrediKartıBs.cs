using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.KartaParaAktar;
using Banka.Model.Dtos.Kartlar;
using Banka.Model.Dtos.KrediKartı;
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
    public class KrediKartıBs : IKrediKartıBs
    {
        private readonly IKrediKartıRepository _repo;
        private readonly IMapper _mapper;
        public KrediKartıBs(IKrediKartıRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<KrediKartıGetDto>>> GetByBaglıİbanAsync(string Baglıİban, params string[] includeList)
        {
            var kredikart = await _repo.GetByBaglıİbanAsync(Baglıİban);
            if (kredikart != null && kredikart.Count > 0)
            {
                var returnList = _mapper.Map<List<KrediKartıGetDto>>(kredikart);
                return ApiResponse<List<KrediKartıGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<KrediKartıGetDto>> GetByIdAsync(int KrediKartıID, params string[] includeList)
        {
            if (KrediKartıID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(KrediKartıID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<KrediKartıGetDto>(bankabilgi);
                return ApiResponse<KrediKartıGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KrediKartıGetDto>>> GetByKartCVCNoAsync(int KartCVCNo, params string[] includeList)
        {
            var kredikart = await _repo.GetByKartCVCNoAsync(KartCVCNo);
            if (kredikart != null && kredikart.Count > 0)
            {
                var returnList = _mapper.Map<List<KrediKartıGetDto>>(kredikart);
                return ApiResponse<List<KrediKartıGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KrediKartıGetDto>>> GetByKartkullanımAyAsync(int KartkullanımAy, params string[] includeList)
        {
            var kredikart = await _repo.GetByKartkullanımAyAsync(KartkullanımAy);
            if (kredikart != null && kredikart.Count > 0)
            {
                var returnList = _mapper.Map<List<KrediKartıGetDto>>(kredikart);
                return ApiResponse<List<KrediKartıGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KrediKartıGetDto>>> GetByKartkullanımYılAsync(int KartkullanımYıl, params string[] includeList)
        {
            var kredikart = await _repo.GetByKartkullanımYılAsync(KartkullanımYıl);
            if (kredikart != null && kredikart.Count > 0)
            {
                var returnList = _mapper.Map<List<KrediKartıGetDto>>(kredikart);
                return ApiResponse<List<KrediKartıGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KrediKartıGetDto>>> GetByKartNoAsync(string KartNo, params string[] includeList)
        {
            var kredikart = await _repo.GetByKartNoAsync(KartNo);
            if (kredikart != null && kredikart.Count > 0)
            {
                var returnList = _mapper.Map<List<KrediKartıGetDto>>(kredikart);
                return ApiResponse<List<KrediKartıGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KrediKartıGetDto>>> GetByKartSahipAdAsync(string KartSahipAd, params string[] includeList)
        {
            var kredikart = await _repo.GetByKartSahipAdAsync(KartSahipAd);
            if (kredikart != null && kredikart.Count > 0)
            {
                var returnList = _mapper.Map<List<KrediKartıGetDto>>(kredikart);
                return ApiResponse<List<KrediKartıGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KrediKartıGetDto>>> GetByKartSahipSoyadAsync(string KartSahipSoyad, params string[] includeList)
        {
            var kredikart = await _repo.GetByKartSahipSoyadAsync(KartSahipSoyad);
            if (kredikart != null && kredikart.Count > 0)
            {
                var returnList = _mapper.Map<List<KrediKartıGetDto>>(kredikart);
                return ApiResponse<List<KrediKartıGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KrediKartıGetDto>>> GetByKartTeknolojisiAsync(string KartTeknolojisi, params string[] includeList)
        {
            var kredikart = await _repo.GetByKartTeknolojisiAsync(KartTeknolojisi);
            if (kredikart != null && kredikart.Count > 0)
            {
                var returnList = _mapper.Map<List<KrediKartıGetDto>>(kredikart);
                return ApiResponse<List<KrediKartıGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<KrediKartıGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<KrediKartıGetDto>(bankakartı);
                return ApiResponse<KrediKartıGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KrediKartıGetDto>>> GetKrediKartıAsync(params string[] includeList)
        {
            var Kartlar = await _repo.GetAllAsync(includeList: includeList);
            if (Kartlar != null && Kartlar.Count > 0)
            {
                var returnList = _mapper.Map<List<KrediKartıGetDto>>(Kartlar);
                return ApiResponse<List<KrediKartıGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<KrediKartı>> InsertAsync(KrediKartıPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<KrediKartı>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<KrediKartı>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(KrediKartıPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<KrediKartı>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
