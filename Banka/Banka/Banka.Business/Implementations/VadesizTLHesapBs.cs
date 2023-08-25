using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.VadeliTLHesap;
using Banka.Model.Dtos.VadesizTLHesap;
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
    public class VadesizTLHesapBs : IVadesizTLHesapBs
    {
        private readonly IVadesizTLHesapRepository _repo;
        private readonly IMapper _mapper;
        public VadesizTLHesapBs(IVadesizTLHesapRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<VadesizTLHesapGetDto>>> GetByHesapTutarAsync(decimal HesapTutar, params string[] includeList)
        {

            var vadelitl = await _repo.GetByHesapTutarAsync(HesapTutar);
            if (vadelitl != null && vadelitl.Count > 0)
            {
                var returnList = _mapper.Map<List<VadesizTLHesapGetDto>>(vadelitl);
                return ApiResponse<List<VadesizTLHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VadesizTLHesapGetDto>>> GetByHesapAcilmaTarihAsync(DateTime HesapAcilmaTarih, params string[] includeList)
        {
            var vadelitl = await _repo.GetByHesapAcilmaTarihAsync(HesapAcilmaTarih);
            if (vadelitl != null && vadelitl.Count > 0)
            {
                var returnList = _mapper.Map<List<VadesizTLHesapGetDto>>(vadelitl);
                return ApiResponse<List<VadesizTLHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VadesizTLHesapGetDto>>> GetByHesapIBANAsync(string HesapIBAN, params string[] includeList)
        {
            var vadelitl = await _repo.GetByHesapIBANAsync(HesapIBAN);
            if (vadelitl != null && vadelitl.Count > 0)
            {
                var returnList = _mapper.Map<List<VadesizTLHesapGetDto>>(vadelitl);
                return ApiResponse<List<VadesizTLHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<VadesizTLHesapGetDto>> GetByIdAsync(int VadesizTLHesapID, params string[] includeList)
        {
            if (VadesizTLHesapID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(VadesizTLHesapID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<VadesizTLHesapGetDto>(bankabilgi);
                return ApiResponse<VadesizTLHesapGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<VadesizTLHesapGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<VadesizTLHesapGetDto>(bankakartı);
                return ApiResponse<VadesizTLHesapGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VadesizTLHesapGetDto>>> GetTLVadesizTLHesapAsync(params string[] includeList)
        {
            var vadelitl = await _repo.GetAllAsync(includeList: includeList);
            if (vadelitl != null && vadelitl.Count > 0)
            {
                var returnList = _mapper.Map<List<VadesizTLHesapGetDto>>(vadelitl);
                return ApiResponse<List<VadesizTLHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<VadesizTLHesap>> InsertAsync(VadesizTLHesapPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<VadesizTLHesap>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<VadesizTLHesap>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(VadesizTLHesapPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<VadesizTLHesap>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }

       
    }
}
