using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.Faturaode;
using Banka.Model.Dtos.GümüsHesap;
using Banka.Model.Dtos.Harcama;
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
    public class HarcamaBs : IHarcamaBs
    {
        private readonly IHarcamaRepository _repo;
        private readonly IMapper _mapper;
        public HarcamaBs(IHarcamaRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<HarcamaGetDto>>> GetByHarcamaTarihiAsync(DateTime HarcamaTarihi, params string[] includeList)
        {
            var harcama = await _repo.GetByHarcamaTarihiAsync(HarcamaTarihi);
            if (harcama != null && harcama.Count > 0)
            {
                var returnList = _mapper.Map<List<HarcamaGetDto>>(harcama);
                return ApiResponse<List<HarcamaGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<HarcamaGetDto>>> GetByHarcananKartIDAsync(int HarcananKartID, params string[] includeList)
        {
            var harcama = await _repo.GetByHarcananKartIDAsync(HarcananKartID);
            if (harcama != null && harcama.Count > 0)
            {
                var returnList = _mapper.Map<List<HarcamaGetDto>>(harcama);
                return ApiResponse<List<HarcamaGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<HarcamaGetDto>>> GetByHarcananMiktarAsync(decimal HarcananMiktar, params string[] includeList)
        {
            var harcama = await _repo.GetByHarcananMiktarAsync(HarcananMiktar);
            if (harcama != null && harcama.Count > 0)
            {
                var returnList = _mapper.Map<List<HarcamaGetDto>>(harcama);
                return ApiResponse<List<HarcamaGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<HarcamaGetDto>> GetHarcamaByIdAsync(int HarcamaID, params string[] includeList)
        {
            if (HarcamaID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(HarcamaID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<HarcamaGetDto>(bankabilgi);
                return ApiResponse<HarcamaGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<HarcamaGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<HarcamaGetDto>(bankakartı);
                return ApiResponse<HarcamaGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<HarcamaGetDto>>> GetBySatıcıKoduAsync(string SatıcıKodu, params string[] includeList)
        {
            var harcama = await _repo.GetBySatıcıKoduAsync(SatıcıKodu);
            if (harcama != null && harcama.Count > 0)
            {
                var returnList = _mapper.Map<List<HarcamaGetDto>>(harcama);
                return ApiResponse<List<HarcamaGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<HarcamaGetDto>>> GetByTaksitMiktarıAsync(int TaksitMiktarı, params string[] includeList)
        {
            var harcama = await _repo.GetByTaksitMiktarıAsync(TaksitMiktarı);
            if (harcama != null && harcama.Count > 0)
            {
                var returnList = _mapper.Map<List<HarcamaGetDto>>(harcama);
                return ApiResponse<List<HarcamaGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<HarcamaGetDto>>> GetHarcamaAsync(params string[] includeList)
        {

            var Harcama = await _repo.GetAllAsync(includeList: includeList);
            if (Harcama != null && Harcama.Count > 0)
            {
                var returnList = _mapper.Map<List<HarcamaGetDto>>(Harcama);
                return ApiResponse<List<HarcamaGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<Harcama>> InsertAsync(HarcamaPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<Harcama>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<Harcama>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(HarcamaPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<Harcama>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
