using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.KurKorumalıHesap;
using Banka.Model.Dtos.MusteriData;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class MusteriDataProfile : Profile
    {
        public MusteriDataProfile()
        {
            CreateMap<MusteriData, MusteriDataGetDto>();
            CreateMap<MusteriDataPostDto, MusteriData>();
            CreateMap<MusteriDataPutDto, MusteriData>();

        }
    }
}
