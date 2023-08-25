using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.Faturaode;
using Banka.Model.Dtos.GümüsHesap;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class GümüsHesapProfile : Profile
    {
        public GümüsHesapProfile()
        {
            CreateMap<GümüsHesap, GümüsHesapGetDto>();
            CreateMap<GümüsHesapPostDto, GümüsHesap>();
            CreateMap<GümüsHesapPutDto, GümüsHesap>();

        }
    }
}
