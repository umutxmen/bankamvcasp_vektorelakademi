using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.VadesizTLHesap;
using Banka.Model.Dtos.VergiBorcuode;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class VergiBorcuodeProfile : Profile
    {
        public VergiBorcuodeProfile()
        {
            CreateMap<VergiBorcuOde, VergiBorcuOdeGetDto>();
            CreateMap<VergiBorcuOdePostDto, VergiBorcuOde>();
            CreateMap<VergiBorcuOdePutDto, VergiBorcuOde>();

        }
    }
}
