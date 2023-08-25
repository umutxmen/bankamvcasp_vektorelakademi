using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.MusteriData;
using Banka.Model.Dtos.MusteriVarlik;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class MusteriVarlikProfile : Profile
    {
        public MusteriVarlikProfile()
        {
            CreateMap<MusteriVarlik, MusteriVarlikGetDto>();
        //.ForMember(dest => dest.MusteriDataID, opt => opt.MapFrom(src => src.MusteriData.MusteriDataID));

            CreateMap<MusteriVarlikPostDto, MusteriVarlik>();
            CreateMap<MusteriVarlikPutDto, MusteriVarlik>();

        }
    }
}
