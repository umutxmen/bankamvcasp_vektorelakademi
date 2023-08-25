using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.EuroSwift;
using Banka.Model.Dtos.Faturaode;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class FaturaodeProfile : Profile
    {
        public FaturaodeProfile()
        {
            CreateMap<FaturaOde, FaturaOdeGetDto>();
            CreateMap<FaturaOdePostDto, FaturaOde>();
            CreateMap<FaturaOdePutDto, FaturaOde>();

        }
    }
}
