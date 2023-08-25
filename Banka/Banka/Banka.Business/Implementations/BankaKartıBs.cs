using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.BankaBilgi;
using Banka.Model.Dtos.BankaKartı;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WS.DataAccess.Interfaces;

namespace Banka.Business.Implementations
{
    public class BankaKartiBs : IBankaKartiBs
    {
        private readonly IBankaKartiRepository _repo;
        private readonly IMapper _mapper;
        public BankaKartiBs(IBankaKartiRepository repo, IMapper mapper)
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
            var bankakartı = await _repo.GetByIdAsync(id);
            if (bankakartı != null)
            {
                await _repo.DeleteAsync(bankakartı);
                return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
            }
            throw new NotFoundException("Silinecek olan içerik bulunamadı.");
        }

        public async Task<ApiResponse<List<BankaKartiGetDto>>> GetBankaKartiAsync(params string[] includeList)
        {
            var bankakartı = await _repo.GetAllAsync(includeList: includeList);
            if (bankakartı != null && bankakartı.Count > 0)
            {
                var returnList = _mapper.Map<List<BankaKartiGetDto>>(bankakartı);
                return ApiResponse<List<BankaKartiGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<BankaKartiGetDto>>> GetByBagliIbanAsync(string Bagliİban, params string[] includeList)
        {
            var bankakarti = await _repo.GetByBagliIbanAsync(Bagliİban, includeList);
            if (bankakarti != null && bankakarti.Count > 0)
            {
                var returnList = _mapper.Map<List<BankaKartiGetDto>>(bankakarti);
                return ApiResponse<List<BankaKartiGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<BankaKartiGetDto>> GetBankaKartByIDAsync(int id, params string[] includeList)
        {
            if (id <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByIdAsync(id);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<BankaKartiGetDto>(bankakartı);
                return ApiResponse<BankaKartiGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<BankaKartiGetDto>>> GetByKartNoAsync(string KartNo, params string[] includeList)
        {
            var bankakartı = await _repo.GetByKartNoAsync(KartNo, includeList);
            if (bankakartı != null && bankakartı.Count > 0)
            {
                var returnList = _mapper.Map<List<BankaKartiGetDto>>(bankakartı);
                return ApiResponse<List<BankaKartiGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<BankaKartiGetDto>>> GetByKartSahipAdAsync(string KartSahipAd, params string[] includeList)
        {
            var bankakartı = await _repo.GetByKartSahipAdAsync(KartSahipAd, includeList);
            if (bankakartı != null && bankakartı.Count > 0)
            {
                var returnList = _mapper.Map<List<BankaKartiGetDto>>(bankakartı);
                return ApiResponse<List<BankaKartiGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<BankaKartiGetDto>>> GetByKartSahipSoyadAsync(string KartSahipSoyad, params string[] includeList)
        {
            var bankakartı = await _repo.GetByKartSahipSoyadAsync(KartSahipSoyad, includeList);
            if (bankakartı != null && bankakartı.Count > 0)
            {
                var returnList = _mapper.Map<List<BankaKartiGetDto>>(bankakartı);
                return ApiResponse<List<BankaKartiGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<BankaKartiGetDto>>> GetByKartSonKullanimAyAsync(int KartSonKullanımAy, params string[] includeList)
        {
            var bankakartı = await _repo.GetByKartSonKullanimAyAsync(KartSonKullanımAy, includeList);
            if (bankakartı != null && bankakartı.Count > 0)
            {
                var returnList = _mapper.Map<List<BankaKartiGetDto>>(bankakartı);
                return ApiResponse<List<BankaKartiGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async  Task<ApiResponse<List<BankaKartiGetDto>>> GetByKartSonKullanimYilAsync(int KartSonKullanımYıl, params string[] includeList)
        {
            var bankakartı = await _repo.GetByKartSonKullanimYilAsync(KartSonKullanımYıl, includeList);
            if (bankakartı != null && bankakartı.Count > 0)
            {
                var returnList = _mapper.Map<List<BankaKartiGetDto>>(bankakartı);
                return ApiResponse<List<BankaKartiGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<BankaKartiGetDto>>> GetByKartTeknolojisiAsync(string KartTeknolojisi, params string[] includeList)
        {
            var bankakartı = await _repo.GetByKartTeknolojisiAsync(KartTeknolojisi, includeList);
            if (bankakartı != null && bankakartı.Count > 0)
            {
                var returnList = _mapper.Map<List<BankaKartiGetDto>>(bankakartı);
                return ApiResponse<List<BankaKartiGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<BankaKartiGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<BankaKartiGetDto>(bankakartı);
                return ApiResponse<BankaKartiGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<BankaKarti>> InsertAsync(BankaKartiPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }
          

            var bankakartı = _mapper.Map<BankaKarti>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<BankaKarti>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(BankaKartiPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }
           
           
            var employee = _mapper.Map<BankaKarti>(dto);
            await _repo.UpdateAsync(employee);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
