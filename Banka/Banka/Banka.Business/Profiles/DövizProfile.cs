using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.DolarSwift;
using Banka.Model.Dtos.Doviz;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class DovizProfile : Profile
    {
        public DovizProfile()
        {
            CreateMap<Doviz, DovizGetDto>();
            CreateMap<DovizPostDto, Doviz>();
            CreateMap<DovizPutDto, Doviz>();

        }
    }
}
