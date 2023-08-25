using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.BankaBilgi;
using Banka.Model.Dtos.DolarHesap;
using Banka.Model.Dtos.Doviz;
using Banka.Model.Dtos.GümüsHesap;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.DataAccess.Interfaces;

namespace Banka.Business.Implementations
{
    public class DovizBs : IDovizBs
    {
        private readonly IDovizRepository _repo;
        private readonly IMapper _mapper;
        public DovizBs(IDovizRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<DovizGetDto>>> GetByDovizAdıAsync(string DovizAdı, params string[] includeList)
        {
            var doviz = await _repo.GetByDovizAdıAsync(DovizAdı);
            if (doviz != null && doviz.Count > 0)
            {
                var returnList = _mapper.Map<List<DovizGetDto>>(doviz);
                return ApiResponse<List<DovizGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<DovizGetDto>>> GetByGüncelKurAlımAsync(decimal GüncelKurAlım, params string[] includeList)
        {
            var doviz = await _repo.GetByGüncelKurAlımAsync(GüncelKurAlım);
            if (doviz != null && doviz.Count > 0)
            {
                var returnList = _mapper.Map<List<DovizGetDto>>(doviz);
                return ApiResponse<List<DovizGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<DovizGetDto>>> GetByGüncelKurSatımAsync(decimal GüncelKurSatım, params string[] includeList)
        {
            var doviz = await _repo.GetByGüncelKurSatımAsync(GüncelKurSatım);
            if (doviz != null && doviz.Count > 0)
            {
                var returnList = _mapper.Map<List<DovizGetDto>>(doviz);
                return ApiResponse<List<DovizGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<DovizGetDto>> GetByIdAsync(int DovizID, params string[] includeList)
        {
            if (DovizID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(DovizID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<DovizGetDto>(bankabilgi);
                return ApiResponse<DovizGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<DovizGetDto>>> GetDovizAsync(params string[] includeList)
        {
            var doviz = await _repo.GetAllAsync(includeList: includeList);
            if (doviz != null && doviz.Count > 0)
            {
                var returnList = _mapper.Map<List<DovizGetDto>>(doviz);
                return ApiResponse<List<DovizGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<Doviz>> InsertAsync(DovizPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<Doviz>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<Doviz>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(DovizPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var doviz = _mapper.Map<Doviz>(dto);
            await _repo.UpdateAsync(doviz);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
