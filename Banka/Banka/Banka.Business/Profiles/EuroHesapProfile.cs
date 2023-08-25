using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.EFT;
using Banka.Model.Dtos.EuroHesap;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class EuroHesapProfile : Profile
    {
        public EuroHesapProfile()
        {
            CreateMap<EuroHesap, EuroHesapGetDto>();
            CreateMap<EuroHesapPostDto, EuroHesap>();
            CreateMap<EuroHesapPutDto, EuroHesap>();

        }
    }
}
