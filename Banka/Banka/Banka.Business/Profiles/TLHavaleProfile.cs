using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.SterlinHesap;
using Banka.Model.Dtos.TLHavale;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class TLHavaleProfile : Profile
    {
        public TLHavaleProfile()
        {
            CreateMap<TLHavale, TLHavaleGetDto>();
            CreateMap<TLHavalePostDto, TLHavale>();
            CreateMap<TLHavalePutDto, TLHavale>();

        }
    }
}
