using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.Harcama;
using Banka.Model.Dtos.HizliKredi;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class HizliKrediProfile : Profile
    {
        public HizliKrediProfile()
        {
            CreateMap<HizliKredi, HizliKrediGetDto>();
            CreateMap<HizliKrediPostDto, HizliKredi>();
            CreateMap<HizliKrediPutDto, HizliKredi>();

        }
    }
}
