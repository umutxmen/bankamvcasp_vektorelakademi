using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.EuroSwift;
using Banka.Model.Dtos.Faturaode;
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
    public class FaturaOdeBs : IFaturaOdeBs
    {
        private readonly IFaturaOdeRepository _repo;
        private readonly IMapper _mapper;
        public FaturaOdeBs(IFaturaOdeRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<FaturaOdeGetDto>>> GetByAciklamaAsync(string Aciklama, params string[] includeList)
        {
            var faturaOde = await _repo.GetByAciklamaAsync(Aciklama);
            if (faturaOde != null && faturaOde.Count > 0)
            {
                var returnList = _mapper.Map<List<FaturaOdeGetDto>>(faturaOde);
                return ApiResponse<List<FaturaOdeGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");        }

        public async Task<ApiResponse<List<FaturaOdeGetDto>>> GetByfaturanoAsync(string faturano, params string[] includeList)
        {
            var faturaOde = await _repo.GetByfaturanoAsync(faturano);
            if (faturaOde != null && faturaOde.Count > 0)
            {
                var returnList = _mapper.Map<List<FaturaOdeGetDto>>(faturaOde);
                return ApiResponse<List<FaturaOdeGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }
    

        public async Task<ApiResponse<List<FaturaOdeGetDto>>> GetByGonderenİbanAsync(string Gonderenİban, params string[] includeList)
        {
        var faturaOde = await _repo.GetByGonderenİbanAsync(Gonderenİban);
        if (faturaOde != null && faturaOde.Count > 0)
        {
            var returnList = _mapper.Map<List<FaturaOdeGetDto>>(faturaOde);
            return ApiResponse<List<FaturaOdeGetDto>>.Success(StatusCodes.Status200OK, returnList);
        }
        throw new NotFoundException("İçerik Bulunamadı.");
      }


        public async Task<ApiResponse<FaturaOdeGetDto>> GetByIdAsync(int FaturaYatırİslemID, params string[] includeList)
        {
            if (FaturaYatırİslemID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(FaturaYatırİslemID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<FaturaOdeGetDto>(bankabilgi);
                return ApiResponse<FaturaOdeGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<FaturaOdeGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<FaturaOdeGetDto>(bankakartı);
                return ApiResponse<FaturaOdeGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<FaturaOdeGetDto>>> GetByOdemeTarihAsync(DateTime OdemeTarih, params string[] includeList)
        {
            var faturaOde = await _repo.GetByOdemeTarihAsync(OdemeTarih);
            if (faturaOde != null && faturaOde.Count > 0)
            {
                var returnList = _mapper.Map<List<FaturaOdeGetDto>>(faturaOde);
                return ApiResponse<List<FaturaOdeGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<FaturaOdeGetDto>>> GetByodenecekMiktarAsync(decimal odenecekMiktar, params string[] includeList)
        {
            var faturaOde = await _repo.GetByodenecekMiktarAsync(odenecekMiktar);
            if (faturaOde != null && faturaOde.Count > 0)
            {
                var returnList = _mapper.Map<List<FaturaOdeGetDto>>(faturaOde);
                return ApiResponse<List<FaturaOdeGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<FaturaOdeGetDto>>> GetFaturaOdeAsync(params string[] includeList)
        {

            var faturaOde = await _repo.GetAllAsync(includeList: includeList);
            if (faturaOde != null && faturaOde.Count > 0)
            {
                var returnList = _mapper.Map<List<FaturaOdeGetDto>>(faturaOde);
                return ApiResponse<List<FaturaOdeGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<FaturaOde>> InsertAsync(FaturaOdePostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakarti = _mapper.Map<FaturaOde>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakarti);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<FaturaOde>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(FaturaOdePutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<FaturaOde>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
