using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.DolarHesap;
using Banka.Model.Dtos.DolarSwift;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class DolarSwiftProfile : Profile
    {
        public DolarSwiftProfile()
        {
            CreateMap<DolarSwift, DolarSwiftGetDto>();
            CreateMap<DolarSwiftPostDto, DolarSwift>();
            CreateMap<DolarSwiftPutDto, DolarSwift>();

        }
    }
}
