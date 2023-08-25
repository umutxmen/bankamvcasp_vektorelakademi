using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.KartaParaAktar;
using Banka.Model.Dtos.Kartlar;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class KartlarProfile : Profile
    {
        public KartlarProfile()
        {
            CreateMap<Kartlar, KartlarGetDto>();
            CreateMap<KartlarPostDto, Kartlar>();
            CreateMap<KartlarPutDto, Kartlar>();

        }
    }
}
