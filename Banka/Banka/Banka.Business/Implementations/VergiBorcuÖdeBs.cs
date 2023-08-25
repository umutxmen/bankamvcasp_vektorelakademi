using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Implementations.EFCore.Repositories;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.VadesizTLHesap;
using Banka.Model.Dtos.VergiBorcuode;
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
    public class VergiBorcuOdeBs : IVergiBorcuOdeBs
    {
        private readonly IVergiBorcuOdeRepository _repo;
        private readonly IMapper _mapper;
        public VergiBorcuOdeBs(IVergiBorcuOdeRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetByAciklamaAsync(string Aciklama, params string[] includeList)
        {
            var vergiborcu = await _repo.GetByAciklamaAsync(Aciklama);
            if (vergiborcu != null && vergiborcu.Count > 0)
            {
                var returnList = _mapper.Map<List<VergiBorcuOdeGetDto>>(vergiborcu);
                return ApiResponse<List<VergiBorcuOdeGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetByGondericiADAsync(string GondericiAD, params string[] includeList)
        {
            var vergiborcu = await _repo.GetByGondericiADAsync(GondericiAD);
            if (vergiborcu != null && vergiborcu.Count > 0)
            {
                var returnList = _mapper.Map<List<VergiBorcuOdeGetDto>>(vergiborcu);
                return ApiResponse<List<VergiBorcuOdeGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetByGondericiIBANAsync(string GondericiIBAN, params string[] includeList)
        {
            var vergiborcu = await _repo.GetByGondericiIBANAsync(GondericiIBAN);
            if (vergiborcu != null && vergiborcu.Count > 0)
            {
                var returnList = _mapper.Map<List<VergiBorcuOdeGetDto>>(vergiborcu);
                return ApiResponse<List<VergiBorcuOdeGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetByGondericiSoyadAsync(string GondericiSoyad, params string[] includeList)
        {
            var vergiborcu = await _repo.GetByGondericiSoyadAsync(GondericiSoyad);
            if (vergiborcu != null && vergiborcu.Count > 0)
            {
                var returnList = _mapper.Map<List<VergiBorcuOdeGetDto>>(vergiborcu);
                return ApiResponse<List<VergiBorcuOdeGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<VergiBorcuOdeGetDto>> GetByIdAsync(int VergiOdeİslemID, params string[] includeList)
        {
            if (VergiOdeİslemID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(VergiOdeİslemID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<VergiBorcuOdeGetDto>(bankabilgi);
                return ApiResponse<VergiBorcuOdeGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<VergiBorcuOdeGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<VergiBorcuOdeGetDto>(bankakartı);
                return ApiResponse<VergiBorcuOdeGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetByMusteriTCNoAsync(string MusteriTCNo, params string[] includeList)
        {
            var vergiborcu = await _repo.GetByMusteriTCNoAsync(MusteriTCNo);
            if (vergiborcu != null && vergiborcu.Count > 0)
            {
                var returnList = _mapper.Map<List<VergiBorcuOdeGetDto>>(vergiborcu);
                return ApiResponse<List<VergiBorcuOdeGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetByverginoAsync(string vergino, params string[] includeList)
        {
            var vergiborcu = await _repo.GetByverginoAsync(vergino);
            if (vergiborcu != null && vergiborcu.Count > 0)
            {
                var returnList = _mapper.Map<List<VergiBorcuOdeGetDto>>(vergiborcu);
                return ApiResponse<List<VergiBorcuOdeGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetByOdemeTarihAsync(DateTime OdemeTarih, params string[] includeList)
        {
            var vergiborcu = await _repo.GetByOdemeTarihAsync(OdemeTarih);
            if (vergiborcu != null && vergiborcu.Count > 0)
            {
                var returnList = _mapper.Map<List<VergiBorcuOdeGetDto>>(vergiborcu);
                return ApiResponse<List<VergiBorcuOdeGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetVergiBorcuOdeAsync(params string[] includeList)
        {
            var vergib = await _repo.GetAllAsync(includeList: includeList);
            if (vergib != null && vergib.Count > 0)
            {
                var returnList = _mapper.Map<List<VergiBorcuOdeGetDto>>(vergib);
                return ApiResponse<List<VergiBorcuOdeGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<VergiBorcuOde>> InsertAsync(VergiBorcuOdePostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<VergiBorcuOde>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<VergiBorcuOde>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(VergiBorcuOdePutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<VergiBorcuOde>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
