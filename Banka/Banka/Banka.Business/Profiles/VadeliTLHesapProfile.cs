using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.TLHavale;
using Banka.Model.Dtos.VadeliTLHesap;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class VadeliTLHesapProfile : Profile
    {
        public VadeliTLHesapProfile()
        {
            CreateMap<VadeliTLHesap, VadeliTLHesapGetDto>();
            CreateMap<VadeliTLHesapPostDto, VadeliTLHesap>();
            CreateMap<VadeliTLHesapPutDto, VadeliTLHesap>();

        }
    }
}
