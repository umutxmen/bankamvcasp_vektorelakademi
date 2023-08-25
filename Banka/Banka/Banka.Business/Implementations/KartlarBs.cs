using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.KartaParaAktar;
using Banka.Model.Dtos.Kartlar;
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
    public class KartlarBs : IKartlarBs
    {
        private readonly IKartlarRepository _repo;
        private readonly IMapper _mapper;
        public KartlarBs(IKartlarRepository repo, IMapper mapper)
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
            var bankabilgi = await _repo.GetByIDAsync(id);
            if (bankabilgi != null)
            {
                await _repo.DeleteAsync(bankabilgi);
                return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
            }
            throw new NotFoundException("Silinecek olan içerik bulunamadı.");
        }

        public async Task<ApiResponse<List<KartlarGetDto>>> GetByBankaKartı2IDAsync(int BankaKartı2ID, params string[] includeList)
        {
            var kart = await _repo.GetByBankaKartı2IDAsync(BankaKartı2ID);
            if (kart != null && kart.Count > 0)
            {
                var returnList = _mapper.Map<List<KartlarGetDto>>(kart);
                return ApiResponse<List<KartlarGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KartlarGetDto>>> GetByBankaKartı3IDAsync(int BankaKartı3ID, params string[] includeList)
        {
            var kart = await _repo.GetByBankaKartı3IDAsync(BankaKartı3ID);
            if (kart != null && kart.Count > 0)
            {
                var returnList = _mapper.Map<List<KartlarGetDto>>(kart);
                return ApiResponse<List<KartlarGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KartlarGetDto>>> GetByBankaKartıIDAsync(int BankaKartıID, params string[] includeList)
        {
            var kart = await _repo.GetByBankaKartıIDAsync(BankaKartıID);
            if (kart != null && kart.Count > 0)
            {
                var returnList = _mapper.Map<List<KartlarGetDto>>(kart);
                return ApiResponse<List<KartlarGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }



        public async Task<ApiResponse<KartlarGetDto>> GetByIDAsync(int id, params string[] includeList)
        {
            if (id <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIDAsync(id);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<KartlarGetDto>(bankabilgi);
                return ApiResponse<KartlarGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KartlarGetDto>>> GetByKrediKartı2IDAsync(int KrediKartı2ID, params string[] includeList)
        {
            var kart = await _repo.GetByKrediKartı2IDAsync(KrediKartı2ID);
            if (kart != null && kart.Count > 0)
            {
                var returnList = _mapper.Map<List<KartlarGetDto>>(kart);
                return ApiResponse<List<KartlarGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KartlarGetDto>>> GetByKrediKartı3IDAsync(int KrediKartı3ID, params string[] includeList)
        {
            var kart = await _repo.GetByKrediKartı3IDAsync(KrediKartı3ID);
            if (kart != null && kart.Count > 0)
            {
                var returnList = _mapper.Map<List<KartlarGetDto>>(kart);
                return ApiResponse<List<KartlarGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KartlarGetDto>>> GetByKrediKartıIDAsync(int KrediKartıID, params string[] includeList)
        {
            var kart = await _repo.GetByKrediKartıIDAsync(KrediKartıID);
            if (kart != null && kart.Count > 0)
            {
                var returnList = _mapper.Map<List<KartlarGetDto>>(kart);
                return ApiResponse<List<KartlarGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

       
        public async Task<ApiResponse<List<KartlarGetDto>>> GetBySanalKart2IDAsync(int SanalKart2ID, params string[] includeList)
        {
            var kart = await _repo.GetBySanalKart2IDAsync(SanalKart2ID);
            if (kart != null && kart.Count > 0)
            {
                var returnList = _mapper.Map<List<KartlarGetDto>>(kart);
                return ApiResponse<List<KartlarGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KartlarGetDto>>> GetBySanalKart3IDAsync(int SanalKart3ID, params string[] includeList)
        {
            var kart = await _repo.GetBySanalKart3IDAsync(SanalKart3ID);
            if (kart != null && kart.Count > 0)
            {
                var returnList = _mapper.Map<List<KartlarGetDto>>(kart);
                return ApiResponse<List<KartlarGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KartlarGetDto>>> GetBySanalKartIDAsync(int SanalKartID, params string[] includeList)
        {
            var kart = await _repo.GetBySanalKartIDAsync(SanalKartID);
            if (kart != null && kart.Count > 0)
            {
                var returnList = _mapper.Map<List<KartlarGetDto>>(kart);
                return ApiResponse<List<KartlarGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KartlarGetDto>>> GetKartlarAsync(params string[] includeList)
        {
            var Kartlar = await _repo.GetAllAsync(includeList: includeList);
            if (Kartlar != null && Kartlar.Count > 0)
            {
                var returnList = _mapper.Map<List<KartlarGetDto>>(Kartlar);
                return ApiResponse<List<KartlarGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<Kartlar>> InsertAsync(KartlarPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<Kartlar>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<Kartlar>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(KartlarPutDto dto)
        {

            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<Kartlar>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }

        public async Task<ApiResponse<KartlarGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<KartlarGetDto>(bankabilgi);
                return ApiResponse<KartlarGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

    }
}
