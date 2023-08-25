using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.GümüsHesap;
using Banka.Model.Dtos.Harcama;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class HarcamaProfile : Profile
    {
        public HarcamaProfile()
        {
            CreateMap<Harcama, HarcamaGetDto>();
            CreateMap<HarcamaPostDto, Harcama>();
            CreateMap<HarcamaPutDto, Harcama>();

        }
    }
}
