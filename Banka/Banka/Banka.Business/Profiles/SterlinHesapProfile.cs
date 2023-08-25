using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.SanalKart;
using Banka.Model.Dtos.SterlinHesap;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class SterlinHesapProfile : Profile
    {
        public SterlinHesapProfile()
        {
            CreateMap<SterlinHesap, SterlinHesapGetDto>();
            CreateMap<SterlinHesapPostDto, SterlinHesap>();
            CreateMap<SterlinHesapPutDto, SterlinHesap>();

        }
    }
}
