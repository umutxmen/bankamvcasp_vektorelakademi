using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.BankaBilgi;
using Banka.Model.Dtos.DolarHesap;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class DolarHesapProfile : Profile
    {
        public DolarHesapProfile()
        {
            CreateMap<DolarHesap, DolarHesapGetDto>();
            CreateMap<DolarHesapPostDto, DolarHesap>();
            CreateMap<DolarHesapPutDto, DolarHesap>();

        }
    }
}
