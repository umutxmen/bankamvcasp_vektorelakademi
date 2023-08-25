using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.KurKorumalıHesap;
using Banka.Model.Dtos.MusteriData;
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
    public class MusteriDataBs : IMusteriDataBs
    {
        private readonly IMusteriDataRepository _repo;
        private readonly IMapper _mapper;
        public MusteriDataBs(IMusteriDataRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<MusteriDataGetDto>> GetMusteriDataByIdAsync(int id, params string[] includeList)
        {
            if (id <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(id);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<MusteriDataGetDto>(bankabilgi);
                return ApiResponse<MusteriDataGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriADAsync(string MusteriAD, params string[] includeList)
        {
            var Musteridata = await _repo.GetByMusteriADAsync(MusteriAD);
            if (Musteridata != null && Musteridata.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriDataGetDto>>(Musteridata);
                return ApiResponse<List<MusteriDataGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriAdresAsync(string MusteriAdres, params string[] includeList)
        {
            var Musteridata = await _repo.GetByMusteriAdresAsync(MusteriAdres);
            if (Musteridata != null && Musteridata.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriDataGetDto>>(Musteridata);
                return ApiResponse<List<MusteriDataGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriAnneliksoyadAsync(string MusteriAnneliksoyad, params string[] includeList)
        {
            var Musteridata = await _repo.GetByMusteriAnneliksoyadAsync(MusteriAnneliksoyad);
            if (Musteridata != null && Musteridata.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriDataGetDto>>(Musteridata);
                return ApiResponse<List<MusteriDataGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriEmailAsync(string MusteriEmail, params string[] includeList)
        {
            var Musteridata = await _repo.GetByMusteriEmailAsync(MusteriEmail);
            if (Musteridata != null && Musteridata.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriDataGetDto>>(Musteridata);
                return ApiResponse<List<MusteriDataGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

     

        public async Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriMeslekAsync(string MusteriMeslek, params string[] includeList)
        {
            var Musteridata = await _repo.GetByMusteriMeslekAsync(MusteriMeslek);
            if (Musteridata != null && Musteridata.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriDataGetDto>>(Musteridata);
                return ApiResponse<List<MusteriDataGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriSoYADAsync(string MusteriSoYAD, params string[] includeList)
        {
            var Musteridata = await _repo.GetByMusteriSoYADAsync(MusteriSoYAD);
            if (Musteridata != null && Musteridata.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriDataGetDto>>(Musteridata);
                return ApiResponse<List<MusteriDataGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriTCAsync(string MusteriTC, params string[] includeList)
        {
            var Musteridata = await _repo.GetByMusteriTCAsync(MusteriTC);
            if (Musteridata != null && Musteridata.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriDataGetDto>>(Musteridata);
                return ApiResponse<List<MusteriDataGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriTELAsync(string MusteriTEL, params string[] includeList)
        {
            var Musteridata = await _repo.GetByMusteriTELAsync(MusteriTEL);
            if (Musteridata != null && Musteridata.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriDataGetDto>>(Musteridata);
                return ApiResponse<List<MusteriDataGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

     //   public async Task<ApiResponse<List<MusteriDataGetDto>>> GetByMusteriVarlikIDAsync(int MusteriVarlikID, params string[] includeList)
      //  {
      //      var Musteridata = await _repo.GetByMusteriVarlikIDAsync(MusteriVarlikID);
       //     if (Musteridata != null && Musteridata.Count > 0)
       //     {
       //         var returnList = _mapper.Map<List<MusteriDataGetDto>>(Musteridata);
        //        return ApiResponse<List<MusteriDataGetDto>>.Success(StatusCodes.Status200OK, returnList);
        //    }
      //      throw new NotFoundException("İçerik Bulunamadı.");
     //   }

        public async Task<ApiResponse<List<MusteriDataGetDto>>> GetMusteriDataAsync(params string[] includeList)
        {
            var MusteriData = await _repo.GetAllAsync(includeList: includeList);
            if (MusteriData != null && MusteriData.Count > 0)
            {
                var returnList = _mapper.Map<List<MusteriDataGetDto>>(MusteriData);
                return ApiResponse<List<MusteriDataGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<MusteriData>> InsertAsync(MusteriDataPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<MusteriData>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<MusteriData>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(MusteriDataPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<MusteriData>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
